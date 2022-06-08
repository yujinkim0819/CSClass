using System;

namespace CSClass
{
    public class Sample
    {
        public static int value = 10;

        public Sample()
        {
            value = 20;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}