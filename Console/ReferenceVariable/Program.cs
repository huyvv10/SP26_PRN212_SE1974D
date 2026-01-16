internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.Write("Input a = "); a = int.Parse(Console.ReadLine());
        Console.Write("Input b = "); b = int.Parse(Console.ReadLine());
        Console.WriteLine($"a = {a}, b = {b}");
        swap( a, b );
        Console.WriteLine($"a = {a}, b = {b}");
        
        if( a > b )
            swapRef(ref a, ref b );
        for( int i = a; i <= b; i++ )
            Console.Write(i+" ");
            //Console.WriteLine($"After swapRef a = {a}, b = {b}");


    }
    public static void swapRef(ref int a, ref int b)
    {
        int temp = a; a = b; b = temp;
        Console.WriteLine($"Within swapRef a = {a}, b = {b}");
    }
    public static void swap(int a, int b)
    {
        int temp = a; a = b; b = temp;
        Console.WriteLine($"Within swap a = {a}, b = {b}");
    }
}