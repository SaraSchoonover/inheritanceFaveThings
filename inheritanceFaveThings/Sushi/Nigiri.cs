using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Sushi
{
    class Nigiri : SushiBase
    {
        public Nigiri(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
