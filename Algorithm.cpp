#include <iostream>

// 매개변수 배열 
/*
void Function(int array[], int n)
{              
    for (int i = 0; i < n; i++)
    {
        array[i] = 100;
    }
}
*/

void Bubble(int array[], int n)
{
    int temp = 0;

    // 배열의 크기가 5이면 5-1(4회차) 반복
   
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            //       [1]          [2]
            //        4            2
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];       // temp(2) <- 2
                array[j + 1] = array[j];   // j+1[2] (4) <- 4
                array[j] = temp;           // j[1] (2) <- temp(2)
            }
        }
    }
}

int main()
{
    // 배열 매개변수
    /*
    int array [] = {1,2,3,4,5 }; // 20

    int count = sizeof(array) / sizeof(array[0]);

    Function(array, count);

    for (int i = 0; i < sizeof(array) / sizeof(int); i++)
    {
        std::cout << array[i] << std::endl;
    }
    */

    // 정렬 알고리즘
    // Bubble Sort

    // 배열의 크기는 5입니다.
    // [3] [4] [2] [5] [1]
    // Bubble함수 호출
    // [1] [2] [3] [4] [5]

    int array[] = { 3,4,2,5,1 };
    int size = sizeof(array) / sizeof(array[0]);

    Bubble(array, size);

    for (int i = 0; i < size; i++)
    {
        std::cout << array[i] << std::endl;
    }


}
