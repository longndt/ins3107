using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare an integer to get user's input
            int choice = 0;
            //declare an array to store task list
            ArrayList taskList = new ArrayList();
            //add some initial tasks first into array (sample data) => optional
            taskList.AddRange(new string[] { "Do homework", "Review for midterm", "Study programming" });

            //repeat program menu using while or do while loop
            while (choice != 4)
            {
                //display list of menu in program
                Console.WriteLine("Task Manager application");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Tasks");
                Console.WriteLine("3. Delete Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Select 1 option: ");

                // choice = Convert.ToInt16(Console.ReadLine());
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //implement view tasks feature
                        Console.WriteLine("Viewing list of tasks");
                        foreach (string t in taskList)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case 2:
                        //implement add tasks feature
                        Console.WriteLine("Adding new task");
                        Console.Write("Enter task name: ");
                        string task = Console.ReadLine();
                        taskList.Add(task);
                        break;
                    case 3:
                        //implement delete tasks feature
                        Console.WriteLine("Delete task");
                        
                        break;
                    case 4:
                        Console.WriteLine("Exiting program. Goodbye !");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
