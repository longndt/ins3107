using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //Working with the List<T> Class
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax.
            List<Person> people = new List<Person>(){
                new Person {FirstName= "Homer", LastName="Simpson", Age=47},
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
              };
            // Print out # of items in List.
            Console.WriteLine("Items in list: {0}", people.Count);
            // Enumerate over list.
            foreach (Person p in people)
                Console.WriteLine(p);
            // Insert a new person.
            Console.WriteLine("\n->Inserting new person.");
            Person newPerson = new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 };
            people.Insert(4, newPerson);

            // Print out again total item in list
            Console.WriteLine("Items in list: {0}", people.Count);

            // Delete a person from list
            Console.WriteLine("\n->Delete a person.");
            people.Remove(newPerson);

            // Print out again total item in list
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Names: {0}", arrayOfPeople[i].FirstName);
            }
        }

    }
}
