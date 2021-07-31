using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Hikes
{
    class HikesBase
    {
        public string Name { get; set; }
        public int AmountOfMiles { get; set; }

        public void Climb()
        {
            Console.WriteLine($"Today I hiked at for {AmountOfMiles} miles at {Name}.");
        }
    }
}
