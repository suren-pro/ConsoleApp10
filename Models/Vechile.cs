using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    abstract class Vechile:IDrive
    {
        public int MaxSpeed { get; set; }
        public int SeatCount { get; set; }
        public Vechile(int maxSpeed,int seatCount)
        {
            MaxSpeed = maxSpeed;
            SeatCount = seatCount;
        }

        public abstract void Drive();
    }
}
