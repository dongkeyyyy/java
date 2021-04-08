using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");

            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕");


            Console.WriteLine("안녕" + 1);
            Console.WriteLine("안녕" + 2);
            Console.WriteLine("안녕" + 3);
            Console.WriteLine("안녕" + 4);

            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕" + (i + 1));



            Console.WriteLine("안녕하니"[0]);
            Console.WriteLine("안녕하니"[1]);
            Console.WriteLine("안녕하니"[2]);
            Console.WriteLine("안녕하니"[3]);

            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕하니"[i]);

            string name = "김동혁";
            string[] names = { "김동혁", "정연우", "임수환" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] handsomeguy = new string[10];

            for (int i = (int)'A'; i < (int)'z'; i++)
                Console.Write((char)i);

            Console.WriteLine("..");

            for (int i = (int)'가'; i < (int)'힣'; i++)
            {
                Console.Write((char)i);
                if (i == (int)'강')
                    break;
                if (i == (int)'힣')
                    i = (int)'가';
            }


            // 무한대 반복문을 사용하기 적합한 while
            while (false)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }

            do
            {
                Console.WriteLine("이동준");
            } while (false);

            int count = 100;
            while (count < 100)
            {
                Console.WriteLine("카운트 값은 " + count + "입니다");
            }
            do
            {
                Console.WriteLine("dow while count " + count);
            } while (count < 100);

            int number = 0;
            for (int i = 1; i <= 100; i++)
            {
                // if(i%2==0)
                // number = number + i; // number += i;

                if (i % 2 != 0)
                {
                    continue;

                    number += i;
                }
            }
            Console.WriteLine(number);

            // foreach

            foreach (var item in names)
            {
                Console.WriteLine(item + " is Good man");
            }

            foreach (var item in name)
            {
                Console.WriteLine(item + " is Good man");
            }

            int countindex = 0;

            foreach (var item in names)
            {
                if (countindex == 0)
                {
                    countindex++;
                    continue;
                }
                Console.WriteLine(item + " is Good man");
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                {
                    i++;  // i++; 또는 continue;
                }
                Console.WriteLine(names[i] + " is Good man");
            }

            for (int i = 1; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " is Good man");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i) + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 10; i > 0; i--)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

         /*   for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("위부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto Example;
                }
            }

        example:
            Console.WriteLine("go to");

            string seathcer = Console.ReadLine();

            if (teacher == "이동준") ;
            goto Example;*/


            // ToUpper, ToLower
            string example = "exAmPle";
            Console.WriteLine(example.ToUpper()); // 모두 대문자로 출력
            Console.WriteLine(example.ToLower()); // 모두 소문자로 출력
            Console.WriteLine(example);
            example = example.ToUpper();
            // Split = 분리하다. 콤마를 없애고 배열로 분리한다.
            string guys = "김동혁,장승민,정연우,임수환";
            string[] guys_array = guys.Split(',');
            foreach (var item in guys_array)
            {
                Console.WriteLine(item+"님 하이");
            }

            //Join 배열에있는 것들을 하나의 변수로 뭉친다
            string guys2 = string.Join(",", guys_array);
            Console.WriteLine(guys2);
            // trim
            string trim = "  안 녕 하 니    비트토렌트 개쓰레기  ";
            Console.WriteLine("!"+trim+"!");
            Console.WriteLine("!" + trim.Trim() + "!");

        }
    }
}
