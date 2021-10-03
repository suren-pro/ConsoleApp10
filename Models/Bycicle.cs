using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Bycicle : Vechile
    {
        public Bycicle(int maxSpeed, int seatCount) : base(maxSpeed, seatCount)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Bycicle is driving");
        }
    }
}
