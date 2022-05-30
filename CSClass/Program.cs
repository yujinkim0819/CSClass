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

            Console.WriteLine(Math.Abs(-31415));
            Console.WriteLine(Math.Ceiling(-3.141));
            Console.WriteLine(Math.Floor(3.141));
            Console.WriteLine(Math.Round(3.141, 2)); // Round 메서드는 소수점 자리 개수도 삽입 가능!!
            Console.WriteLine(Math.Max(3, 14));
            Console.WriteLine(Math.Min(3, 14));
            Console.WriteLine(Math.PI);
            
            // 새로운 파일 생성
            Product product = new Product();

        }
    }
}