using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Cities
{
    class Emerging : CitiesBase
    {
        public Emerging(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
