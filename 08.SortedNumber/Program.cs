﻿namespace _08.SortedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
                {
                    Console.WriteLine("Descending");
                }
            else if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}