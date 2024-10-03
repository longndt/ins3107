using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism1
{
    internal class Student : Person
    {
        private int studentId;
        private string studentEmail;

        public Student (string name, int age, string address, int studentId, string studentEmail) : base (name, age, address)
        {
            this.studentId = studentId;
            this.studentEmail = studentEmail;
        }

        //override a method in parent class using "override" keyword
        public override void showInfo()
        {
            base.showInfo();  //reuse code in method from parent
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Email: " + studentEmail);
        }
    }
}
