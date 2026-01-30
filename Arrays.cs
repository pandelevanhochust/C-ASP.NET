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

        // --- 2. Array Examples (From your table) ---
        int[] numbers = { 5, 2, 8, 1, 9 };

        // Properties
        int len = numbers.Length; // Số lượng phần tử
        int rank = numbers.Rank;     // Số chiều (1D)

        // Methods (Using System.Linq)
        int min = numbers.Min();     // Giá trị nhỏ nhất
        int max = numbers.Max();     // Giá trị lớn nhất
        int total = numbers.Sum();   // Tổng cộng

        Console.WriteLine($"Array Length: {len}");
        Console.WriteLine($"Min: {min}, Max: {max}, Sum: {total}");
    }
}
