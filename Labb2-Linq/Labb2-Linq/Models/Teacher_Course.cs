using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq.Models
{
    public class Teacher_Course
    {
        public int Teacher_CourseId { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }

    }
}
