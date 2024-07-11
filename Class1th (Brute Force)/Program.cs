namespace Class1th__Brute_Force_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 시간 복잡도
            // 특정 크기의 입력을 기준으로 할 때 필요한
            // 연산 횟수를 의미합니다.

            #region 상수 시간 O(1) 
            // 입력 크기와 상관없이 일정한 시간 복잡도를 가지는
            // 시간입니다.

            // ex) 배열의 인덱스 참조
            #endregion

            #region 로그 시간 O(log n)
            // 데이터의 크기에 따라 실행 시간이 로그 함수의 형태로
            // 증가하는 시간 복잡도입니다.

            // ex) 이진 탐색 트리

            #endregion

            #region 선형 시간 O(n)
            // 입력에 따라 걸리는 시간이 선형적으로 증가되는 시간입니다.

            // ex) for문

            #endregion

            #region 제곱 시간 O(n²)
            // 입력되는 데이터를 기준으로 n² 만큼의 시간이 증가되는
            // 시간 복잡도입니다.

            // ex) 2중 for문

            #endregion

            #endregion

            #region 공간 복잡도
            // 프로그램 실행과 완료에 얼마나 많은 공간이 필요한 지
            // 나타내는 척도입니다.

            #region 고정 공간
            // 코드가 저장되는 공간으로 알고리즘 실행을 위해
            // 시스템이 필요로 하는 공간입니다. 

            // ex) 배열
            #endregion

            #region 가변 공간
            // 문제를 해경하기 위해 알고리즘이 필요한 공간으로
            // 순환 프로그램일 경우 순환 스택을 의미합니다.

            // ex) 재귀 함수
            #endregion

            #endregion

            #region 브루트 포스(Brute Force)
            // 가능한 모든 경우의 수를 탐색하면서
            // 결과를 도출하는 알고리즘입니다.

            int[] password = new int[3];

            password[0] = 3;
            password[1] = 5;
            password[2] = 7;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (password[0] == i && password[1] == j && password[2] == k)
                        {
                            Console.WriteLine("해제");
                            Console.WriteLine(i + " " + j + " " + k);
                        }
                    }
                }
            }
            #endregion
        }
    }
}
