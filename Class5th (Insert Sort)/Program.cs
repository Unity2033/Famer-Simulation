namespace Class5th__Insert_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 삽입 정렬
            // 데이터를 하나씩 확인하면서 이미 정렬된 부분과 비교하여
            // 자신의 위치를 찾아 삽입하는 방식으로 정렬하는 알고리즘입니다.

            int[] array = new int[] { 9, 6, 8, 1, 3 };

            int key = 0;
            int j = 0;

            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];

                for (j = i - 1; j >= 0 && array[j] > key; j--)
                {
                    array[j + 1] = array[j];
                }

                array[j + 1] = key;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            #endregion
        }
    }
}
