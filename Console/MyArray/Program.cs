internal class Program
{
    private static void Main(string[] args)
    {
        //Console.Write("Input number of elements: ");
        //int n = int.Parse(Console.ReadLine()); 
        //int[] arr = new int[n];
        int[] arr = { 5, 1, 9, 2, 4 ,8,9,6,1,7,5,9,3,};    
        //InputArray(arr);
        DisplayArray(arr);
        //Array.Sort(arr);        //Sort in ascending order
        //DisplayArray(arr);
        //SortDesc(arr);
        //DisplayArray(arr);
        //Console.WriteLine($"The maximum value: {getMax(arr)}");
        //Console.WriteLine($"The maximum value: {getMax2(arr)}");
        int pos1, pos2;
        pos1 = GetPosTheK(arr, GetMin(arr), 2);
        pos2 = GetPosTheK(arr, GetMax(arr), 3);
        SortAscInRange(arr, pos1, pos2);
        DisplayArray(arr);
        
    }
    //Return the position the-K of x in the arr. Return -1 if find not found
    public static int GetPosTheK(int[] arr, int x, int theK)
    {
        int count = 0, pos = -1;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == x) {
                count++;
                if (count == theK) {
                    pos = i; break;
                }
            }
        }
        return pos;
    }

    //Sort the array arr from position pos1 to pos2 in ascending order.
    public static void SortAscInRange(int[] arr, int pos1,  int pos2)
    {
        for (int i = pos1; i < pos2; i++)
        {
            for(int j = pos2; j>i; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j]; arr[j] = arr[j - 1]; arr[j - 1] = temp;  
                }
            }
        }
    }
    public static int GetMin2(int[] arr)
    {
        Array.Sort(arr);
        return arr[0];
    }
    public static int GetMax2(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length-1];
    }
    public static int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int i in arr) 
            if (i > max) max = i;
        return max;
    }

    public static int GetMin(int[] arr)
    {
        int min = arr[0];
        foreach (int i in arr)
            if (i < min) min = i;
        return min;
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