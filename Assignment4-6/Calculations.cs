using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_6
{

    class Calculations
    {
        public double calculateMPG(double milesTraveled, double gallons)
        {
            double milesPerGallon = (milesTraveled / gallons);
            return milesPerGallon;
        }
        public double calculateCostPerMile(double totalFuelCost, double milesTraveled)
        {
            double costPerMile = (totalFuelCost / milesTraveled);
            return costPerMile;
        }
        private string destination;
        private double milesTraveled;
        private double gallons;
        private double totalFuelCost;
        private double mpg;
        private double cost_per_mile;

        public Calculations()
        {
        }

        public Calculations(string tripDestination, double traveled, double gallons_of_fuel, double fuelCost)
        {
            destination = tripDestination;
            milesTraveled = traveled;
            gallons = gallons_of_fuel;
            totalFuelCost = fuelCost;
            mpg=calculateMPG(milesTraveled, gallons);
            cost_per_mile=calculateCostPerMile(totalFuelCost,milesTraveled);
        }
        public override string ToString()
        {
            return "\nDestination: " + destination + "\nMiles Traveled: " + milesTraveled + "\nFuel Consumed: " 
                + gallons + "\nTotal Fuel Cost: " + totalFuelCost + "\nMPG: " + mpg.ToString("f2") + "\nCost per Mile: " + cost_per_mile.ToString("c2");
        }
    }
}
