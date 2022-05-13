using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2_Linq.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
