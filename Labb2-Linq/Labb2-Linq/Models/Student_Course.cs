using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq.Models
{
    public class Student_Course
    {
        public int Student_CourseId { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public int StudentId { get; set; }
        public Student Students { get; set; }
    }
}
