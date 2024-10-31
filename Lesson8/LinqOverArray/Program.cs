using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqOverArray
{
    class MainClass
    {
        public static void QueryOverStrings()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            // Build a query expression to find the items in the array that have an embedded space.  Then order the result
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            // Print out the results.
            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }

        static void QueryOverStringsLongHand()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            string[] gamesWithSpaces = new string[5];

            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                    gamesWithSpaces[i] = currentVideoGames[i];
            }
            // Now sort them.
            Array.Sort(gamesWithSpaces);
            // Print out the results.
            foreach (string s in gamesWithSpaces)
            {
                if (s != null)
                    Console.WriteLine("Item: {0}", s);
            }
            Console.WriteLine();
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Use implicit typing here...
            var subset = from i in numbers where i < 10 select i;

            // ...and here.
            foreach (var i in subset)
                Console.WriteLine("Item: {0} ", i);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("************** Fun with LINQ **************");

            QueryOverStrings();

            //QueryOverStringsLonghand();

            //QueryOverInts();

            Console.ReadLine();
        }
    }
}
