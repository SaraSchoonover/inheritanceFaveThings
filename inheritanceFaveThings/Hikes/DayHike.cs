using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Hikes
{
    class DayHike : HikesBase
    {
        public DayHike(string name, int amountOfMiles)
        {
            Name = name;
            AmountOfMiles = amountOfMiles;
        }
    }

}
