// TextSearchCpluse.cpp : Defines the exported functions for the DLL application.
//

#include<atlmem.h>
#include "stdafx.h"
#include<vector>
#include<atlalloc.h>
#include "TextSearchCpluse.h"


TextSearch::TextSearch(){}

TextSearch::~TextSearch(){}

TextSearch::TextSearch(string paragraph)
{
	this->paragraph = paragraph;
}

vector <int> TextSearch::GetPositions()
{
	return this->positions;
}
void TextSearch::SearchforWord(string keyword, mode searchMode)
{
	double timeEnd, timeBegin;

	if (searchMode == Parallel) {
		timeBegin = omp_get_wtime();
		ParallelSearch(keyword);
		timeEnd = omp_get_wtime();
	}
	else if (searchMode == Serial) {
		timeBegin = omp_get_wtime();
		SequentialSearch(keyword);
		timeEnd = omp_get_wtime();
	}
	timeElapsed = timeEnd - timeBegin;
}

void TextSearch::ParallelSearch(string keyword)
{
	bool found = true;
	int paragraphSize = paragraph.size();
	int keywordSize = keyword.size();
	omp_set_num_threads(10);

#pragma parallel omp for shared(keyword) private(found)
		for (int i = 0; i <= paragraphSize - keywordSize; i++)
		{
			found = true;
#pragma parallel omp shared(keyword, found)
			for (int k = 0; k < keywordSize; k++)
			{
				if (keyword[k] != paragraph[k + i])
				{
					found = false;
					break;
				}
			}
			if (found == true){
#pragma omp critical
				{
					positions.push_back(i);
				}
			}
		}
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
	__declspec(dllexport) TextSearch* Create_TextSearch_Obj(const char* keyword)
	{
		return new TextSearch(keyword);
	}
	__declspec(dllexport) void Delete_TextSearch_Obj(TextSearch* Obj)
	{
	   delete Obj;
	}
	__declspec(dllexport) double Execute_GetElapsedTime(TextSearch* Obj)
	{
		return Obj->GetElapsedTime();
	}
	__declspec(dllexport) void Execute_SearchforWord(TextSearch* Obj,const char* keyword, mode searchMode,int **data,long*len)
	{
		Obj->SearchforWord(keyword,searchMode);
		vector<int> result = Obj->GetPositions();
		*len = result.size();
		auto size = (*len)*sizeof(int);
		*data = static_cast<int*>(CoTaskMemAlloc(size));
		memcpy(*data, result.data(), size);
	}

	__declspec(dllexport) int subtract(int N, int M)
	{
		return N-M;
	}
	//double GetElapsedTime();
	//void SearchforWord(string, mode);
}