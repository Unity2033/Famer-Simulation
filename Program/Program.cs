namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과
            // 를 교체하는 방식으로 정렬하는 알고리즘입니다.

            int[] array = new int[] { 9, 6, 7, 3, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                int min = array[i];

                int select = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(min > array[j])
                    {
                        min = array[j];

                        select = j;
                    }
                }

                int temp = array[i];

                array[i] = array[select];

                array[select] = temp;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            #endregion

        }
    }
}
