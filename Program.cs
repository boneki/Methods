using System;

namespace MethodsEthanAnderson
{
    class Program
    {
        static void myMethod(int a, int b, string x)
        {
            // Addition
            if (x == "a")
            {
                Console.WriteLine("The sum of " + a + " and " + b + " is " + (a + b));
            }

            // Subtraction
            else if (x == "s")
            {
                Console.WriteLine("The difference of " + a + " and " + b + " is " + (a - b));
            }

            // Multiplication
            else if (x == "m")
            {
                Console.WriteLine("The product of " + a + " and " + b + " is " + (a * b));
            }

            // Division
            else if (x == "d")
            {
                // Preventing an error caused by denominator of zero
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }

                // Allowing division to continue for any denominator other than zero
                else
                {
                    Console.WriteLine("The quotient of " + a + " and " + b + " is " + (a / b));
                }
            }

            else
            {
                Console.WriteLine("Flag not recognized.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ethan Anderson");

            // Avoiding hard coding
            int y = 6;
            int z = 3;

            // Addition
            myMethod(y, z, "a");

            // Subtraction
            myMethod(y, z, "s");

            // Multiplication
            myMethod(y, z, "m");

            // Division
            myMethod(y, z, "d");

            Console.WriteLine("---------------------------------");

            // Attempting to divide by zero
            myMethod(y, 0, "d");

            // Attempting to use unknown flag
            myMethod(y, z, "q");
        }
    }
}
