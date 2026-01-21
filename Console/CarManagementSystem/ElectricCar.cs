using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    public class ElectricCar:Car
    {
        public int BatterryCapacity {  get; set; }

        public ElectricCar() { }
        public ElectricCar(string _id, string _name, int _color, double _price, int _bat): base(_id, _name, _color, _price) { 
            this.BatterryCapacity = _bat;
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
            Console.Write("Input batterry capacity: ");
            BatterryCapacity = int.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            Console.WriteLine($"{Id,-5} {Name,-20} {Color,-8} {Price,-10} {BatterryCapacity + " (Kwh)",-15} {CalculateTax(),15:F2}");
        }

        public override double CalculateTax()
        {
            return Price >= 30000 ? Price * 0.1 : 0.15* Price ;
        }
    }
}
