﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0208
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.setName("홍길동");
            st.setTel("010-1234-1234");
            st.printStudentInfo();
            Console.WriteLine("이름 : " + st.getName());

            Student1 st2 = new Student1();
            st2.Name = "김길동";
            st2.Tel = "010-1234-4321";
            st2.printStudentInfo();
            Console.WriteLine("이름 : " + st2.Name);

            Student2 st3 = new Student2("최길동", "010-2222-2222");
            st3.printStudentInfo();

            new Student2("최길동", "010-2222-2222").printStudentInfo();

            string[] nameArr = { "홍길동", "김길동", "박길동" };
            string[] telArr = { "010-1111-1111", "010-2222-2222", "010-3333-3333" };
            Random r = new Random();
            Student2[] stArr = new Student2[10];
            for ( int i = 0; i < stArr.Length; i++)
            {
                stArr[i] = new Student2(
                    // Next(0,3) : 0 ~ 2 까지 숫자 발생
                    nameArr[r.Next(0,3)],
                    telArr[r.Next(0,3)]);
                stArr[i].printStudentInfo();
            }

            // 클래스 변수 사용
            Console.WriteLine("과정명 : " + Student2.CLASS);
        }
    }

    class Student
    {
        // 캡슐화
        private string name;
        private string tel;
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
        public void setTel(string tel)
        {
            this.tel = tel;
        }
        public string getTel()
        {
            return tel;
        }
        public void printStudentInfo()
        {
            Console.WriteLine("이름:" + name);
            Console.WriteLine("전화번호 : " + tel);
        }
        

    }
}
