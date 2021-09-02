using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int goldValue = 10;
            const int silverValue = 5;
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount of money in cents: ");
            string valueString = Console.ReadLine();
            double value = Convert.ToDouble(valueString);
            double gold = Math.Floor(value / 10);
            double remainder = value % goldValue;
            double silver = Math.Floor(remainder / 5);
            remainder = remainder % silverValue;
            Console.WriteLine($"{value} is equal to: {gold} gold, {silver} silver, and {remainder} bronze.");
        }
    }
}
