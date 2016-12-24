#pragma once
#include <string>
#include <vector>
#include <iostream>
#include <omp.h>

using namespace std;

enum mode{ Parallel, Serial };
class TextSearch
{
private:
	string paragraph;
	double timeElapsed;
	vector <int> positions;
	void ParallelSearch(string);
	void SequentialSearch(string);

public:
	TextSearch(string);
	vector <int> GetPositions();
	double GetElapsedTime();
	void SearchforWord(string, mode);

	TextSearch();
	~TextSearch();
};