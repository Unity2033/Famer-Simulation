#pragma once
#include <iostream>

using namespace std;

// 선택 정렬
/*
void Select(int array[], int n)
{
	int temp = 0;
	int index = 0;

	for (int i = 0; i < n; i++)
	{
		int min = 1000;

		for (int j = i; j < n; j++)
		{
			if (min > array[j])
			{
				min = array[j];
				index = j;
			}
		}

		temp = array[i];

		array[i] = array[index];

		array[index] = temp;
	}
}
*/

// main
/*
int main()
{
	// 선택 정렬
	
	int array[] = { 6,7,9,3,5 };
	int size = sizeof(array) / sizeof(int);

	Select(array, size);

	for (int i = 0; i < size; i++)
	{
		std::cout << array[i] << std::endl;
	}
	

	// 프로그래머스 1단계 Level (곱셉)
	
	int value_1 = 0;
	int value_2 = 0;

	cin >> value_1 >> value_2;

	std::cout << value_2 % 10 * value_1 << std::endl;
	std::cout << value_2 / 10 % 10 * value_1 << std::endl;
	std::cout << value_2 / 100 * value_1 << std::endl;
	std::cout << value_1 * value_2 << std::endl;
	
}
*/
