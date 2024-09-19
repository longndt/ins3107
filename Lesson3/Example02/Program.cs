//1. get mobile information
using Example02;

Console.Write("Enter mobile name: ");
string name = Console.ReadLine();
Console.Write("Enter mobile price: ");
double price = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter mobile year: ");
int year = int.Parse(Console.ReadLine());

//2. create mobile object
Mobile myMobile = new Mobile(name, price, year);

//3. display mobile information
myMobile.display();