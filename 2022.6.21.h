#pragma once
#include <iostream>
#include <queue>
#include <vector>

int data = 7;
int check[7];

std::vector<int> vertex[8];
std::queue<int> Queue;

// 너비 우선 탐색
/*
void BreathSearch(int data)
{
	std::queue<int> Queue;
	Queue.push(data); // [1]
	check[data] = true; // Queue에 데이터가 들어온 상태를 확인합니다.

	while (!Queue.empty())
	{
		int temp = Queue.front();
		Queue.pop();
		std::cout << temp << " ";

		for (int i = 0; i < vertex[temp].size(); i++)
		{
			int element = vertex[temp][i];

			if (check[element] == false)
			{
				Queue.push(element);
				check[element] = true;
			}
		}
	}
}
*/

int main()
{
	// 주사위
	/*
	int dice[] = { 0,0,0 };
	int max = 0;
	int size = sizeof(dice) / sizeof(int);

	for (int i = 0; i < size; i++)
	{
		std::cin >> dice[i];
	}

	if (dice[0] == dice[1] && dice[0] == dice[2])
	{
		std::cout << 10000 + dice[0] * 10 << std::endl;
	}
	else if (dice[0] == dice[1] && dice[0] != dice[2])
	{
		std::cout << 1000 + dice[1] * 100 << std::endl;
	}
	else if (dice[0] == dice[1] && dice[0] != dice[2])
	{
		std::cout << 1000 + dice[0] * 100 << std::endl;
	}
	else if (dice[0] != dice[1] && dice[1] == dice[2])
	{
		std::cout << 1000 + dice[1] * 100 << std::endl;
	}
	else
	{
		for (int i = 0; i < size; i++)
		{
			if (max <= dice[i])
			{
				max = dice[i];
			}
		}

		std::cout << max << std::endl;
	}
	*/

	// 너비 우선 탐색
	/*
	// 1과 2를 연결합니다.
	vertex[1].push_back(2); // [1] (2)
	vertex[2].push_back(1); // [2] (1)

	// 1과 3을 연결합니다.
	vertex[1].push_back(3); // [1] (2) (3)
	vertex[3].push_back(1); // [3] (1)

	// 2와 3을 연결합니다.
	vertex[2].push_back(3); // [2] (1) (3)
	vertex[3].push_back(2); // [3] (1) (2)

	// 2와 4를 연결합니다.
	vertex[2].push_back(4);
	vertex[4].push_back(2);

	// 2와 5를 연결합니다.
	vertex[2].push_back(5);
	vertex[5].push_back(2);

	// 4와 5를 연결합니다.
	vertex[4].push_back(5);
	vertex[5].push_back(4);

	// 3과 6을 연결합니다.
	vertex[3].push_back(6);
	vertex[6].push_back(3);

	// 3과 7을 연결합니다.
	vertex[3].push_back(7);
	vertex[7].push_back(3);

	// 6과 7을 연결합니다.
	vertex[6].push_back(7);
	vertex[7].push_back(6);

	BreathSearch(1);
	*/

	return 0;
}