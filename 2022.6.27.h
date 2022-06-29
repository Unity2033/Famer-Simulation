#pragma once
#include <iostream>
#include <string>

using namespace std;

// 셸 정렬
/*
void ShellSort(int array[], int size)
{
	int gap = 0;
	int key = 0;
	int i = 0;
	int j = 0;
	int count = 0;

	gap = size / 2;

	while (true)
	{
		if (gap % 2 == 0)
		{
			gap++;
		}

		for (i = gap; i < size; i++)
		{
			key = array[i];

			for (j = i - gap; j >= 0; j = j - gap)
			{
				if (key < array[j])
				{
					array[j + gap] = array[j];
				}
				else
				{
					break;
				}
			}

			array[j + gap] = key;
		}

		if (gap == 1)
			break;

		gap = gap / 2;
	}
}
*/

// main
/*
int main()
{
	// 셸 정렬
	
	int array[] = { 9,6,5,8,10,1,3,7,4,2 };
	int size = sizeof(array) / sizeof(int);

	ShellSort(array, size);

	for (int i = 0; i < size; i++)
	{
		std::cout << array[i] << " ";
	}

	// 단어의 개수 (20% ~ 30%)
	// 첫 줄에 영어 대소문자와 공백으로 이루어진 문자열이 주어집니다.
	// 이 문자열의 길이는 1,000,000을 넘지 않는다.
	// 단어는 공백 한개로 구분되며, 공백이 연속해서 나오는 경우는 없습니다.
	// 문자열은 공백으로 시작하거나 끝날 수 있습니다.

	//The Wind Case of Big Button   -> 6 
	// The First and Second a third -> 6

	std::string alphabet;
	std::getline(std::cin, alphabet);

	int count = 0;

	for (int i = 0; i < alphabet.length(); i++)
	{
		if (alphabet[i] == ' ')
		{
			count++;
		}
	}

	if (alphabet[0] == ' ')
	{
		count--;
	}

	if (alphabet[alphabet.length() - 1] == ' ')
	{
		count--;
	}

	std::cout << count + 1;

	return 0;
}
*/