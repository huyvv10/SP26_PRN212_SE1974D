internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Input number of elements: ");
        int n = int.Parse(Console.ReadLine()); 
        int[] arr = new int[n];
        InputArray(arr);
        DisplayArray(arr);
        Array.Sort(arr);        //Sort in ascending order
        DisplayArray(arr);
        SortDesc(arr);
        DisplayArray(arr);
        Console.WriteLine($"The maximum value: {getMax(arr)}");
        Console.WriteLine($"The maximum value: {getMax2(arr)}");
        
    }
    public static int getMax2(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length-1];
    }
    public static int getMax(int[] arr)
    {
        int max = arr[0];
        foreach (int i in arr) 
            if (i > max) max = i;
        return max;
    }
    public static void SortDesc(int[] a)
    {
        Array.Sort(a);
        Array.Reverse(a);
    }
    public static void InputArray(int[] a) {
        for (int i = 0; i < a.Length; i++) {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine()) ;
        }
    }
    public static void DisplayArray(int[] a) { 
        foreach (int i in a) Console.Write(i+" ");
        Console.WriteLine();
    }


}