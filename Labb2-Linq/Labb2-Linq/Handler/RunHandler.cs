using Labb2_Linq.Context;
using Labb2_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2_Linq.Handler
{
    public class RunHandler
    {
        public static void RunMyApp()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n---------------***Welcome to the School application***--------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  \n Please choose one of these options you want!" +
                             "\n\n  1.Get all the teachers who teach Programming One. " +
                             "\n  2.Get all Students with their teachers." +
                             "\n  3.Get all Students and teachers for Programming one" +
                             "\n  4.Edit Course name" +
                             "\n  5.Edit Teacher's name for Programming One" +
                             "\n  6.Exit the application");

                string Chosenoption = Console.ReadLine();

                int option = int.Parse(Chosenoption);


                switch (option)
                {
                    case 1:
                        GetTAllTeachersForProOne();
                        break;
                    case 2:
                        GetAllStudentsWhithTeachers();
                        break;
                    case 3:
                        GetStudentsWithTeacherForProOne();
                        break;
                    case 4:
                        EditCourseName();
                        break;
                    case 5:
                        EditTeachersName();
                        break;
                    case 6:
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid input");
                Console.ReadLine();
                Console.Clear();
                RunMyApp();
            }
        }


        public static void GetTAllTeachersForProOne()
        {
            try
            {
                using (var db = new SchoolDbContext())
                {

                    var programmingOne = from a in db.Teacher_Courses
                                         join t in db.Teachers
                                         on a.TeacherId equals t.TeacherId
                                         where a.CourseId == 4
                                         select new
                                         {
                                             TName = t.TeacherName
                                         };


                    foreach (var item in programmingOne)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Mr. {item.TName}");
                    }
                }
                BackToMainMenu();
            }


            catch (Exception)
            {

                throw;
            }
        }

        public static void GetAllStudentsWhithTeachers()
        {
            try
            {
                using (var db = new SchoolDbContext())
                {

                    {
                        var studentTeacherList = from a in db.Students
                                                 join b in db.Classrooms on a.ClassroomId equals b.ClassroomId
                                                 join e in db.Courses on b.ClassroomId equals e.CourseId
                                                 join d in db.Teachers on e.CourseId equals d.TeacherId
                                                 orderby a.StudentName ascending
                                                 select new
                                                 {
                                                     StName = a.StudentName,

                                                     TchrName = d.TeacherName,

                                                     Subject = e.CourseName,
                                                 };
                        foreach (var item in studentTeacherList)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Student :{item.StName}  Teacher:{item.TchrName}");
                        }
                    }
                }
                BackToMainMenu();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void GetStudentsWithTeacherForProOne()
        {
            try
            {
                using (var db = new SchoolDbContext())
                {
                    var StudentTeacherProOne = from st in db.Students
                                               join s in db.Student_Courses on st.StudentId equals s.StudentId
                                               from t in db.Teachers
                                               join tc in db.Teacher_Courses on t.TeacherId equals tc.TeacherId
                                               where s.CourseId == 4 && tc.CourseId == 4

                                               select new
                                               {
                                                   SName = st.StudentName,
                                                   Tname = t.TeacherName
                                               };
                    foreach (var item in StudentTeacherProOne)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Student :{item.SName}  Teacher:{item.Tname}");
                    }
                }
                BackToMainMenu();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EditCourseName()
        {
            try
            {
                using (var db = new SchoolDbContext())
                {
                    var editCourseName = db.Courses.Where(c => c.CourseName == "Programming 1").FirstOrDefault();

                    bool condition = true;

                    if (condition)
                    {
                        editCourseName.CourseName = "OOP";
                    }

                    db.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Done! Check your database");
                }
                BackToMainMenu();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EditTeachersName()
        {
            try
            {
                using (var db = new SchoolDbContext())
                {
                    var tName = db.Teacher_Courses.Where(t => t.TeacherId == 1).FirstOrDefault();

                    if (true)
                    {
                        tName.TeacherId = 2;
                    }
                    db.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Database is updated.");
                }
                BackToMainMenu();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ExitApplication()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Thank you! GoodBye");
            Console.ReadLine();
            Environment.Exit(0);
            
            
        }

        public static void BackToMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nPress any button to go back to main menu.");
            Console.ReadKey();
            Console.Clear();
            RunMyApp();
        }
    }
}
