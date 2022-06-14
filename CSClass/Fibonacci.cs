using System;
using System.Collections.Generic;

namespace CSClass
{
    public class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();

        public static long Get(int n)
        {
            Console.WriteLine(n);

            if(n < 0) return 0;
            if(n == 1) return 1;

            if(memo.ContainsKey(n)) // 해당 값을 가지고 있는지 확인
            {
                return memo[n]; // 있다면 return
            }
            else
            {
                // 없다면 한 번도 계산을 안한 것 -> 계산
                long value = Get(n - 2) + Get(n -1) ;
                memo[n] = value;
                return value; // 계산하고 값 return
            }
        }
    }
}