using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Sedan : Vechile
    {
        public Sedan(int maxSpeed, int seatCount) : base(maxSpeed, seatCount)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Sedan is driving");
        }
    }
}
