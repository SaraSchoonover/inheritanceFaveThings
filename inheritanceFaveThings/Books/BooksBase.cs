using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Books
{
    class BooksBase
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Read()
        {
            Console.WriteLine($"My favorite book is called {Name}.");
        }
    }
}
