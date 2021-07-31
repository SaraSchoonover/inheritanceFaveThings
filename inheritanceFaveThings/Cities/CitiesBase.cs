using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Cities
{
    class CitiesBase
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public void Visit()
        {
            Console.WriteLine($"Please visit {Name}!");
        }
    }
}
