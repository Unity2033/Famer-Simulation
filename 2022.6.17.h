#pragma once
#include <iostream>
#include <queue>
#include <vector>

int n;
int vertex[10];
std::vector<int> array[10];

// 가상 함수 테이블
/*
class A
{
public:
	virtual void FirstFunction()
	{
		std::cout << "첫 번째 가상함수" << std::endl;
	}

	virtual void SecondFunction()
	{
		std::cout << "두 번째 가상함수" << std::endl;
	}

	void ThirdFunction()
	{
		std::cout << "세 번째 가상함수" << std::endl;
	}
};

class B : public A
{
public:
	void FirstFunction()
	{
		std::cout << "B의 가상함수" << std::endl;
	}

};
*/

// 위상 정렬
/*
void TopologySort()
{
	int result[10];
	std::queue<int> Queue;

	// 진입 차수가 0인 노드를 큐에 넣어주어야 합니다.
	for (int i = 1; i <= n; i++)
	{
		if (vertex[i] == 0)
		{
			Queue.push(i);
		}
	}

	// 정렬이 완전히 수행되려면 정확히 n개의 노드를 방문하면 됩니다.
	for (int i = 1; i <= n; i++)
	{
		// n개를 방문하기 전에 큐가 비어있으면 사이클 발생한 것으로 간주합니다.
		// 큐가 비어있다면 함수를 반환합니다.
		if (Queue.empty())
		{
			return;
		}

		int temp = Queue.front();
		Queue.pop();
		result[i] = temp;

		for (int j = 0; j < array[temp].size(); j++)
		{
			int count = array[temp][j];

			// 새롭게 진입차수가 0이된 정점을 큐에 삽입합니다.
			if (--vertex[count] == 0)
			{
				Queue.push(count);
			}
		}
	}

	for (int i = 1; i <= n; i++)
	{
		std::cout << result[i] << " ";
	}
}
*/

// main
/*
int main()
{
	// 위상 정렬
	n = 7;

	array[1].push_back(2);
	vertex[2]++;

	array[1].push_back(5);
	vertex[5]++;

	array[2].push_back(3);
	vertex[3]++;

	array[3].push_back(4);
	vertex[4]++;

	array[4].push_back(6); // <- 이 부분 간선이 잘못 배치되어 있었습니다.
	vertex[6]++;

	array[5].push_back(6);
	vertex[6]++;

	array[6].push_back(7);
	vertex[7]++;

	TopologySort();

	A* a = new A;
	B* b = new B;

	a->FirstFunction();
	b->FirstFunction();
	a->SecondFunction();
	b->SecondFunction();

	return 0;
}
*/