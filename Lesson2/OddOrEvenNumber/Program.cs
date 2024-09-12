/*
Homework 1: Exercise 4
Odd or Even Number
Write a C# program to check whether a given number is odd or even.
*/

//Step 1: Prompt (ask) user to input number
Console.Write("Enter an integer number: ");
//Step 2: Get user's input, convert to number and save to variable
int n = Convert.ToInt32(Console.ReadLine());
//Step 3: Check this number is even or odd and display result
if (n % 2 != 0)
    Console.WriteLine(n + " is odd");
else
    Console.WriteLine(n + " is even");