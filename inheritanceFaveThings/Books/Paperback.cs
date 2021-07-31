using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceFaveThings.Books
{
    class Paperback : BooksBase
    {
        public Paperback(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
