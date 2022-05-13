using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb2_Linq.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        //[ForeignKey("ClassroomId")]
        public int ClassroomId { get; set; }

        public ICollection<Student_Course> Student_Courses { get; set; }
    }
}
