#pragma once
#include <iostream>

// Queue
/*
template <class T>
class Queue
{
private:
	int front;
	int rear;
	int size;
	T* Data;

public:
	Queue(int size)
	{
		front = 0;
		rear = 0;
		this->size = size;
		Data = new T[size];
	}

	~Queue()
	{
		delete[] Data;
	}

	bool IsFull()
	{
		return size == rear;
	}

	bool Empty()
	{
		return front == rear;
	}

	void enqueue(T data)
	{
		if (IsFull())
		{
			std::cout << "Queue Over Flow" << std::endl;
		}
		else
		{
			Data[rear++] = data;
		}
	}

	T dequeue()
	{
		if (Empty())
		{
			std::cout << "Queue Under Flow" << std::endl;
		}
		else
		{
			return Data[front++];
		}
	}

	void Print()
	{
		for (int i = front; i < rear; i++)
		{
			std::cout << Data[i] << std::endl;
		}
	}
};
*/

// main
/*
int main()
{
	// Queue

	Queue<int> queue(3);

	queue.enqueue(1);
	queue.enqueue(2);
	queue.enqueue(3);

	queue.dequeue();

	queue.Print();

	// 숫자의 개수 Lv.1 
	/*
	int number = 0;
	int array[10] = { 0, };
	int A, B, C = 0;
	std::cin >> A >> B >> C;

	int result = A * B * C;

	while (result > 0)
	{
		number = result % 10;
		array[number]++;
		result /= 10;
	}

	for (int i = 0; i < 10; i++)
	{
		std::cout << array[i] << std::endl;
	}
	
	return 0;
}
*/