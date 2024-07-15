namespace Class6th__Shell_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬
            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로
            // 정렬한 후, 점진적으로 더 작은 간격을 사용하는 정렬 알고리즘입니다.

            int[] array = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            int gap = 0;
            int i = 0;
            int j = 0;
            int key = 0;

            for (gap = array.Length / 2; gap > 0; gap /= 2)
            {
                if (gap % 2 == 0)
                {
                    gap++;
                }

                for (i = gap; i < array.Length; i++)
                {
                    key = array[i];

                    for (j = i; j >= gap && array[j - gap] > key; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }

                    array[j] = key;
                }
            }

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }

            #endregion
        }
    }
}
