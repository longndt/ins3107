//Program.cs : the runnable file

//Use constructor to create new object
//object: class instance
using OOP1;

public class Demo
{
    public static void Main()
    {
        //student1 is created by parameterless constructor
        Student student1 = new Student();
        //student2 is created by paramterized constructor
        Student student2 = new Student(123, "Tien Hung", "tienhung@gmail.com", 7.5);

        student1.setId(888);
        student1.setName("Minh Hang");
        //override GPA value for student 1
        student1.setGPA(9.5);

        //display object detail
        Console.WriteLine("STUDENT 1");
        student1.displayStudentDetail();
        //Console.WriteLine(student2.getName());
        //Console.WriteLine(student2.getGpa());
        Console.WriteLine("STUDENT 2");
        student2.displayStudentDetail();
    }
}

