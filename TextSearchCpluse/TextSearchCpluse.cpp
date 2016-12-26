// TextSearchCpluse.cpp : Defines the exported functions for the DLL application.
//

#include <atlmem.h>
#include "stdafx.h"
#include <vector>
#include <atlalloc.h>
#include "TextSearchCpluse.h"


TextSearch::TextSearch(){}

TextSearch::~TextSearch(){}

TextSearch::TextSearch(string paragraph, int n_threads)
{
	this->paragraph = paragraph;
	this->n_threads = n_threads;
}

vector <int> TextSearch::GetPositions()
{
	return this->positions;
}
void TextSearch::SearchforWord(string keyword, mode searchMode)
{
	double timeEnd, timeBegin;

	for (int i = 0; i < keyword.size(); i++) keyword[i] = tolower(keyword[i]);

	if (searchMode == ParallelCPU) {
		timeBegin = omp_get_wtime();
		ParallelSearchCPU(keyword);
		timeEnd = omp_get_wtime();
	}
	else if (searchMode == Serial) {
		timeBegin = omp_get_wtime();
		SequentialSearch(keyword);
		timeEnd = omp_get_wtime();
	}
	else{
		timeBegin = omp_get_wtime();
		ParallelSearchGPU(keyword);
		timeEnd = omp_get_wtime();
	}
	timeElapsed = timeEnd - timeBegin;
}

void TextSearch::ParallelSearchCPU(string keyword)
{
	bool found = true;
	int paragraphSize = paragraph.size();
	int keywordSize = keyword.size();

	omp_set_num_threads(n_threads);

#pragma omp parallel for shared(keyword) private(found)
	for (int i = 0; i <= paragraphSize - keywordSize; i++)
	{
		found = true;
		for (int k = 0; k < keywordSize; k++)
		{
			if (keyword[k] != paragraph[k + i])
			{
				found = false;
			}
		}
		if (found == true)
		{
#pragma omp critical
			{
				positions.push_back(i);
			}
		}
	}
	positions.push_back(omp_get_num_threads());
}

void TextSearch::SequentialSearch(string keyword)
{
	for (int i = 0; i + keyword.size() <= paragraph.size(); i++)
	{
		bool found = true;
		for (int k = 0; k < keyword.size(); k++)
		{
			if (keyword[k] != paragraph[k + i])
			{
				found = false;
				break;
			}
		}
		if (found == true)
			positions.push_back(i);
	}
}

void TextSearch::ParallelSearchGPU(string keyword)
{
	int paragraphSize = paragraph.size();
	int keywordSize = keyword.size();

	int *paragraphInt = new int[paragraphSize];
	int *keywordInt = new int[keywordSize];
	int *positionsInt = new int[paragraphSize - keywordSize + 1];

	for (int i = 0; i < paragraphSize; i++) paragraphInt[i] = paragraph[i];
	for (int i = 0; i < keywordSize; i++) keywordInt[i] = keyword[i];

	array_view<int, 1> a_gpu(paragraphSize - keywordSize + 1, paragraphInt);
	array_view<int, 1> b_gpu(keywordSize, keywordInt);
	array_view<int, 1> positions_gpu(paragraphSize - keywordSize + 1, positionsInt);

	parallel_for_each(a_gpu.extent, [=](index<1> idx) restrict(amp) {
		bool found = true;
		for (int i = 0; i < keywordSize; i++)
		{
			if (b_gpu(i) != a_gpu(idx + i)){
				found = false;
				break;
			}
		}
		if (found) positions_gpu[idx] = 1;
	});

	for (int i = 0; i <= paragraphSize - keywordSize; i++) {
		if (positions_gpu(i) == 1) positions.push_back(i);
	}

	delete[] paragraphInt;
	delete[] keywordInt;
	delete[] positionsInt;
	/*parallel_for(0, paragraphSize - keywordSize + 1, [&keyword, &paragraph, &pos, keywordSize](int i)
	{
		bool found = true;
		for (int j = 0; j < keywordSize; j++)
		{
			if (keyword[j] != paragraph[j + i])
			{
				found = false;
				break;
			}
		}
		if (found)
			pos.push_back(i);
	});
	positions = pos;*/
}

double TextSearch::GetElapsedTime()
{
	return timeElapsed;
}


extern "C"
{/*
	__declspec(dllexport) TextSearch* Create_TextSearch_Obj()
	{
	return new TextSearch();
	}*/
	__declspec(dllexport) TextSearch* Create_TextSearch_Obj(const char* paragraph_, const int n_threads_)
	{
		return new TextSearch(paragraph_, n_threads_);
	}
	__declspec(dllexport) void Delete_TextSearch_Obj(TextSearch* Obj)
	{
		delete Obj;
	}
	__declspec(dllexport) double Execute_GetElapsedTime(TextSearch* Obj)
	{
		return Obj->GetElapsedTime();
	}
	__declspec(dllexport) void Execute_SearchforWord(TextSearch* Obj, const char* keyword, mode searchMode, int **data, long*len)
	{
		Obj->SearchforWord(keyword, searchMode);
		vector<int> result = Obj->GetPositions();
		*len = result.size();
		auto size = (*len)*sizeof(int);
		*data = static_cast<int*>(CoTaskMemAlloc(size));
		memcpy(*data, result.data(), size);
	}
	__declspec(dllexport) int subtract(int N, int M)
	{
		return N - M;
	}
}