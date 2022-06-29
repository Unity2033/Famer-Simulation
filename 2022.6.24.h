#pragma once
#include <iostream>

// 힙 정렬
/*
#define Parent(x) (x-1)/2

void Heap(int array[], int n)
{
	for (int i = 1; i < n; i++)
	{
		int child = i;

		while (child > 0)
		{
			int root = Parent(child);

			if (array[root] < array[child])
			{
				int temp = array[root];
				array[root] = array[child];
				array[child] = temp;
			}

			child = root;
		}
	}
}
*/

// main
/*
int main()
{
	int data[] = { 9, 4, 7, 8, 5, 2, 1, 6, 3 };
	int size = sizeof(data) / sizeof(int);

	// 힙을 생성합니다.
	Heap(data, size);

	for (int i = size - 1; i >= 0; i--)
	{
		// 가장 큰 root를 맨 마지막 원소와 바꿔줍니다.
		int temp = data[i];
		data[i] = data[0];
		data[0] = temp;

		// 맨 마지막 원소를 제외하고 다시 힙을 생성합니다.
		Heap(data, i);
	}

	for (int Element : data)
	{
		std::cout << Element << " ";
	}

	return 0;
}
*/