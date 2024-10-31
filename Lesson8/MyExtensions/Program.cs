using System;
namespace MyExtensions
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Since everything extends System.Object, all classes and structures can use this
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();
        }
    }
}
