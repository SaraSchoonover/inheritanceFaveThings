using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Sushi
{
    class Sashimi : SushiBase
    {
        public Sashimi(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
