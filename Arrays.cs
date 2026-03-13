namespace MyProject;

public class Arrays
{
    public static void DoArray()
    {
        // --- 1. Arithmetic Operators (Fixing your CS0236 error) ---
        int a = 10;
        int b = 3;
        int sum = a + b;
        int diff = a - b;
        Console.WriteLine($"Math: {a} + {b} = {sum}");


        // --- Define Array
        int[] numbers = [5, 2, 8, 1, 9];
        string[] names = new string[3];
        char[] chars = new char[5]{'H', 'e', 'l', 'l', 'o'};   
        Console.WriteLine(numbers[2]); // 8

        // Properties
        int len = numbers.Length; // Số lượng phần tử
        int rank = numbers.Rank;     // Số chiều (1D)

        char lastItem = chars[^2]; // Last item using index 
        char[] lasTwo = chars[^2..]; // Last two items using range 
        char[] firstThree = chars[..3]; // First three items using range
        char[] afterTwo = chars[2..]; // Items after the first two using range
        char[] betweenTwoAndFour = chars[2..4]; // Items between index 2 and 4 using range

        // Methods (Using System.Linq)
        int min = numbers.Min();     // Giá trị nhỏ nhất
        int max = numbers.Max();     // Giá trị lớn nhất
        int total = numbers.Sum();   // Tổng cộng

        Console.WriteLine($"Array Length: {len}");
        Console.WriteLine($"Min: {min}, Max: {max}, Sum: {total}");
    }

    public static void CompareArrays()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 1, 2, 3 };
        int[] arr3 = arr1;

        Console.WriteLine($"compare arrays arr1 arr2: {arr1 == arr2}"); //False
        Console.WriteLine($"compare arrays arr1 arr3: {arr1 == arr3}"); //True
        Console.WriteLine($"compare arrays arr1 arr2 with SequenceEqual: {arr1.SequenceEqual(arr2)}");
    }

    public static void IndiceAndRange()
    {
        char[] chars = ['H', 'e', 'l', 'l', 'o'];

        char lastItem = chars[^2]; // Last item using index 
        char[] lasTwo = chars[^2..]; // Last two items using range 
        char[] firstThree = chars[..3]; // First three items using range
        char[] afterTwo = chars[2..]; // Items after the first two using range
        char[] betweenTwoAndFour = chars[2..4]; // Items between index 2 and 4 using range
    }

    public static void MultiDimensionalArrays()
    {
        int[][] jagged = [[12, 34], [56, 78, 90]];

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int rows = matrix.GetLength(0); // Number of rows
        int cols = matrix.GetLength(1); // Number of columns
    }
}
