namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여
            // 문제를 해결하는 알고리즘입니다.

            int count = 0;
            int sum = 0;

            int start = 0;
            int end = 0;

            int m = 5;

            int[] list = new int[] { 1, 2, 5, 2, 5 };

            while (start <= end)
            {
                if (sum >= m)
                {
                    sum -= list[start++];
                }
                else if (end >= list.Length)
                {
                    break;
                }
                else
                {
                    sum += list[end++];
                }

                if (sum == m)
                {
                    count++;
                }
            }

            Console.WriteLine("Count의 값 : " + count);
            #endregion
        }
    }
}
