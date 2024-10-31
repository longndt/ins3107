using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************ LINQ over generic collections *************");
            List<Car> myCars = new List<Car>()
            {
                new Car{PetName = "Henry", Color="Silver", Speed=100, Make="BMV"},
                new Car{PetName = "Daisy", Color="Tan", Speed=90, Make="BMV"},
                new Car{PetName = "Mary", Color="Black", Speed=55, Make="VW"},
                new Car{PetName = "Clunker", Color="Rust", Speed=5, Make="Yugo"},
                new Car{PetName = "Melvin", Color="White", Speed=43, Make="Ford"}
            };
            GetFastCars(myCars);
            GetFastBMVs(myCars);
            Console.ReadLine();

            /*
            Console.WriteLine("********* LINQ over ArrayList *************");
            ArrayList myCars = new ArrayList(){
                new Car{PetName = "Henry", Color="Silver", Speed=100, Make="BMV"},
                new Car{PetName = "Daisy", Color="Tan", Speed=90, Make="BMV"},
                new Car{PetName = "Mary", Color="Black", Speed=55, Make="VW"},
                new Car{PetName = "Clunker", Color="Rust", Speed=5, Make="Yugo"},
                new Car{PetName = "Melvin", Color="Silver", Speed=43, Make="Ford"}
            };
            //Transform ArrayList into an INumerable<T> compatible type.
            var myCarsEnum = myCars.OfType<Car>();
            //Create a query expression targeting the compatible type.
            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;
            foreach (var item in fastCars)
            {
                System.Console.WriteLine($"{item.PetName} is going too fast!");
            }
            */
        }

        public static void GetFastCars(List<Car> myCars)
        {
            //select cars with speed >= 55
            var fastCars = from c in myCars
                           where c.Speed > 55
                           select c;
            foreach (var item in fastCars)
            {
                System.Console.WriteLine($"{item.PetName} is going too fast");
            }
        }

        public static void GetFastBMVs(List<Car> myCars)
        {
            //select bmv cars that go faster than 55km
            var fastBMVs = from c in myCars
                           where c.Speed > 55 && c.Make.Equals("BMV")
                           select c;
            foreach (var item in fastBMVs)
            {
                System.Console.WriteLine($"{item.PetName} is going too fast.");
            }
        }
    }
}
