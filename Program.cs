using ConsoleApp10.Models;
using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck(120,2);
            Hatchback hatchback = new Hatchback(120,2);
            Sedan sedan = new Sedan(120,2);
            Horse horse = new Horse();
            Bycicle bycicle = new Bycicle();
            Stroller stroller = new Stroller();
            Garage garage = new Garage();
            garage.AddItem(truck);
            garage.AddItem(hatchback);
            garage.AddItem(sedan);
            garage.AddItem(horse);
            garage.AddItem(bycicle);
            garage.AddItem(stroller);
            garage.TryAll();
        }
    }
}
