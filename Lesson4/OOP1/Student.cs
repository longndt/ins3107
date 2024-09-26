using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //OOP Class
    internal class Student
    {
        //1. Attributes (Properties, Variables)
        //information-hiding rule: always set attributes as "private"
        private int id;
        private string name;
        private string email;
        private double gpa;

        //2. Methods (Functions)
        //2.1 Constructors
        //2.1.1 Parameterless constructor (empty constructor)
        public Student() {
            gpa = 5.0;  //set default (initial value)
        }
        //2.1.2 Parameterized constructor
        public Student (int id, string name, string e, double g)
        {
            //we use "this" keyword to clarify the variable name
            //and parameter name if they are similar
            this.id = id;
            this.name = name;
            //no need to use "this" keyword if variable name
            //and parameter name are different
            email = e;
            gpa = g;
        }
        //2.2 Getter (READ)
        public string getName()
        {
            return name;
        }
        public double getGpa()
        {
            return gpa;
        }

        //2.3 Setter (WRITE)
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setGPA (double gpa)
        {
            this.gpa = gpa;
        }

        //2.4 Custom (User-defined) methods
        public void displayStudentDetail()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("GPA: " + gpa);
        }
    }
}
