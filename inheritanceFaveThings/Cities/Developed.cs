using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Cities
{
    class Developed : CitiesBase
    {
        public bool IsExpensive { get; set; }

        public Developed(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
