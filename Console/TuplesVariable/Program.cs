internal class Program
{
    private static void Main(string[] args)
    {
        //int[] arr = { 5, 1, 9, 2, 4, 8, 9, 6, 1, 7, 5, 9, 3};
        int[] arr = { 5, 1, 9, 2 };

        (int Tong, int SL) tt = SumCount(arr);
        Console.WriteLine($"Tong cong: {tt.Tong}\nSo luong: {tt.SL}");
        tt.SL = 10;
        Console.WriteLine($"Tong cong: {tt.Tong}\nSo luong: {tt.SL}");

        string[] strings = { "15", "FPT", "8.5", "University", "10", "True" };

        foreach( string s in strings)
        {
            if (int.TryParse(s, out _))
            {
                Console.WriteLine(s+" is an integer number.");
            } else
            {
                Console.WriteLine(s+" is not an integer number.");
            }
        }

        int.TryParse(Console.ReadLine(), out int n);
        //int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your inputed {n}");


    }

    public static (int S, int C) SumCount(int[] arr)
    {
        int sum = 0, count = 0;
        foreach (int e in arr)
        {
            sum += e;
            count++;
        }
        return (sum, count);
    }
}