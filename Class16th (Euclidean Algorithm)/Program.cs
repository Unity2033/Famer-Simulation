namespace Class16th__Euclidean_Algorithm_
{
    internal class Program
    {
        static int Euclid(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return Euclid(y, x % y);
            }
        }

        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 2개의 자연수 또는 정식의 최대공약수를 구하는 알고리즘으로,
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘입니다.

            Console.WriteLine(Euclid(78696, 19332));

            #endregion


        }
    }
}
