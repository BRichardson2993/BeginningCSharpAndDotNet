using System;

namespace Ch03Ex3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;


            Console.WriteLine("Please enter a number.");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a third number.");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a final number.");
            num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The product of {num1}, {num2}, {num3}, and {num4} is " + num1 * num2 * num3 * num4);
           
        }
    }
}
