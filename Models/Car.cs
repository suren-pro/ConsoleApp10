using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    abstract class Car : Vechile,IDrive
    {
        public Car(int maxSpeed, int seatCount) : base(maxSpeed, seatCount)
        {
        }

        public abstract void Drive();
    }
}
