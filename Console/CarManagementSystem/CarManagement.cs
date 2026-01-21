using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarManagementSystem
{
       public class CarManagement
    {
        public List<Car> carsList;

        public CarManagement() {
            carsList = new List<Car>();
        }

        public void Init()
        {
            Car car1 = new GasCar("A1", "VinFast VF8", 4, 45000.5, 12);
            Car car2 = new GasCar("A2", "Toyota Camry", 2, 38000.0, 10);
            Car car3 = new GasCar("A3", "Honda Accord", 1, 36000.8, 11);
            Car car4 = new GasCar("A4", "Mazda CX-5", 3, 34000.2, 9);
            Car car5 = new ElectricCar("A5", "Ford Ranger", 5, 42000.9, 13);
            Car car6 = new GasCar("A6", "BMW X5", 0, 78000.0, 15);
            Car car7 = new ElectricCar("A7", "Mercedes C300", 1, 72000.6, 14);
            Car car8 = new ElectricCar("A8", "Audi A6", 2, 69000.4, 12);
            Car car9 = new GasCar("A9", "Hyundai Tucson", 3, 31000.3, 8);
            Car car10 = new ElectricCar("A10", "Kia Sorento", 4, 33500.0, 11);
            carsList.Add(car1);
            carsList.Add(car2);
            carsList.Add(car3);
            carsList.Add(car4);
            carsList.Add(car5);
            carsList.Add(car6);
            carsList.Add(car7);
            carsList.Add(car8);
            carsList.Add(car9);
            carsList.Add(car10);
        }
        public void AddNewCar()
        {
            Console.WriteLine("Type 1 to add Electric Car\nType 2 to add Petrogas Car\nYour selection: ");
            int.TryParse(Console.ReadLine(), out int type);
            Car car;
            if (type == 1)
            {
                car = new ElectricCar();
            } 
            else if (type == 2)
            {
                car = new GasCar();
            } else
            {
                return;
            }
            car.AddCar();
            carsList.Add(car);
        }

 
        public void DisplayCarList()
        {
            Console.WriteLine($"{"Id",-5} {"Car Name",-20} {"Color",-8} {"Price",-10} {"Fuel",-15} {"Tax",15}");
            Console.WriteLine($"{"--",-5} {"--------",-20} {"-----",-8} {"-----",-10} {"----",-15} {"---",15}");
            foreach (Car car in carsList)
            {
                car.Display();
            }
            Console.WriteLine();
        }
    }
}
