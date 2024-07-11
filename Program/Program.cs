namespace Program
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로 
            // 늘어놓은 표에서 합성수를 차례대로 지워나가면서
            // 소수의 목록을 얻어내는 방법입니다.


            #endregion

        }
    }
}
