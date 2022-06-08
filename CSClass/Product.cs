using System;

namespace CSClass
{
    class Product
    {
        internal static int counter = 0;
        public string name = "노네임";
        public int price = 1000;
        private int id = -1;

        public Product()
        {

        }

        public Product(string name, int price)
        {
            this.id = counter++;
            counter = counter + 1;
            this.name = name;
            this.price = price;
        }

        public override string ToString() // override 키워드가 들어가야 처리를 한다 어노테이션 @override같이 따로 사용하지 않는다 : 기본적으로 오버라이드가 금지되어 있기 때문
        {
            return "[" + this.id + "]" + this.name + " : " + this.price;
        }

        ~Product()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }

    }
}

