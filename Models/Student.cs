﻿using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        [Key] public int StudentId { get; set; }
        //String is mean't to be nullable to build database 
        public string? StudentName { get; set; }
        public int? Age { get; set; }
        //Navigate to enrollments
        public List<Enrollment>? Enrollments { get; set; }

    }
}
