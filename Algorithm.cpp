#include <iostream>
#include <map>

struct Bucket * hashTable;

struct Node
{
	int key;
	int value;
	Node * Next;
};

struct Bucket 
{
	int count;
	struct Node * head;
};

struct Node * CreateNode(int key, int value)
{
	struct Node * newNode = new Node();

	newNode->key = key;
	newNode->value = value;

	newNode->Next = nullptr;

	return newNode;
}

int HashFunction(int key)
{
	return key % 10;
}

void Insert(int key, int value)
{
	int hashIndex = HashFunction(key);

	struct Node * newNode = CreateNode(key, value);

	// 아무 노드가 없는 경우
	if (hashTable[hashIndex].count == 0)
	{
		hashTable[hashIndex].head = newNode;
	}
	else // 내가 넣고 싶은 원소에 이미 노드가 있는 경우
	{
		// Bucket이 비어있지 않다면, 새로운 노드의 next 포인터를 예전 head로 변경합니다.
		newNode->Next = hashTable[hashIndex].head;
		// Bucket의 head를 새로운 노드로 변경합니다.
		hashTable[hashIndex].head = newNode;

		hashTable[hashIndex].count++;
	}
}

void Search(int key)
{
	// HashFunction에 의해서 0 ~ 9 사이의 값이 hashIndex에 들어가게 됩니다.
	int hashIndex = HashFunction(key);

	struct Node* node = hashTable[hashIndex].head;

	if (node == nullptr)
	{
		std::cout << "There is no key" << std::endl;
	}

	while (node != nullptr)
	{
		// 우리가 검색한 key의 값이 일치하다면 key 값과 value값을 출력합니다.
		if (node->key == key)
		{
			std::cout << "key : " << node->key << " value : " << node->value << std::endl;
			return;
		}

		node = node->Next;
	}
}

void Print()
{
	struct Node * node;

	for (int i = 0; i < 10; i++)
	{
		node = hashTable[i].head;

		std::cout << "Bucket : " << i << " th" << std::endl;

		while (node != nullptr)
		{
			std::cout << "key : " << node->key << " value : " << node->value << " ";

			node = node->Next;
		}

		std::cout << std::endl;
	}
}


int main()
{
	// map
	/*
	std::map<std::string, int> map;

	map.insert(std::pair<std::string, int>("Count", 10));

	map["Naver"] = 200; // <- [key] (Naver) [value] (200)

    // 반복자 
	std::map<std::string, int>::iterator iter;

	for (iter = map.begin(); iter != map.end(); iter++)
	{
		std::cout << "key : " << iter->first << "  value : " << iter->second << std::endl;
	}
	*/

	// 해시
	hashTable = new Bucket[10];

	for (int i = 0; i < 10; i++)
	{
		hashTable[i].count = 0;
		hashTable[i].head = nullptr;
	}

	Insert(1, 10);
	Insert(16, 20);
	Insert(15, 30);
	Insert(13, 40);
	Insert(12, 50);
	Insert(11, 60);

	Print();



	// 해시의 장점은 사용자가 찾고자 하는 value를 삽입/검색/삭제할 수 있기 때문에 유용합니다.

	// 해시의 단점은 연속적인 데이터 검색에 있어 reference of locality에 의해 캐시 미싱이 잦기 때문에 연속 적인 데이터 검색에 비효율적입니다.


	return 0;
}