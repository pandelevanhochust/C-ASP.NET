using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_
{
    public class DataTypes
    {
            // 1. Textual Types
            string name = "Gemini";            // A sequence of characters (Reference type)
            char grade = 'A';                  // A single 16-bit Unicode character

            // 2. Integral Types (Integers)
            int age = 25;                      // 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
            long population = 8000000000L;     // 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
            short distance = 500;              // 16-bit signed integer (-32,768 to 32,767)
            byte level = 255;                  // 8-bit unsigned integer (0 to 255)
            
            uint positive = 100;                 // 32-bit unsigned integer (0 to 4,294,967,295)
            ulong bigPositive = 10000000000UL;    // 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)
            ushort smallPositive = 500;             // 16-bit unsigned integer (0 to 65,535)            

            // 3. Floating-Point Types (Decimals)
            // Use 'double' for general math, 'decimal' for financial/high-precision data
            double pi = 3.14159;               // 64-bit precision
            float temperature = 36.6f;         // 32-bit precision (Note the 'f' suffix)
            decimal price = 99.99m;            // 128-bit high precision (Note the 'm' suffix)

            // 4. Boolean Type
            bool isWorking = true;             // Logic: true or false

            // 5. The "Object" Type
            object everything = "Can be any type"; // The base type for all other types
            // string converted = (string)everything;

            // 6. Implicitly Typed Variables
            // var message = "The compiler figures out this is a string";

            // Immutable
            // readonly
            // const
    }
}