/*
 * product <= 100 => triple (*3) product value
 * product > 100 => do nothing
*/
Console.Write("Enter product value: ");
int product = Convert.ToInt32(Console.ReadLine());

while (product <= 100)
{
    product = product * 3; //triple product value
    product++; //increase product value by 1
}
Console.WriteLine("product = " + product);