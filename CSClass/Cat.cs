using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public Cat()
        {
            Age = 0;
        }
        
        // 오버라이딩 : 기본은 하이딩이다
        public override void Eat()
        {
            Console.WriteLine("고양이가 조물조물 먹는다");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}