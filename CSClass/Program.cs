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
        }
    }
}
