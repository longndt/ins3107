namespace DemoWeb.Models
{
    //many laptops - 1 category
    public class Laptop
    {
        public int Id { get; set; }   //PK: primary key
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; } //FK: foreign key
        //used for feature: display category infor for a laptop
        public Category Category { get; set; }  
    }
}