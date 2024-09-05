Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your birth year: ");
//must do type casting (conversion) for number first
int birthYear = Convert.ToInt32(Console.ReadLine());
//calculate age based on birth year
int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine("Hello " + name);
Console.WriteLine("You are " + age + " age year old now");

//Run code with CTRL + F5