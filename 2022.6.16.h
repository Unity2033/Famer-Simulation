#pragma once
#include <iostream>

// main
/*
int main()
{
	// 계수 정렬
	
	int array[] = {1,3,3,2,4,5,5};
	int count[5] = { 0, };

	for (int i = 0; i < sizeof(array) / sizeof(int); i++)
	{
		count[array[i] - 1]++;
	}

	for (int i = 0; i < sizeof(count) / sizeof(int); i++)
	{
		for (int j = 0; j < count[i]; j++)
		{
			std::cout << i + 1 << " ";
		}
	}


	// 문제 Level 1 시계

	// 두 개의 정수를 입력받습니다.

	// 첫 번째 입력은 시간을 의미합니다.
	// 두 번째 입력은 분을 의미합니다.

	// 하나의 정수를 더 입력받습니다.
	// 추가적인 분에 대한 입력값입니다.

	// 24시 더 큰 값을 입력하게 되면

	int hour;
	int minute;
	int addminute;

	std::cin >> hour >> minute >> addminute;

	minute += addminute;

	if (minute >= 60)
	{
		while (minute >= 60)
		{
			minute -= 60;
			hour++; // 3
		}

		if (hour >= 24)
		{
			hour -= 24;
		}
	}

	std::cout << hour << "시" << minute << "분" << std::endl;
	
	return 0;
}
*/