#pragma once
#include <string>
#include <vector>
#include <iostream>
#include <omp.h>
#include <amp.h>

using namespace std;
using namespace concurrency;

enum mode{ ParallelCPU, Serial, ParallelGPU };
class TextSearch
{
private:
	string paragraph;
	double timeElapsed;
	
	vector <int> positions;
	void ParallelSearchCPU(string);
	void SequentialSearch(string);
	void ParallelSearchGPU(string);

public:
	TextSearch(string);
	vector <int> GetPositions();
	double GetElapsedTime();
	void SearchforWord(string, mode);

	TextSearch();
	~TextSearch();
};