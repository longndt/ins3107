using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAsVenn
{
    internal class Program
    {
        static void DisplayDiff()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c)
              .Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s); // Prints Yugo.
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            // Get the common members.
            var carIntersect = (from c in myCars select c)
              .Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
                Console.WriteLine(s); // Prints Aztec and BMW.
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            // Get the union of these containers.
            var carUnion = (from c in myCars select c)
            .Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s); // Prints all common members.
        }

        static void DisplayConcat()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c)
              .Concat(from c2 in yourCars select c2);

            // Prints:
            // Yugo Aztec BMW BMW Saab Aztec.
            foreach (string s in carConcat)
                Console.WriteLine(s);
        }

        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c)
              .Concat(from c2 in yourCars select c2);

            // Prints:
            // Yugo Aztec BMW Saab Aztec.
            foreach (string s in carConcat.Distinct())
                Console.WriteLine(s);
        }

        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            // Various aggregation examples.
            Console.WriteLine("Max temp: {0}",
              (from t in winterTemps select t).Max());

            Console.WriteLine("Min temp: {0}",
              (from t in winterTemps select t).Min());

            Console.WriteLine("Average temp: {0}",
              (from t in winterTemps select t).Average());

            Console.WriteLine("Sum of all temps: {0}",
              (from t in winterTemps select t).Sum());
        }


        static void Main(string[] args)
        {
            DisplayDiff();

            //DisplayIntersection();

            //DisplayUnion();

            //DisplayConcat();

            //DisplayConcatNoDups();

            //AggregateOps();
        }
    }
}
