namespace MyProject;

public class Operatore
{
    public static void Cal()
    {
        const int xa =10;
        // 1. Arithmetic Operators
        int a = 10;
        int b = 3;
        int sum = a + b;        // 13
        int diff = a - b;       // 7
        int product = a * b;    // 30
        int quotient = a / b;   // 3 (Integer division drops decimals)
        int remainder = a % b;  // 1 (Modulo)

        // 2. Assignment & Compound Operators
        int c = 5;
        c += 10;                // Same as c = c + 10 (15)
        c *= 2;                 // 30
        c++;                    // Increment by 1 (31)
        c--;                    // Decrement by 1 (30)

        // 3. Comparison Operators (Returns bool)
        bool isEqual = (a == b);      // false
        bool isNotEqual = (a != b);   // true
        bool isGreater = (a > b);     // true
        bool isLessOrEqual = (a <= 10); // true

        // 4. Logical Operators
        bool x = true;
        bool y = false;
        bool both = x && y;     // Logical AND (false)
        bool either = x || y;   // Logical OR (true)
        bool opposite = !x;     // Logical NOT (false)

        // 5. Ternary Operator (Short if-else)
        // Syntax: condition ? result_if_true : result_if_false
        string status = (a > 5) ? "High" : "Low";

        // 6. Null-Related Operators (Advanced & Modern)
        string name = null;

        // Null-coalescing (??): Use "Guest" if name is null
        string displayName = name ?? "Guest";

        // Null-conditional (?.): Only call Length if name is not null
        int? length = name?.Length;

        // Null-coalescing assignment (??=): Assign only if currently null
        name ??= "New User";

        // 7. Type Testing & Casting
        object data = "Hello";
        bool isString = data is string;       // true
        string strData = data as string;      // Safely casts to string or null if fails

        // --- Practical Example for Data Engineering ---
        var records = new List<string> { "Data1", null, "Data3" };
        foreach (var item in records)
        {
            // Using the Null-conditional and Null-coalescing together
            string output = item?.ToUpper() ?? "MISSING_DATA";
            Console.WriteLine(output);
        }        
    }
}
