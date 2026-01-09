internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("Input a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input b = ");
        int b = int.Parse(Console.ReadLine());
        TinhTong(a, b);
    }
    public static void TinhTong(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {(float)a / b}");
        Console.WriteLine($"{a} / {b} = {(float)a / b:F2}");
        Console.WriteLine($"{a} / {b} = {(float)a / b:F0}");
    }

}