using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Airport
    {
        public String city { get; set; }
        public String name { get; set; }
        public String acronym { get; set; }
        public List<Destination> destinations { get; set; }
        public Airport(String city, String name, String acronym)
        {
            this.city = city;
            this.name = name;
            this.acronym = acronym;
            destinations = new List<Destination>();
        }
        public void addDestination(Destination d)
        {
            destinations.Add(d);
        }
    }
}
