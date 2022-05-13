using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq.Models
{
   public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

        public ICollection<Teacher_Course> Teacher_Courses { get; set; }
    }
}
