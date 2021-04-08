using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = 2.54;
            Console.WriteLine("몇 Inch 입니까");
            double rich = double.Parse(Console.ReadLine());
            double rich2 = inch * rich;
            Console.WriteLine((rich) + "인치는" + (rich2) + "센치입니다");

            double kg = 2.20462262;
            Console.WriteLine("몇 Kg 입니까");
            double weight = double.Parse(Console.ReadLine());
            double weight2 = kg * weight;
            Console.WriteLine((weight) + "키로그램은" + (weight2) + "파운드입니다");

            double PI = 3.14;
            Console.WriteLine("원의 반지름을 입력해주세요");
            double radius = double.Parse(Console.ReadLine());
            double periphery = 2 * PI * radius;
            double area = PI * radius * radius;
            Console.WriteLine("원의 둘레는 " + periphery +
                "이며 원의 넓이는" + area + "입니다");

            Console.WriteLine("첫번째 숫자를 입력해 주세요");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자를 입력해 주세요");
            int B = int.Parse(Console.ReadLine());

            int result1 = A * (B % 10);
            Console.WriteLine(result1);
            int result2 = A * ((B % 100) / 10);
            Console.WriteLine(result2);
            int result3 = A * (B / 100);
            Console.WriteLine(result3);
            int result4 = A * B;
            Console.WriteLine(result4);

        }
    }
}
