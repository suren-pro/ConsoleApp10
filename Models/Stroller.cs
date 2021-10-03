using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Stroller : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Stroller driving");
        }
    }
}
