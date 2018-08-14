using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Trip Destination: ");
            string inputValue = Console.ReadLine();
            string destination = inputValue;
           
            Console.Write("Enter Miles Traveled: ");
            inputValue = Console.ReadLine();
            double milesTraveled = double.Parse(inputValue);
            
            Console.Write("Enter Gallons: ");
            inputValue = Console.ReadLine();
            double gallons = double.Parse(inputValue);

            Console.Write("Enter Total Fuel Cost: ");
            inputValue = Console.ReadLine();
            double totalFuelCost = double.Parse(inputValue);

            Calculations newCalculation = new Calculations(destination,milesTraveled,gallons,totalFuelCost);
            Console.WriteLine(newCalculation);
        }
    }
}
