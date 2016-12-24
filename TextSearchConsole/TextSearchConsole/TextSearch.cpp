#include "TextSearch.h"


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