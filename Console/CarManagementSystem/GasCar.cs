using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    public class GasCar:Car
    {
        public double Fuel {  get; set; }
        public GasCar() { }
        public GasCar(string _id, string _name, int _color, double _price, int fuel) : base(_id, _name, _color, _price)
        { 
            Fuel = fuel;
        }

        public override void AddCar()
        {
            Console.Write("Input Id: ");
            Id = Console.ReadLine();
            Console.Write("Input name: ");
            Name = Console.ReadLine();
            Console.Write("Input color: ");
            Color = int.Parse(Console.ReadLine());
            Console.Write("Input price: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Input fuel per 100km: ");
            Fuel = double.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"{Id,-5} {Name,-20} {Color,-8} {Price,-10} {Fuel+ " (lit/100km)",-15} {CalculateTax(), 15}");
        }
        public override double CalculateTax()
        {
            return Price >= 30000 ? Price * 0.4 : 0.5 * Price;
        }

    }
}
