/*
 * Excellent: 90-100 (if)
 * Good: 80-89 (else if)
 * Fair: 60-79 (else if)
 * Pass: 50-59 (else if)
 * Fail: 0-49 (else)
 */
//Solution: using Nested If (If inside If)
Console.Write("Enter your grade: ");
int grade = int.Parse(Console.ReadLine());
if (grade >= 90 && grade <= 100)
    Console.WriteLine("Excellent");
else if (grade >= 80 && grade <= 89)
    Console.WriteLine("Good");
else if (grade >= 60 && grade <= 79)
    Console.WriteLine("Fair");
else if (grade >= 50 && grade <= 59)
    Console.WriteLine("Pass");
else if (grade >= 0 && grade <= 49)
    Console.WriteLine("Fail");
else //grade > 100 or grade < 0
    Console.WriteLine("Invalid grade"); 