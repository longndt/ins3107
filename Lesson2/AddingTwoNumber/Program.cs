/* Requirement
Please create a new program to
– Ask user to input two numbers
– Add two numbers
– Display the result
*/

//Ask user to input numbers
Console.Write("Enter first number: ");
//Get numbers from keyboard input (user)
//Convert text to number (default input is text)
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int y = int.Parse(Console.ReadLine());

//Add two numbers
int total = x + y;

//Display the result
Console.WriteLine(x + " + " + y + " = " + total);
