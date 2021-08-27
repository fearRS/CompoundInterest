using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the principal balance: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the interest rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of times interest is compounded per year: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in years: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double value = 1 + (rate / number);
            double exponent = number * time;
            double compound = Math.Round(principal * Math.Pow(value, exponent), 2);

            Console.WriteLine($"The compounding interest is: ${compound}");
            Console.ReadLine();
        }
    }
}
