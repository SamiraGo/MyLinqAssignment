using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq.Models
{
    public class Course
    {
        public Course()
        {
        }
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public ICollection<Student_Course> Student_Courses { get; set; }
        public ICollection<Teacher_Course> Teacher_Courses { get; set; }

    }

}
