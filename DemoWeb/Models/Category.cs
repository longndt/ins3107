using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace DemoWeb.Models
{
    //Relationship: 1 Category - many Laptop

    //model "Category" => table "Category"
    public class Category
    {
        public int Id { get; set; }  //primary key
        public string Name { get; set; } 
        public string Description { get; set; }

        //used for feature: filter laptops by category
        public ICollection<Laptop> Laptops { get; set; }
    }
}
