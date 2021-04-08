using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210405
{
    class Program
    {
        static void Main(string[] args)
        {
            // inch를 입력받아 cm 단위를 구하는코드
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch * 2.54 + "cm");
            Console.WriteLine(string.Format("{0}cm", inch * 2.54));
            int myKey = 150;
            Console.WriteLine(string.Format("나는{0}살이고 내 키는 {1}이야. 그리고 내 이름은 {2} 이다.", 10, myKey, "이동준"));
            Console.WriteLine($"{inch * 2.54}cm");

            // kg를 입력받아 파운드 단위를 구하는 코드

            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound");


            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine("둘레:" + (r * PI * 2));
            Console.WriteLine("넓이:" + (r * PI * r));

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine(one * (two%10));
            Console.WriteLine(one * ((two%100)/10));
            Console.WriteLine(one * (two / 100));
            Console.WriteLine(one * two);

            Console.WriteLine("문제 !");
            // string sOne = one.ToString();
            string sTwo = two.ToString();

            Console.WriteLine(one * int.Parse(sTwo[2].ToString()));



            Console.WriteLine(one * sTwo[1]);
            Console.WriteLine(one * sTwo[0]);
        }
    }
}
