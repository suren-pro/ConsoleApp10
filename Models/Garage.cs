using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Garage
    {
        public void SelectToDrive(IDrive vechile)
        {
            vechile.Drive();
        }
    }
}
