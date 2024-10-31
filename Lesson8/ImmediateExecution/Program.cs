using System;
using System.Linq;
using System.Collections.Generic;
namespace LinqOverArray
{
    class MainClass
    {
        static void ImmediateExecution()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // Get data RIGHT NOW as int[].
            int[] subsetAsIntArray =
            (from i in numbers where i < 10 select i).ToArray<int>();
            // Get data RIGHT NOW as List<int>.
            List<int> subsetAsListOfInts =
            (from i in numbers where i < 10 select i).ToList<int>();

            // Run foreach loop to display integer array elements to console
            foreach (var i in subsetAsListOfInts)
                Console.WriteLine(i);

            Console.WriteLine("---------------------");

            // Run foreach loop to display list elements to console
            foreach (var i in subsetAsListOfInts)
                Console.WriteLine(i);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("************** Fun with LINQ **************");
            ImmediateExecution();
            Console.ReadLine();
        }
    }
}