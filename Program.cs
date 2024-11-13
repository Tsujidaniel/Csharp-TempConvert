// See https://aka.ms/new-console-template for more information
using System;
using System.IO.Compression;

namespace Temperatureconversion
{
    class Program
    {
        static void Main (string[] args)
        {
            do
            {           
                Console.WriteLine("--------------------------------");
                Console.WriteLine("This is a temperature conversion");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("which conversion would you like to do?:");
                Console.WriteLine("1 - Celsius to Fahrenheit or 2 - Fahrenheit to Celsius");
                string? decision = Console.ReadLine();
                switch (decision)
                {
                    case "1":
                        Console.WriteLine("Type your valor to be corverted to Fahrenheit");
                        double degree = Convert.ToDouble(Console.ReadLine());
                        double result = (degree*1.80) + 32;
                        Console.WriteLine(result.ToString("N2")+" F");
                        break;
                    case "2":
                        Console.WriteLine("Type your valor to be corverted to Celsius");
                        double degree2 = Convert.ToDouble(Console.ReadLine());
                        double result2 = (degree2-32) / 1.80;
                        Console.WriteLine(result2.ToString("N2")+" C");
                        break;
                    default:
                        Console.WriteLine("Incorret option, try again.");
                        break;
                }    
                Console.WriteLine("Would you like to do a new conversion? Y - Yes or N - No");
            } while (Console.ReadLine()?.ToUpper()== "Y");
            Console.WriteLine("Bye!");
        }

    }
}
