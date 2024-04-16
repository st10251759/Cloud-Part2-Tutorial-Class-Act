namespace StudentApp.Models
{
    public class Student
    {
        //Table elementsa to include
        //need to public to access from all tables
        public int StudentId { get; set; }
        //String is mean't to be nullable to build database 
        public string? StudentName { get; set;}
        public int Age { get; set;}
    }
}
