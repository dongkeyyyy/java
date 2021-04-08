using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1.0 / 2.0);

            // 덧셈 뺄셈 곱셈 나눗셈 나머지
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);

            Console.WriteLine((5 + 3) * (5 - 2));


            // 문자 선택자
            Console.WriteLine("안녕하세요"[0]); // 안
            Console.WriteLine("안녕하세요"[1]); // 녕
            Console.WriteLine("안녕하세요"[2]); // 하
            Console.WriteLine("안녕하세요"[3]); // 세
            Console.WriteLine("안녕하세요"[4]); // 요
            /*Console.WriteLine("안녕하세요"[5]); // Error!*/

            Console.WriteLine((int)"안녕하세요"[0]);
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0], 16)); // 안
            Console.WriteLine('가' + '힣');

            Console.WriteLine(1 == 1);
            Console.WriteLine(1 != 1);
            bool result = true;
            bool result2 = false;

            Console.WriteLine(!result);  // 논리 부정 연산자
            Console.WriteLine(!result2);  // 논리 부정 연산자

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(1+1);  // 여기서 i는int로 간주함
            // 기본적으로 

            int a = int.MaxValue; // 2147883647
            int b = int.MaxValue; //1 2147883647
            Console.WriteLine(a+b);
            Console.WriteLine((long)a+b);

            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;
            Console.WriteLine(example++);  // 100
            Console.WriteLine(++example);  // 102

            int conclusion = 100;
            // ++을 무조건 뒤에 붙이고 그냥 두줄로 나눠쓰기
            conclusion++; // 1증가 시킨뒤
            Console.WriteLine(conclusion); // 그 값을 출력
            conclusion++;
            Console.WriteLine(conclusion);

            Console.WriteLine();

            string input = Console.ReadLine();

            Console.WriteLine("안녕 나는 "+input+"이야");

            // 숫자 입력 받기

            int number = int.Parse(Console.ReadLine()); // 정수
            double num = double.Parse(Console.ReadLine()); // 실수
            Console.WriteLine(number/num);
        }
    }
}
