using CarManager0323.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323
{
    class Deal
    {
        string date;
        Customer customer;
        Car car;
        Seller seller;

        public Deal(string date, Customer customer, Car car, Seller seller)
        {
            this.Date = date;
            this.Customer = customer;
            this.Car = car;
            this.Seller = seller;
        }

        public string Date { get => date; set => date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
