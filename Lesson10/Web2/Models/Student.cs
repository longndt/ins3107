namespace Web2.Models
{
    //class name => table name
    public class Student
    {
        //attribute name => column name
        public int Id { get; set; } //primary key, auto increment
        public string Name { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
    }
}
