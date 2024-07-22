namespace Class15th__Longest_Increasing_Subsequence_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 최장 증가 부분 수열 
            // 원소가 n개인 배열의 일부 원소를 골라내서 만든 부분 수열 중,
            // 각 원소가 이전 원소보다 크다는 조건을 만족하고, 그 길이가 최대인
            // 부분 수열입니다.

            int[] array = new int[] { 3, 2, 4, 1, 6 };
            int[] count = new int[array.Length];

            count[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                // 첫 원소부터 i 원소 전까지 비교합니다.
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i])
                    {
                        count[i] = Math.Max(count[i], count[j] + 1);
                    }

                    // 증가 부분 수열의 길이는 1부터 시작하므로 0인 값을 1로 저장합니다.
                    if (count[i] == 0)
                    {
                        count[i] = 1;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(count[i] + " ");
            }


            // 주어진 배열에서 인덱스를 한 칸씩 늘려가면서 확인합니다.

            // 내부 반복문으로 i보다 작은 인덱스들을 하나씩 살펴 보면서
            // array[j] < array[i]인 것이 있을 경우 count배열을 업데이트합니다.

            // 업데이트 기준

            // 1. j번째 인덱스에서 끝나는 최장 증가 부분 수열의 마지막에 array[i]
            //    를 추가했을 때의 LIS 길이와
            //    
            // 2. 추가하지 않고 기존의 count 배열 [i]값
            // 
            // 둘 중에 더 큰 값으로 count [i] 배열의 값을 업데이트합니다. 


            #endregion

        }
    }
}
