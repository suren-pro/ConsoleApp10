﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Bycicle : Vechile,IDrive
    {
        public Bycicle(int maxSpeed, int seatCount) : base(maxSpeed, seatCount)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Bycicle is driving");
        }
    }
}
