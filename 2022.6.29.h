#pragma once
#include <iostream>

// 링크드 리스트
/*
struct Node
{
	int data;
	Node* next;
};

class Linkedlist
{
private:
	Node* head;
	Node* tail;

public:
	Linkedlist()
	{
		head = NULL;
		tail = NULL;
	}

	void FrontNode(int data)
	{
		Node* headNode = new Node;
		headNode->data = data;

		// 링크드 리스트가 비어있다면 첫번째 Node에 headNode를 추가합니다.
		if (head == NULL)
		{
			head = headNode;
			tail = headNode;
		}
		else // 링크드 리스트에 데이터가 있다면 headNode의 다음 가리키는 주소를 head로 설정합니다.
		{
			headNode->next = head;
			head = headNode;
		}
	}

	void LastNode(int data)
	{
		Node* tailNode = new Node;
		tailNode->data = data;
		tailNode->next = NULL;

		// 링크드 리스트가 비어있다면 첫번째 Node에 headNode를 추가합니다.
		if (head == NULL)
		{
			head = tailNode;
			tail = tailNode;
		}
		else // 링크드 리스트에 데이터가 있다면 headNode의 다음 가리키는 주소를 head로 설정합니다.
		{
			tail->next = tailNode;
			tail = tailNode;
		}
	}

	void InsertNode(Node* PrevNode, int data)
	{
		Node* addNode = new Node;
		addNode->data = data;

		// 삽입 할 앞 Node의 next 포인터를 addNode의 next에 저장합니다.
		addNode->next = PrevNode->next;

		// addNode앞의  Node의 next 포인터를 addNode로 저장합니다.
		PrevNode->next = addNode;
	}

	void DeleteNode(Node* PrevNode)
	{
		// 삭제할 Node를 임시 Node에 저장합니다.
		// 삭제할 Node의 1 단계 전 Node의 Next 포인터
		Node* tempNode = PrevNode->next;

		// 삭제할 Node를 제외합니다.
		// 삭제할 Node의 Next 포인터를 1 단계 전 Node의 next 포인터를 저장합니다.
		PrevNode->next = tempNode->next;

		delete tempNode;
	}

	void ShowData(Node* head)
	{
		if (head == NULL)
		{
			return;
		}
		else
		{
			std::cout << head->data << " ";
			ShowData(head->next);
		}
	}

	Node* GetHead()
	{
		return head;
	}
};
*/

// main
/*
int main()
{
	Linkedlist list;

	list.LastNode(1);
	list.LastNode(20);

	list.DeleteNode(list.GetHead());

	list.ShowData(list.GetHead());

	return 0;
}
*/