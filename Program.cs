using ConsoleApp10.Models;
using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Truck truck = new Truck(120,2);
            truck.Drive();
        }
    }
}
