using System.Collections;

namespace ArrayList123
{
    public class Program
    {
        public static void Main()
        {
            //create Mobile objects
            Mobile mobile1 = new Mobile("iPhone", 1000);
            Mobile mobile2 = new Mobile("Samsung", 1111);

            //declare an ArrayList  
            ArrayList devices = new ArrayList();

            //add mobile objects to ArrayList
            devices.Add(mobile1);
            devices.Add(mobile2);
            mobile1.showMobileInfo();
            mobile2.showMobileInfo();
            Console.WriteLine("Total items: " + devices.Count);
            //at this moment, ArrayList is Generic Collection (safe)

            //now create Laptop objects
            Laptop laptop1 = new Laptop("Macbook", 2000);
            Laptop laptop2 = new Laptop("Dell", 1500);

            //add laptop objects to ArrayList
            devices.Add(laptop1);
            devices.Add(laptop2);
            laptop1.showLaptopInfo();
            laptop2.showLaptopInfo();
            Console.WriteLine("Total items: " + devices.Count);
            //at this moment, ArrayList has become NonGeneric Collection (unsafe)

            //display ArrayList items
            foreach (var device in devices)
            {
                Console.WriteLine(device);
            }
        }
    }
}


