using CarManagementSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        int sel;
        CarManagement myCar = new CarManagement();
        myCar.Init();
        string id="";
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
                case 3:
                    Console.Write("Input car Id to remove: ");
                    id = Console.ReadLine();
                    myCar.removeCarById(id);
                    myCar.DisplayCarList();
                    break;
                case 4:
                    Console.Write("Input searching name: ");
                    string name = Console.ReadLine();
                    myCar.searchCarByName(name);
                    break;
                case 5:
                    Console.Write("Input car Id to search: ");
                    id = Console.ReadLine();
                    myCar.searchCarById(id);
                    break;
                case 7:
                    Console.WriteLine("Sort by Price in ascending order:");
                    myCar.SortByPriceAsc();
                    myCar.DisplayCarList();
                    break;
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
        Console.WriteLine("7. Sort car list by price");
        Console.WriteLine("8. Sort car list by name");
        Console.WriteLine("9. Edit car info by Id");
        Console.WriteLine("10. Count number of cars in the list");
        Console.WriteLine("11. Calculate the total price of all cars");
        Console.WriteLine("0. Quit");
        Console.Write("Your selection: ");
    }
}