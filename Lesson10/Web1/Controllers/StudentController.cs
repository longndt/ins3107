using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //URL: localhost:PORT/Student/List
        public IActionResult List()
        {
            //Declare a list of Student (using Student model)
            List<Student> students = new List<Student>()
            {
                new Student ()
                {
                    Name = "Minh",
                    Age = 20,
                    Image = "https://i0.wp.com/rollercoasteryears.com/wp-content/uploads/Thrive-During-Finals-.jpg?fit=1000%2C667&ssl=1"
                },
                new Student ()
                {
                    Name = "Tuan",
                    Age = 21,
                    Image = "https://www.theamericanacademy.com/cdn/shop/articles/1154551314197032.w2jwTajEFOv5KmkfpDWz_height640_800x.png?v=1576868846"
                },
                new Student ()
                {
                    Name = "Phuong",
                    Age = 19,
                    Image = "https://media.istockphoto.com/id/1365601848/photo/portrait-of-a-young-woman-carrying-her-schoolbooks-outside-at-college.jpg?s=612x612&w=0&k=20&c=EVxLUZsL0ueYFF1Nixit6hg-DkiV52ddGw_orw9BSJA="
                },
                   new Student ()
                {
                    Name = "Phuong",
                    Age = 19,
                    Image = "https://media.istockphoto.com/id/1365601848/photo/portrait-of-a-young-woman-carrying-her-schoolbooks-outside-at-college.jpg?s=612x612&w=0&k=20&c=EVxLUZsL0ueYFF1Nixit6hg-DkiV52ddGw_orw9BSJA="
                },
                      new Student ()
                {
                    Name = "Phuong",
                    Age = 19,
                    Image = "https://media.istockphoto.com/id/1365601848/photo/portrait-of-a-young-woman-carrying-her-schoolbooks-outside-at-college.jpg?s=612x612&w=0&k=20&c=EVxLUZsL0ueYFF1Nixit6hg-DkiV52ddGw_orw9BSJA="
                },
                         new Student ()
                {
                    Name = "Phuong",
                    Age = 19,
                    Image = "https://media.istockphoto.com/id/1365601848/photo/portrait-of-a-young-woman-carrying-her-schoolbooks-outside-at-college.jpg?s=612x612&w=0&k=20&c=EVxLUZsL0ueYFF1Nixit6hg-DkiV52ddGw_orw9BSJA="
                },
                            new Student ()
                {
                    Name = "Phuong",
                    Age = 19,
                    Image = "https://media.istockphoto.com/id/1365601848/photo/portrait-of-a-young-woman-carrying-her-schoolbooks-outside-at-college.jpg?s=612x612&w=0&k=20&c=EVxLUZsL0ueYFF1Nixit6hg-DkiV52ddGw_orw9BSJA="
                }
            };

            //Path: Views/Student/List.cshtml
            //method 4: pass data from Controller to View using model
            return View(students);
        }
    }
}
