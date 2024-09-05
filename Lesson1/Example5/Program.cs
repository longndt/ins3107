//get a and b from keyboard
Console.Write("Enter a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());

//compare a & b then return result
if (a > b)
    Console.WriteLine("a is greater than b");
else if (b > a)
    Console.WriteLine("b is greater than a");
else
    Console.WriteLine("a is equal to b");