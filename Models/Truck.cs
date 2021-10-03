﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Truck : Car
    {
        public Truck(int maxSpeed, int seatCount) : base(maxSpeed, seatCount)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Truck is driving");

        }
    }
}
