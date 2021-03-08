using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = {"대구시 동구 신암4동" , "서울시 동구 신암4동" ,
            "부산시 서울시 동구 신암4동" , "인천시 서울시 동구 신암4동" , "광주시 서울시 동구 신암4동"};

            Class1 []St = new Class1[10];
            Random rd = new Random();
            
            for (int i = 0; i < St.Length; i++)
            {
                Console.WriteLine(i+1 + "번 학생");
                St[i] = new Class1(name[rd.Next(5)], age[rd.Next(5)],
                    gender[rd.Next(2)], address[rd.Next(5)]);
                St[i].ShowStudentInfo();
            }

            /*  St[10] = {"전우치" , 24 , '남' , "조선 한양인근 두메산골"};  */
            St[9].Name = "전우치";
            St[9].Age = 24;
            St[9].Gender = '남';
            St[9].Address = "조선 한양인근 두메산골";

            St[9].ShowStudentInfo();
        }
    }
}
