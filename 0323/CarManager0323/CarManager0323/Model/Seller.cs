using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323
{
    class Seller
    {
        string name;
        string tel;
        string email;
        string addr;
        string office_Name;

        public Seller(string name, string tel, string email, string addr, string office_Name)
        {
            this.Name = name;
            this.Tel = tel;
            this.Email = email;
            this.Addr = addr;
            this.Office_Name = office_Name;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Office_Name { get => office_Name; set => office_Name = value; }
    }
}
