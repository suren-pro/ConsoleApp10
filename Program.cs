using ConsoleApp10.Models;
using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck(120,2);
            Garage garage = new Garage();
            garage.SelectToDrive(truck);
        }
    }
}
