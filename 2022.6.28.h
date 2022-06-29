#pragma once
#include <iostream>

// 연결리스트의 노드 구조체
/*
struct Node
{
	int Data;
	struct Node * next;
};
*/

int main()
{
	// 연결 리스트
	/*
	// 시작 노드를 생성합니다.
	struct Node * head = new Node();
	head->Data = 10;

	// 첫 번째 노드
	struct Node* node1 = new Node();

	head->next = node1;
	node1->Data = 9;

	// 두 번째 노드
	struct Node* node2 = new Node();
	node1->next = node2;
	node2->Data = 1;

	// 세 번째 노드
	struct Node* node3 = new Node();
	node2->next = node3;

	node3->next = NULL;

	while (head->next != NULL)
	{
		std::cout << head->Data << std::endl;
		head = head->next;
	}

	delete head;
	delete node1;
	delete node2;
	*/

	// 더하기 싸이클
	/*
	int A, B = 0;
	int temp = 0;
	int number = 0;
	int count = 0;

	int value = 0;
	int result = 0;

	std::cin >> value;

	result = value;

	while (1)
	{
		A = value / 10;
		B = value % 10;
		temp = (A + B) % 10;
		number = temp + (B * 10);

		value = number;

		count++;

		if (value == result)
		{
			break;
		}
	}

	std::cout << count << std::endl;
	*/

	return 0;
}