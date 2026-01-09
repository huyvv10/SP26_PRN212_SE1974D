internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input Math score: ");
        float math=float.Parse(Console.ReadLine());
        Console.Write("Input English score: ");
        float eng=float.Parse(Console.ReadLine());
        Console.Write("Input Literature score: ");
        float lit=float.Parse(Console.ReadLine());
        float gpa = (math + eng + lit) / 3;
        if (gpa>=9)
            Console.WriteLine($"Your gpa is {gpa:F2}. You are excellence.");
        else if (gpa>=8)
            Console.WriteLine($"Your gpa is {gpa:F2}. You are good.");
        else if (gpa>=7)
            Console.WriteLine($"Your gpa is {gpa:F2}. You are well.");
        else if (gpa>=5)
            Console.WriteLine($"Your gpa is {gpa:F2}. You are fair.");
        else
            Console.WriteLine($"Your gpa is {gpa:F2}. You are poor.");
    }
}