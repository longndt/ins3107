/*
 * Press 1 => Fan's speed is 1
 * Press 2 => Fan's speed is 2
 * Press 3 => Fan's speed is 3
 * Press 0 => Fan stopped
 */

Console.Write("Enter fan's speed (0-3): ");
int speed = Convert.ToInt32(Console.ReadLine());

switch (speed)
{
    case 0:
        Console.WriteLine("Fan stopped");
        break;
    case 1:
        Console.WriteLine("Fan's speed is 1");
        break;
    case 2:
        Console.WriteLine("Fan's speed is 2");
        break;
    case 3:
        Console.WriteLine("Fan's speed is 3");
        break;
    default:
        Console.WriteLine("Invalid fan's speed");
        break;
}