#pragma once
#include <iostream>

int Node[11];

/*
int ParentFind(int data)
{
	if (Node[data] == data)
	{
		return data;
	}

	return Node[data] = ParentFind(Node[data]);
}
*/

// 노드들을 연결해주는 함수
/*
void Union(int small, int big)
{
	small = ParentFind(small);
	big = ParentFind(big);

	if (small < big)
	{
		Node[big] = small;
	}
	else
	{
		Node[small] = big;
	}
}
*/

// 같은 집합인지 확인 함수
/*
int Find(int small, int big)
{
	small = ParentFind(small);
	big = ParentFind(big);

	if (small == big)
	{
		std::cout << "같은 집합입니다." << std::endl;
		return 1;
	}
	else
	{
		std::cout << "같은 집합이 아닙니다." << std::endl;
		return 0;
	}
}
*/

// main
/*
int main()
{
	// 프로그래머스 LV.1 (문자열 반복)
	
	int value = 0;
	int count = 0;
	int repeat = 0;

	std::string alphabet;

	std::cin >> value;

	for (int i = 0; i < value; i++)
	{
		std::cin >> repeat >> alphabet;

		for (int j = 0; j < alphabet.length(); j++)
		{
			while (repeat != count)
			{
				std::cout << alphabet[j]; // AABB
				count++;
			}
			count = 0;
		}
		std::cout << std::endl;
	}
	

	// 유니온 파인드
	int size = sizeof(Node) / sizeof(int);

	for (int i = 1; i < size; i++)
	{
		Node[i] = i;
	}

	Union(1, 2);
	Union(2, 3);

	return 0;
}
*/