internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input n = ");
        int n = int.Parse(Console.ReadLine());  
        if (IsPrime(n))
            Console.WriteLine($"{n} is a prime number");
        else
            Console.WriteLine($"{n} is not a prime number");
        ListPrimeToN(n);
        ListTheFirstNPrimes(n);
    }

    //List the prime number from 2 to n
    public static void ListPrimeToN(int n)
    {
        if (n < 2) return;
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    //List the first n prime numbers
    public static void ListTheFirstNPrimes(int n)
    {
        int count = 0, i = 2;
        while (count < n) {
            if (IsPrime(i))
            {
                count++;
                Console.Write(i+" ");
            }
            i++;
        }
        Console.WriteLine();
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return true;
        for (int i = 2; i*i <= n; i++) 
            if (n%i == 0) return false;
        return true;
    }
}