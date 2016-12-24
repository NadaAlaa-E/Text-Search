#include <iostream>
#include <string>
#include <fstream>
#include <streambuf>
#include "TextSearch.h"

using namespace std;

int main()
{
	ifstream t("RandomText.txt");
	string paragraph((istreambuf_iterator<char>(t)), istreambuf_iterator<char>());
	//string paragraph = "vhdlvwhbbcdahjvvejrewbnmasbcvkvavdkvkfhjvahlavhhalhllyexvefvchjkeruyewyehcdvnbznbm";
	while (true)
	{
		string keyword;
		mode searchMode;
		int choice; //1 for parallel 2 for serial

		printf("Please Enter Keyword: ");
		getline(cin, keyword);
		printf("Please Select Search Mode:\n1. Parallel Search\n2. Serial Search\n");
		cin >> choice;

		if (choice == 1) searchMode = Parallel;
		else searchMode = Serial;

		for (int i = 0; i < keyword.size(); i++) keyword[i] = tolower(keyword[i]);

		TextSearch textSearch(paragraph);
		textSearch.SearchforWord(keyword, searchMode);

		vector<int> positions = textSearch.GetPositions();

		if (positions.size()){
			printf("Found %d Instances at:\n", positions.size());
			for (int i = 0; i < positions.size(); i++)
				printf("%d\n", positions[i]);
		}
		else{
			printf("Not Found.\n");
		}
		printf("Time Elapsed: %f\n\n\n", textSearch.GetElapsedTime());
		cin.ignore();
	}
	return 0;
}