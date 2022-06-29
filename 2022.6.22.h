#pragma once
#include <iostream>
#include <vector>

int value = 7;
int check[8];
std::vector<int> vertex[8];

/*
void DepthSearch(int data)
{
	if (check[data] == true)
	{
		return;
	}

	check[data] = true;
	std::cout << data << " ";

	for (int i = 0; i < vertex[data].size(); i++)
	{
		int temp = vertex[data][i];
		DepthSearch(temp);
	}
}
*/


int main()
{
    // 깊이 우선 탐색
	/*
	// 1 - 2 간선 연결
	vertex[1].push_back(2);
	vertex[2].push_back(1);

	// 1 - 3 간선 연결 
	vertex[1].push_back(3);
	vertex[3].push_back(1);

	// 2 - 3 간선 연결
	vertex[2].push_back(3);
	vertex[3].push_back(2);

	// 2 - 4 간선 연결
	vertex[2].push_back(4);
	vertex[4].push_back(2);

	// 2 - 5 간선 연결
	vertex[2].push_back(5);
	vertex[5].push_back(2);

	// 3 - 6 간선 연결
	vertex[3].push_back(6);
	vertex[6].push_back(3);

	// 3 - 7 간선 연결
	vertex[3].push_back(7);
	vertex[7].push_back(3);

	// 4 - 5 간선 연결
	vertex[4].push_back(5);
	vertex[5].push_back(4);

	// 6 - 7 간선 연결
	vertex[6].push_back(7);
	vertex[7].push_back(6);

	DepthSearch(1);
	*/

	return 0;
}