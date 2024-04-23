namespace StudentApp.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int? CourseId { get; set; }

        public int? StudentId { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        // Navigation properties

        public Course? Course { get; set; }

        public Student? Student { get; set; }

    }
}
