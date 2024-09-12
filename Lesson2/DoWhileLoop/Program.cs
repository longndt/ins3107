int grade;
do
{
    Console.Write("Enter your grade (0-10): ");
    grade = Convert.ToInt32(Console.ReadLine());
} while (grade < 0 || grade > 10);
Console.WriteLine("Your grade is " + grade);