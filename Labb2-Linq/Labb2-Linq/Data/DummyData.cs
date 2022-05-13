using Labb2_Linq.Context;
using Labb2_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Linq.Data
{
    public class DummyData
    {
        public static void StartMyApp()
        {
            using SchoolDbContext context = new SchoolDbContext();
            {
                //Add Classrooms
                if (!context.Classrooms.Any())
                {
                    context.Classrooms.AddRange(new List<Classroom>()
                    {
                        new Classroom(){ ClassroomName = "3A"},
                        new Classroom(){ ClassroomName = "5B"},
                        new Classroom(){ ClassroomName = "7C"},
                        new Classroom(){ ClassroomName = "1A"},
                    });

                    context.SaveChanges();
                }

                //Add Courses
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course(){ CourseName = "Programming 1"},
                        new Course(){ CourseName = "Programming 2"},
                        new Course(){ CourseName = "SQL"},
                        new Course(){ CourseName = "ASP .Net"},

                    });

                    context.SaveChanges();
                }

                //Add Students
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student(){ StudentName ="Samira Ekberg", ClassroomId = 1},
                        new Student(){ StudentName ="Ilian Lundberg", ClassroomId = 2},
                        new Student(){ StudentName ="Stella Stenberg", ClassroomId = 3},
                        new Student(){ StudentName ="Elliot Stenberg", ClassroomId = 4},


                    });

                    context.SaveChanges();
                }

                //Add Teachers
                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher() { TeacherName = "Tobias Landén" },
                        new Teacher() { TeacherName = "Reidar Nilsen" },
                        new Teacher() { TeacherName = "Anas Alhussain" },
                    });
                    context.SaveChanges();
                }

                //Fill Bridge table
                if (!context.Student_Courses.Any())
                {
                    context.Student_Courses.AddRange(new List<Student_Course>()
                    {
                        new Student_Course() { StudentId = 1, CourseId = 3},
                        new Student_Course() { StudentId = 2, CourseId = 1},
                        new Student_Course() { StudentId = 3, CourseId = 4},
                        new Student_Course() { StudentId = 4, CourseId = 2},
                       

                    });
                    context.SaveChanges();
                }

                if (!context.Teacher_Courses.Any())
                {
                    context.Teacher_Courses.AddRange(new List<Teacher_Course>()
                    {
                        new Teacher_Course() { TeacherId = 1, CourseId = 2},
                        new Teacher_Course() { TeacherId = 2, CourseId = 4},
                        new Teacher_Course() { TeacherId = 3, CourseId = 1},
                        new Teacher_Course() { TeacherId = 3, CourseId = 3},

                        
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
