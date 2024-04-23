namespace StudentApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }

        public List<Enrollment>? Enrollments { get; set; }

    }
}
