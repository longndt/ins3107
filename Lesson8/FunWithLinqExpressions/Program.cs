﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace FunWithLinqExpressions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");

            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[] {
                new ProductInfo{ Name = "Mac's Coffee",
                    Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo{ Name = "Milk Maid Milk",
                    Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu",
                    Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo{ Name = "Cruchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo{ Name = "RipOff Water",
                    Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza",
                    Description = "Everyone loves pizza!", NumberInStock = 73},
                new ProductInfo { }  //an empty ProductInfo item
        };

            // We will call various methods here!
            Console.ReadLine();

            //GetPizzaOverStock(itemsInStock);
            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object o in objs)
            {
                Console.WriteLine(o); // Calls ToString() on each anonymous object.
            }
            Console.ReadLine();

        }

        static void SelectEverything(ProductInfo[] products)
        {
            // Get everything!
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;

            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            // Now get only the names of the products.
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;

            foreach (var n in names)
            {
                Console.WriteLine("Name: {0}", n);
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");

            // Get only the items where we have more than
            // 25 in stock.
            var overstock = from p in products where p.NumberInStock > 25 select p;

            foreach (ProductInfo p in overstock)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void GetPizzaOverStock(ProductInfo[] products)
        {
            // Get BMWs going at least 100 mph.
            var onlyPizzaOverStock = from p in products
                                     where p.NumberInStock > 25 && p.Name.ToLower().Contains("pizza")
                                     select p;
            foreach (ProductInfo p in onlyPizzaOverStock)
            {
                Console.WriteLine(p);
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            //By default name is sorted ascendingly
            var subset = from p in products orderby p.Name select p;
            //Sort descendingly
            //var subset = from p in products orderby p.Name descending select p;
            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        // Return value is now an Array.
        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description, p.NumberInStock };

            // Map set of anonymous objects to an Array object.
            return nameDesc.ToArray();
        }

        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                                "Fallout 3", "Daxter", "System Shock 2"};

            // Get count from the query.
            int numb =
            (from g in currentVideoGames where g.Length > 6 select g).Count();

            // Print out the number of items.
            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }
    }
}
