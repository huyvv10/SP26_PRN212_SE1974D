using CarManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        int sel;
        CarManagement myCar = new CarManagement();
        myCar.Init();

        do
        {
            Menu();
            int.TryParse(Console.ReadLine(), out sel);
            switch (sel)
            {
                case 1:
                    myCar.AddNewCar();
                    myCar.DisplayCarList();
                    break;
                case 2:
                    myCar.DisplayCarList(); break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select again."); break;
            }

        } while (sel!=0);

    }
    public static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Add a new car");
        Console.WriteLine("2. Display car list");
        Console.WriteLine("3. Remove car by ID");
        Console.WriteLine("4. Search car by name");
        Console.WriteLine("5. Search car by Id");
        Console.WriteLine("6. Search car by price in range");
        Console.WriteLine("7. Sort car list by Price");
        Console.WriteLine("0. Quit");
        Console.Write("Your selection: ");
    }
}