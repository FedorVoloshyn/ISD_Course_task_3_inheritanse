using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_3_inheritanse
{
    class Vehicle
    {
        protected int yearDevelop;
        protected int speed;
        protected int price;
        public int YearDevelop { get { return yearDevelop; } }
        public int Speed { get { return speed; } }
        public int Price { get { return price; } }
        public Vehicle(int YearDevelop, int Speed, int Price)
        {
            this.yearDevelop = YearDevelop;
            this.speed = Speed;
            this.price = Price;
        }
    }

    class Car : Vehicle
    {
        public Car(int YearDevelop, int Speed, int Price)
            : base(YearDevelop, Speed, Price)
        { }
    }
    class Plane : Vehicle
    {
        private int height;
        private int numberOfPassengers;
        public int Height { get { return height; } }
        public int NumberOfPassengers { get { return numberOfPassengers; } }
        public Plane(int YearDevelop, int Speed, int Price, int Height, int NumberOfPassengers)
            : base(YearDevelop, Speed, Price)
        {
            this.height = Height;
            this.numberOfPassengers = NumberOfPassengers;
        }
    }

    class Ship : Vehicle
    {
        private string port;
        private int numberOfPassengers;
        public string Port { get { return port; } }
        public int NumberOfPassengers { get { return numberOfPassengers; } }
        public Ship(int YearDevelop, int Speed, int Price, string Port, int NumberOfPassengers)
            : base(YearDevelop, Speed, Price)
        {
            this.port = Port;
            this.numberOfPassengers = NumberOfPassengers;
        }
    }
}
