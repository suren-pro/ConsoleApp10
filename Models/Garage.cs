using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    class Garage
    {
        List<IDrive> items=new List<IDrive>();
        public void AddItem(IDrive drive)
        {
            items.Add(drive);
        }
        public void TryAll()
        {
            foreach (var item in items)
            {
                item.Drive();
            }
        }
    }
}
