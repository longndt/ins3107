//Grade >=60: display "Passed"
//Grade <60: display "Failed"

Console.Write("Enter your grade: ");
int grade = int.Parse(Console.ReadLine());
if (grade >= 60)
    Console.WriteLine("Passed");
else //grade < 60
    Console.WriteLine("Failed");