using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace arraytest0218
{
    class Program
    {
        static List<Student> addrList = new List<Student>();
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM = 3;
        const int MENU_DEL = 4;
        const int MENU_DELETE_ALL = 5;
        const int MENU_EXIT = 6;

        static Random r = new Random();
        static void Main(string[] args)
        {
            getId();
            
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        addInfo();

                        break;
                    case MENU_VIEW:
                        viewInfo();

                        break;
                    case MENU_RANDOM:
                        randomMaker();

                        break;
                    case MENU_DEL:
                        infoDel();

                        break;
                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static int getMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 관리 v1.0");
            Console.WriteLine("------------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 정보 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.종료");
            Console.WriteLine("------------------");
            Console.Write("메뉴선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;

        }

        public static void addInfo()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("------------------");
            Console.Write("이름: ");
            String name = Console.ReadLine();
            Console.Write("전화번호: ");
            String tel = Console.ReadLine();
            Console.Write("주소: ");
            String address = Console.ReadLine();
            Console.Write("이메일: ");
            String email = Console.ReadLine();

            addrList.Add(new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");


        }
        public static void viewInfo()
        {
            foreach (Student student in addrList)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("주소록 정보");
                Console.WriteLine("------------------");
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("전화번호: " + student.Tel);
                Console.WriteLine("주소: " + student.Address);
                Console.WriteLine("이메일: " + student.Email);
            }
        }

        public static void randomMaker()
        {
            String[] name = { "홍길동", "김길동", "장길동", "왕건", "김희성" };
            String[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-44444", "010-5555-5555" };
            String[] address = { "경북 경산 하양읍", "대구 달성군 현풍읍", "부산 수성구 광안리", "서울 잠실타워", "인천 공항" };
            String[] email = { "jang6066@gmail.com", "OMG@gmail.com", "ldjgoodjjang@gmail.com", "hong123123@gmail.com", "kim1233@gmail.com" };

            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                addrList.Add(new Student(getId(), name[rd.Next(0, 5)], tel[rd.Next(0, 5)], address[rd.Next(0, 5)], email[rd.Next(0, 5)]));
                Thread.Sleep(1);
            }
        }

        public static void infoDel()
        {
            Console.Write("삭제할 이름을 입력하세요: ");
            String name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(name + " 정보가 삭제 되었습니다.");
        }

        public static void infoRevise()
        {
            Console.WriteLine("정보를 수정할 사람의 이름을 입력하시오: ");
            string name2 = Console.ReadLine();
            for(int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Name == name2)
                {
                    addrList.Clear();
                }
            }
        }

        static string getId()
        {
            Random r = new Random();
            string rdata = "abcdefghijklmnopqrstuvwxyz" +
            "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble()*rdata.Length)]);
            }
            // Console.WriteLine("id : " + rs.ToString());
            return rs.ToString();
        }

    }
}