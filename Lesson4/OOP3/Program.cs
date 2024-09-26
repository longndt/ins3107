using OOP3;

//create object
Laptop macbook = new Laptop
{
    Brand = "Apple",
    Model = "Macbook Pro 16",
    Price = 2999.99,
    Year = 2023
};

Laptop dell = new Laptop
{
    Brand = "Dell",
    Model = "XPS 15",
    Price = 1000,
    Year = 2024
};

//display object detail
Console.WriteLine("Brand: " + macbook.Brand);
Console.WriteLine("Model: " + macbook.Model);
Console.WriteLine("Initial Price: $" + macbook.Price);
//change price
macbook.Price *= 0.5;
Console.WriteLine("Sale Price: $" + macbook.Price);
Console.WriteLine("-----------------------");
Console.WriteLine(dell.Brand + " " + dell.Model + " - $" + dell.Price + " - " + dell.Year);