using Example01;

//create new Car object (class instance)
Car car1 = new Car("Mercedes", "S450", "Black", 100000);
Car car2 = new Car("Toyota", "Vios", "Silver", 25000);
//display car information
Console.WriteLine("1st car detail: ");
car1.ShowCarInformation();
Console.WriteLine("\n2nd car: ");
Console.WriteLine("Initial price: $" + car2.getPrice());
car2.setNewPrice(15000);
Console.WriteLine("Sale price: $" + car2.getPrice());