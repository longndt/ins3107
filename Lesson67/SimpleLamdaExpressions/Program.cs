using System;
using System.Collections.Generic;
namespace SimpleLambdaExpressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TraditionalDelegateSyntax();

            //AnonymousMethodSyntax();

            Console.ReadLine();
        }

        private static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            //Call FindAll() using traditional delegate syntax
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            foreach (var number in evenNumbers)
            {
                Console.Write("{0}\t", number);
            }
            Console.WriteLine();
        }
        static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }

        static void AnonymousMethodSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // (1) Now, use an anonymous method.
            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; });

            // (2) Now, use lambda expression.
            // List<int> evenNumbers = list.FindAll(i => i % 2 == 0);

            // (3) Now, use lambda expression with block of codes.
            /* List<int> evenNumbers = list.FindAll(i => {
                Console.WriteLine("Value of i is currently {0}", i);
                bool isEven = i % 2 == 0;
                return isEven;
            }); */


            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

    }
}
