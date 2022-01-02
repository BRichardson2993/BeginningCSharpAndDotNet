using System;

namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // declares 2 variables
            int myInteger;
            string myString;
            // assigns values to the variables
            myInteger = 17;
            myString = "\"myInteger\" is";
            // outputs the values of the two variables to the console
            Console.WriteLine($"{myString} {myInteger}");
            // keeps the console open until any key press
            Console.ReadKey();
        }
    }
}
