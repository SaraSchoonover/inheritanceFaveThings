using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Sushi
{
    class SushiBase
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is my favorite {Type}.");
        }
    }
}
