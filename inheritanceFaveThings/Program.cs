using inheritanceFaveThings.Books;
using inheritanceFaveThings.Cities;
using inheritanceFaveThings.Hikes;
using inheritanceFaveThings.Sushi;
using System;

namespace inheritanceFaveThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var salmonRoll = new Sashimi("Salmon", "fish");
            salmonRoll.Eat();

            var tunaRoll = new Nigiri("Tuna", "fish");
            tunaRoll.Eat();

            var hike = new DayHike("Beaman Park", 2);
            hike.Climb();

            var hikeAgain = new SummitHike("Mt. Whitney", 19);
            hikeAgain.Climb();

            var book = new Hardback("Please Kill Me", "nonfiction");
            book.Read();

            var newBook = new Paperback("The Sun also Rises", "fiction");
            newBook.Read();

            var city = new Developed("Newcastle", 200);
            city.Visit();

            var city2 = new Emerging("Belize City", 60);
            city2.Visit();


        }
    }
}
