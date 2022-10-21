using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 36; number++)
            {
                var isDivisableByThree = (number % 3) == 0; // (7 % 3) => 1 == 0 => false
                var isDivisableByFive = (number % 5) == 0;
                // true && false
                if ((isDivisableByThree && isDivisableByFive) || number == 22)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isDivisableByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else if (isDivisableByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
   
