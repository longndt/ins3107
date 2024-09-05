using System;

public class Demo
{
    public static void Main (string[] args)
    {
        //declare data types using variable
        string text = ".NET Framework 8.0";  //double quote
        int year = 2024;
        double price = 999.99; //recommend to use double for floating point number
        float pi_number = (float)3.14;
        char gender = 'M'; //M: Male - single quote
        bool pass = false; //failed

        //display variable values with Console.WriteLine
        Console.WriteLine(text);
        //use addition symbol (+) for string concatenation
        Console.WriteLine("We are living in " + year);
        Console.WriteLine("This laptop's price is " + price + "$");
    }
}