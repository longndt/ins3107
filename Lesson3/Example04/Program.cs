//Prompt user to get grade for each subject
Console.Write("Enter Math grade: ");
int math = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Science grade: ");
int science = Convert.ToInt32(Console.ReadLine());
//Calculate average grade
int average = (math + science) / 2;
//Determine grade scale (A, B, C)
if (average >= 70)
    Console.WriteLine("Grade A");
else if (average >=50 && average < 70)
    Console.WriteLine("Grade B");
else
    Console.WriteLine("Grade C");
