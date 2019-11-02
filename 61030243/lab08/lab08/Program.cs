using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of characters.
            char[] array1 = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            Array.Sort(array1);

            // Array of strings.
            string[] colors = new string[] { "red", "orange", "blue", "green", "yellow", "lemon", "aqua" };
            Array.Sort(colors);

            string[] AseanCountries = new string[] { "Cambodia", "Malaysia", "Indonesia", "Singapore", "Thailand", "Philippines", "Vietnam", "Brunei Darussalam", "Laos", "Myanmar" };

            // C# program that uses LINQ
            var sortAscending = from country in AseanCountries
                                orderby country
                                select country;
            var sortDescending = from country in AseanCountries
                                 orderby country descending
                                 select country;

            // print output
            Console.WriteLine("------Character sorting----------");
            foreach (var c in array1)
                Console.WriteLine(c);

            Console.WriteLine("------String sorting----------");
            foreach (string color in colors)
                Console.WriteLine(color);

            Console.WriteLine("------String sort ascending----------");
            foreach (string c in sortAscending)
                Console.WriteLine(c);

            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);
            // wait
            Console.ReadLine();
        }
    }
}
