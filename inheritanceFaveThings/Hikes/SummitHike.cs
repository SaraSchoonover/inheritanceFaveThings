using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Hikes
{
    class SummitHike : HikesBase
    {
        public SummitHike(string name, int amountOfMiles)
        {
            Name = name;
            AmountOfMiles = amountOfMiles;
        }
    }
}
