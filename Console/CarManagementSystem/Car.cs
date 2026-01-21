using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    public abstract class Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public double Price { get; set; }

        public Car() { }

        public Car(string _id,  string _name, int _color, double _price) 
            => (Id, Name, Color, Price) = (_id, _name, _color, _price);

        public abstract void AddCar();
        public abstract void Display();
        public abstract double CalculateTax();

    }
}
