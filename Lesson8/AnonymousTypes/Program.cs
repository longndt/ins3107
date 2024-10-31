using System;
namespace AnonymousTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 }
            };
            var ItemBought = purchaseItem.ItemBought;
            Console.WriteLine("Color: {0}, Make: {1}, CurrentSpeed: {2}, Bought at: {3}",
              ItemBought.Color, ItemBought.Make, ItemBought.CurrentSpeed, purchaseItem.TimeBought);
        }
    }
}
