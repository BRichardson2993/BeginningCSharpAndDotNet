using System;

namespace Exercise4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // must include this logic: (var 1 > 10) ^ (var2 > 10)

            Console.WriteLine("Please enter a number lower than 10:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number lower than 10");
            int num2 = Convert.ToInt32(Console.ReadLine());           

            if((num1 > 10) ^ (num2 > 10))
            {
                Console.WriteLine("You entered a number greater than 10.");
            }
            else
            {  
                var greatest = 0;

                if (num1 > num2)
                {
                    greatest = num1;
                }
                else
                {
                    greatest = num2;
                }
                Console.WriteLine($"Your numbers are {num1} and {num2}, of which {greatest} is the greatest.");
            }
            Console.ReadKey();


        }
    }
}
