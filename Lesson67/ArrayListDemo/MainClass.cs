using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            // Show number of items in ArrayList.
            Console.WriteLine("This collection has {0} items at first.", strArray.Count);
            // Display initial array content 
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
            Console.WriteLine("------------");

            // Add a new item and display current count.
            Console.WriteLine("Adding a number 2024 ......");
            strArray.Add(2024); // Nongeneric => not type safe.
            Console.WriteLine("This collection has {0} items now.", strArray.Count);
            // Display current array content
            foreach (var s in strArray)   //var: variable (represents for all data types)
            {
                Console.WriteLine("Entry: {0}", s);
            }
            Console.WriteLine("-------------");

            // Remove existing item from array list
            Console.WriteLine("Remove number 2024 & string 'Second' ......");
            // Remove by object value
            strArray.Remove(2024);
            // Remove by object index
            strArray.RemoveAt(1); //index = 1 => object with value "Second" in array
            // Display the final list of array
            foreach (string s in strArray)
            {
                Console.WriteLine("Entry: {0}", s);
            }
        }
    }
}
