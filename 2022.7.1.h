#pragma once
#include <iostream>

// Stack
/*
class Stack
{
private :
	int * array;
	int top;
	int size;
	int capacity;

public:
	// Stack 초기화하는 생성자
	Stack(int size) // Stack 오브젝트가 생성되는 순간 멤버 변수가 초기화됩니다.
	{
		top = -1;
		this->size = size;
		array = new int[size];
	}

	// Stack에 할당되어 있는 메모리를 해제합니다.
	~Stack()
	{
		delete[] array;
	}

	int Size()
	{
		return top + 1;
	}

	// Stack에 데이터가 가득차있는지 확인하는 함수입니다.
	bool IsFull()
	{
		//      2  == 3 - 1 = 2
		return top == size - 1;
	}

	// Stack에 데이터가 비어있는지 확인하는 함수입니다.
	bool Empty()
	{
			// -1 ==  1
		return top == -1;
	}

	// Stack에 데이터를 추가하는 함수
	void Push(int data)
	{
		if (IsFull())
		{
			std::cout << "Stack Overflow" << std::endl;
		}
		else
		{
			 // array[0] = 6
			 // array[1] = 10
			 //     1   <- 10
			array[++top] = data;
		}
	}

	int Pop()
	{
		if (Empty())
		{
			std::cout << "Stack Underflow" << std::endl;
		}
		else
		{
			return array[top--];
		}
	}

	// Stack에 최상위 데이터를 반환하는 함수입니다.
	int Top()
	{
		if(Empty())
		{
			exit(EXIT_FAILURE);
		}
		else
		{
			return array[top];
		}
	}
};
*/

// main
/*
int main()
{
	// Stack
	
	Stack stack(3);

	stack.Push(6);
	stack.Push(10);
	stack.Push(20);

	while (!stack.Empty())
	{
		std::cout << stack.Top() << std::endl;
		stack.Pop();
	}

	int array[26] = { 3,3,3,4,4,4,5,5,5,6,6,6,7,7,7,8,8,8,8,9,9,9,10,10,10,10 };

	int result = 0;

	std::string number;

	std::cin >> number;

	for (int i = 0; i < number.length(); i++)
	{
		int index = number[i] - 65;
		result += array[index];
	}

	std::cout << result << std::endl;

	return 0;
}
*/