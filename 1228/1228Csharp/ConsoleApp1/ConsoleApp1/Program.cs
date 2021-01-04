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
            int[] ab = new int[100];
            ab[0] = 10;
            //ab[100] = 1;
            ab[1] = -1;
            int ac = int.Parse(Console.ReadLine());
            int[] abc = new int[ac];
            Array.Sort(ab);  //sort 는 오름차순으로 배열 reverse 는 반대인 내림차순
            Console.WriteLine(ab);

            for (int i = 0; i < ac; i++)
                abc[i] = int.Parse(Console.ReadLine());

            int max = abc[0];
            int min = abc[0];
            for (int i = 0; i < ac; i++)
            {
                if (abc[i] > max)
                    max = abc[i];
                if (abc[i] < min)
                    min = abc[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}