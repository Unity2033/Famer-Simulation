#pragma once
#include <iostream>

using namespace std;

// 삽입 정렬
/*
void Insert(int array[], int n)
{
	int temp, j;

	for (int i = 1; i < n; i++)
	{
		// 45 <----- 45
		temp = array[i];

		//   j = 3    조건 (3 > 0 && 99 > 45) 
		for (j = i; i > 0 && array[j - 1] > temp; j--) // j를 --하므로 j는 0번째 인덱스를 가집니다.
		{
			// 성립이 되었을 때
			// [3]99 <---- [2] 99
			array[j] = array[j - 1];
		}

		// 1번째 인덱스에 처음에 94을 저장한 값을 넣어줍니다.
		array[j] = temp;
	}
}
*/

// main
/*
int main()
{
	// O(n^2) -> 거품 정렬 < 선택 정렬 < 삽입 정렬
	// 시간 복잡도 순서와 효율성

	// 삽입 정렬
	
				 // 23 99 94 45 38
	int array[] = { 99,23,94,45,38 };
	int size = sizeof(array) / sizeof(array[0]);

	Insert(array, size);

	for (int i = 0; i < size; i++)
	{
		std::cout << array[i] << " ";
	}


	// 거꾸로 읽는 문자열을 비교해주세요.
	string value_1;
	string value_2;

	cin >> value_1 >> value_2;

	string temp;

	for (int i = value_1.length() - 1; i >= 0; i--)
	{
		if (value_1[i] > value_2[i])
		{
			temp = value_1;
			break;
		}
		else if (value_1[i] < value_2[i])
		{
			temp = value_2;
			break;
		}
	}

	for (int i = value_1.length() - 1; i >= 0; i--)
	{
		cout << temp[i];
	}
}
*/