using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    class Class1
    {
        private string name;
        private int age;
        private char gender;
        private string address;

        public Class1(string name, int age, char gender, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public void ShowStudentInfo()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("성별 : " + gender);
            Console.WriteLine("주소 : " + address);
        }
    }

    

    
}
