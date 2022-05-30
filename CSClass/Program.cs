using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();            
            car.SetInTime(); // 메소드 첫 글자는 대문자
            car.SetOutTime();

            //인스턴스 메서드
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100)); // 10부터 100 미만의 값
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            /*
            List<int> list = new List<int>();
            
            list.Add(52);
            list.Add(3);
            list.Add(6);
            list.Add(19);
            */

            List<int> list = new List<int>() { 52, 273, 32, 42};
            list.Remove(42);
            // 인덱스 삭제
            list.RemoveAt(0); // 첫 번째 요소 삭제

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + item);
            }

        }
    }
}
