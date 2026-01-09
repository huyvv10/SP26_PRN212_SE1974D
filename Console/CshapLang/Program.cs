using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input a number n = ");
        int n = int.Parse(Console.ReadLine());
        if (n%2 == 0)
            Console.WriteLine($"{n} is an even number.");
        else 
            Console.WriteLine($"{n} is an odd number.");
    }
}