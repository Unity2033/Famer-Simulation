namespace Class7th__Count_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬
            // 데이터의 값을 직접 비교하지 않고, 단순하게
            // 각 숫자가 몇 개 있는 지 개수를 세어 저장한 다음
            // 정렬하는 알고리즘입니다.

            int[] array = new int[] { 1, 4, 5, 2, 3, 1, 1, 5 };

            int[] countList = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                countList[array[i] - 1] += 1;
            }

            for (int i = 0; i < countList.Length; i++)
            {
                Console.Write(countList[i] + " ");
            }

            #endregion
        }
    }
}
