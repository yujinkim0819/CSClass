using System;

namespace CSClass
{
    public class Dog: Animal
    {
        string Color;
        
        // 하이딩
        public new void Eat()
        {
            Console.WriteLine("강아지가 와구와구 먹는다");
        }

        public Dog()
        {
            Age = 0;
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}