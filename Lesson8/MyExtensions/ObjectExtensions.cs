using System;
using System.Reflection;
namespace MyExtensions
{
    static class ObjectExtensions
    {
        //Define an extension method to System.Object
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here:\n\t->{1}", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()));
        }
    }
}
