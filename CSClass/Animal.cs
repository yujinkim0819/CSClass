using System;

namespace CSClass
{
    public class Animal
    {
        public int Age;

        public Animal()
        {
            Age = 0;
        }

        // 하이딩 가능, 오버로딩 가능: 자식의 행동에 따라서..
        public virtual void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
    }
}