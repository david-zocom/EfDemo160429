using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoConsole.Models;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to school");
            SchoolContext context = new SchoolContext();
            int count = context.Students.Count();
            Console.WriteLine("There are " + count + " students");

            if (count == 0)
            {
                Address address1 = new Address() { Email = "1", StreetAddress = "" };
                Address address2 = new Address() { Email = "2", StreetAddress = "" };
                Course c1 = new Course() { Name = "Charms" };
                Student s1 = new Student()
                {
                    Name = "Harry",
                    CurrentCourse = c1,
                    Address = address1,
                    AlternativeAddress = address2
                };
                Student s2 = new Student()
                {
                    Name = "Hermione",
                    CurrentCourse = c1,
                    Address = address1,
                    AlternativeAddress = address2
                };

                context.Students.Add(s1);
                context.Students.Add(s2);
                context.Courses.Add(c1);

                context.SaveChanges();
            }

            // Explicit loading
            var harrys = context.Students.Where(s => s.Name == "Harry");
            if (harrys.Count() > 0)
                context.Entry(harrys.First())
                    .Reference("CurrentCourse")
                    .Load();
            
            // Eager loading
            var students = context.Students
                .Include("CurrentCourse")
                .ToList();


            Student student = students.FirstOrDefault();
            context.Dispose();
            // Genom att stänga databasen kan vi se om Student.CurrentCourse
            // har lästs in från databasen - student.CurrentCourse
            // är null om den inte lästs in

            Console.WriteLine("Student: " + student.Name);
            Console.WriteLine("Course: " + student.CurrentCourse.Name);
            
            Console.WriteLine("Program done");
            Console.ReadLine();
        }
    }
}
