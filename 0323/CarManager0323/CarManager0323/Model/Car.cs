using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323
{
    class Car
    {
        string model;
        int price;
        string color;
        string maker;
        string year;

        public Car(string model, int price, string color, string maker, string year)
        {
            this.model = model;
            this.price = price;
            this.color = color;
            this.maker = maker;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Maker { get => maker; set => maker = value; }
        public string Year { get => year; set => year = value; }
    }
}
