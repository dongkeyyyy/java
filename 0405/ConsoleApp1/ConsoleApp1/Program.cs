using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Write" + Environment.NewLine);
            Console.Write("Write\n");
            Console.WriteLine("WriteWriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteWrite");
            Console.WriteLine("\"Write\"");

            Console.WriteLine("\"\\\"Write\\\"\"");

            double inch = 2.54;
            /*double inch = double.Parse(Console.ReadLine());*/
            Console.WriteLine("몇 inch인지 입력하세요");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "inch는" + (num1 * inch) + "cm입니다");

            double kg = 2.20462262;
            Console.WriteLine("몇 kg인지 입력하세요");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num2 + "kg는" + (num2 * kg) + "입니다");

            double PI = 3.14;
            Console.WriteLine("반지름을 입력해주세요");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레는" + (2 * PI * radius) + "입니다");
            Console.WriteLine("원의 넓이는" + (PI * radius * radius) + "입니다");

            int number1 = 472;
            int number2 = 385;

            int result1 = number1 * (number2 % 10);
            Console.WriteLine(result1);
            int result2 = number1 * (number2 % 100 / 10);
            Console.WriteLine(result2);
            int result3 = number1 * (number2 / 100);
            Console.WriteLine(result3);
            int result4 = number1 * number2;
            Console.WriteLine(result4);
        }
    }
}
