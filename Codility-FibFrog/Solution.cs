using System.Runtime.CompilerServices;

namespace Codility_FibFrog
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            int[] dp = new int[N + 2];

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int maxJump = Fibonacci(N);
                for (int i = 1; i <= N + 1; i++)
                {
                    dp[i] = int.MaxValue;
                    if (i <= N && A[i - 1] == 1)
                    {
                        for (int j = 1; j <= maxJump; j++)
                        {
                            if (i - j >= 0)
                                dp[i] = Math.Min(dp[i], dp[i - j] + 1);
                        }
                    }
                }

                return dp[N + 1] == int.MaxValue ? -1 : dp[N + 1];
            }

            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private int Fibonacci(int N)
        {
            if (N <= 1)
                return N;
            
            int a = 0;
            int b = 1;
            int result = 1;

            for (int i = 2; i <= N; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}
