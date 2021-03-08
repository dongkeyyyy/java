using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class car
    {
        // 클래스 상수 변수
        const string daeli = "동대구영업소";
        // 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        // 기본 생성자
        public car()
        {
            company = "기아";
            color = "블랙";
            model = "k7";
            price = "4천만원";
        }

        // 생성자 오버로딩
        
        public car(string company, string color, string model, string price)
        {
            this.company = company;
            this.company = color;
            this.model = model;
            this.price = price;
        } 
        

        // 아래의 주석과 같은 의미
        public string Company { get => company; set => company = value; }  
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        
        /* public string Company
        { 
            get { return company; }
            set { company = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }  */

        public void showCarInfo()
        {
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("모델 : " + model);
            Console.WriteLine("가격 : " + price);
            Console.WriteLine("영업소 : " + daeli);
        }
    }

}
