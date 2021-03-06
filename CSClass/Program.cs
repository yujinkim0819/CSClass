using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        // 섀도잉
        public static int number = 10;

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
            /*
            Product product = new Product();
            product.name = "고구마";
            product.price = 1000;
            Console.WriteLine(product.name + " : " + product.price );
            */

            // 모든 값을 하나하나 세팅하지 않아도 됨 - 편리
            Product productA = new Product()
            {
                name = "감자",
                price = 2000
            };
            
            Product productB = new Product()
            {
                price = 6000,
                name = "고구마"                
            };

            Product productC = new Product()
            {
                name = "옥수수"
            };

            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
                new Student() { name = "김유진", grade = 100 },
                new Student() { name = "최정훈", grade = 101 },
                new Student() { name = "김유지", grade = 90 },
                new Student() { name = "김정진", grade = 55 },
                new Student() { name = "김유훈", grade = 80 }
            };

            // 삭제연습용 foreach
            /*
            foreach (var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student); 
                }
            }
            */

            /*
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].grade > 60)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }
            */

            // 뒤에서 부터 읽기
            for (int i = students.Count - 1; i>= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }


            // 출력
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52f)); // float형보다 double형이 큼
            Console.WriteLine(MyMath.Abs(52L)); // Long형보다 double형이 크기 때문에 가능


            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter + "개 생성되었습니다");

            SingleTon mySingle = SingleTon.getInstance();


            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");


            Product product = new Product("과자", 1500);
            productA = null;

            Box box = new Box(10, 20);
            box.Width = 200;
            box.Height = 100;
            Console.WriteLine(box.Area);

            box.Width = -10;
            Console.WriteLine(box.Area);

            Box box2 = new Box(-10, -20);
            Console.WriteLine(box2.Area);

            
            //Console.WriteLine(Fibonacci.Get(1));
            //Console.WriteLine(Fibonacci.Get(10));
            //Console.WriteLine(Fibonacci.Get(50));
            Console.WriteLine(Fibonacci.Get(100));
            //Console.WriteLine(Fibonacci.Get(1000));

            Cat c = new Cat();
            Dog d = new Dog();



            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> Animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }

                var dog = item as Dog;  
                if (dog != null) {  dog.Bark(); }   
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }

            Child ChildA = new Child();
            Child ChildB = new Child("string");


            // 섀도잉
            int number = 20;
            Console.WriteLine(number);


            foreach (var item in Animals)
            {
                item.Eat();
            }
        }
    }
}
