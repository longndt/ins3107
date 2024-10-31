using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a list of student with different values for Name & Mark
            List<Student> students = new List<Student>
                {
                    new Student { Name = "Alice", Mark = 90, Gender = "Female" },
                    new Student { Name = "Bob", Mark = 80, Gender = "Male"},
                    new Student { Name = "Charlie", Mark = 85, Gender = "Male" },
                    new Student { Name = "David", Mark = 92, Gender = "Male" },
                };
            //Student demo = new Student();
            //demo.Name = "demo name";
            //demo.Mark = 100;

            //students.Add(demo);


            //Question: Display list of students whose Mark >= 85 and Gender is Male
            //1st solution: Without LINQ
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Mark >= 85 && students[i].Gender == "male")
                        Console.WriteLine(students[i].Name + " : " + students[i].Mark);
            }

            //foreach (var student in students) {
            //    if (student.Mark >= 85)
            //        Console.WriteLine(student.Name);
            //}

            //2nd solution: With LINQ (Language Integrated Query)
            var highscorer = from student in students
                             where student.Mark >= 85
                             && student.Gender.Equals("Male")
                             select student;

            foreach (var student in highscorer)
            {
                Console.WriteLine(student.Name + " scored " + student.Mark);
            }
        }
    }
}
