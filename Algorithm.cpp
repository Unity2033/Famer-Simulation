#include <iostream>

using namespace std;

int array[] = { 54,3,66,20,91,17,82,49 };
int sorted[8];

void Merge(int left, int right)
{
	int middle = (left + right) / 2;
	int i = left; // 0
	int j = middle + 1;
	int k = left; // 0

	while (i <= middle && j <= right)
	{
		// 양쪽 배열에서 최소값을 비교했을 때 오른쪽 배열이 더 큰 경우
		// 그대로 왼쪽 배열의 최소값이 결과 배열에게 저장되도록 설정하면 됩니다.
		if (::array[i] > ::array[j])
		{
			sorted[k++] = ::array[j++];
		}
		else
		{
			sorted[k++] = ::array[i++];
		}
	}

	// 오른쪽 배열에 아직 결과 배열에 들어가지 못한 값이 있다면 그대로 넣어줍니다.
	if (i > middle)
	{
		while (j <= right)
		{
			sorted[k++] = ::array[j++];
		}
	}
	else
	{
		while (i <= middle)
		{
			sorted[k++] = ::array[i++];
		}
	}

	for (int v = left; v <= right; v++)
	{
		// [ 54,3,66,20,91,17,82,49 ] <- [ 3,17,20,49,54,66,82,91 ] 
		::array[v] = sorted[v];
	}
}


// 배열에 저장되어 있는 원소의 수를 2개로 분할하고 병합하는 함수
void MergeSort(int left, int right)
{
	int middle;

	if (left < right)
	{
		// [] [] [] [] | [] [] [] []
		// (left <= middle) 왼쪽 부분 정렬
		// (middle+1 <= right) 오른쪽 부분정렬

		middle = (left + right) / 2;
		// <- MergeSort를 재귀
		MergeSort(left, middle);      // 0, 3
		MergeSort(middle + 1, right); // 4, 7

		Merge(left, right); // 병합하는 과정 함수 호출
	}
}

int main()
{
	int size = sizeof(::array) / sizeof(int);

	MergeSort(0, size-1);

	for (int i = 0; i < size; i++)
	{
		cout << ::array[i] << " ";
	}

	return 0;
}
