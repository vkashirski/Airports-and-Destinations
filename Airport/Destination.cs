using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Destination
    {
        public String name { get; set; }
        public int distance { get; set; }
        public int price { get; set; }
        public Destination(String name, int distance, int price)
        {
            this.name = name;
            this.distance = distance;
            this.price = price;
        }
    }
}
