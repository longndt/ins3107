public class VNU
{
    //we must add "static" keyword in this case for variable access in "Main" method
    static string university = "VNU IS";

    static private void welcome()
    {
        Console.WriteLine("Welcome to VNU IS");
    }

    public static void Main()
    {
        Console.WriteLine(university);
        welcome();
    }
}
