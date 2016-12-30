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
	int n_threads;
	vector <int> positions;
	void ParallelSearchCPU(string);
	void SequentialSearch(string);
	void ParallelSearchGPU(string);

public:
	TextSearch(string, int);
	vector <int> GetPositions();
	double GetElapsedTime();
	void SearchforWord(string, mode);

	TextSearch();
	~TextSearch();
};4