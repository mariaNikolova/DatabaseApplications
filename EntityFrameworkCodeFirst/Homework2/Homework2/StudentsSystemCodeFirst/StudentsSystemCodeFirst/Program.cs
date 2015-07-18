using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystemCodeFirst.ConsoleClient
{
    using StudentsSystem.Data;
    using StudentsSystem.Models;
    using System.Data.Entity;
    using StudentsSystem.Data.Migrations;

    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsSystemDbContext, Configuration>());
            var db = new StudentsSystemDbContext();
            
            db.Students.Add(new Students
            {
                Name = "Georgi",
                PhoneNumber = "089712345",
                RegistrationDate = new DateTime(2015, 01, 02),
                Birthday = new DateTime(2015, 10, 02)
            });
            db.SaveChanges();
           
            db.Courses.Add(new Courses
            {
                Name = "Uvod v C#",
                Description = "Za nachinaeshti",
                StartDate = new DateTime(2015,01,23),
                EndDate = new DateTime(2015,04,23),
                Price = 100
            });


            db.SaveChanges();
            
            db.Courses.Add(new Courses
            {
                Name = "Uvod v C++",
                Description = "Za nachinaeshti",
                StartDate = new DateTime(2015, 01, 23),
                EndDate = new DateTime(2015, 04, 23),
                Price = 150
            });
            db.SaveChanges();

            db.Courses.Add(new Courses
            {
                Name = "Uvod v JavaScript",
                Description = "Za nachinaeshti",
                StartDate = new DateTime(2015, 01, 23),
                EndDate = new DateTime(2015, 04, 23),
                Price = 200
            });
            db.SaveChanges();
           
            db.Homeworks.Add(new Homework
            {
                Content = "homework nomer 1",
                HomeworkContentType = ContentType.application,
                DateAndTime = new DateTime(2015,01,02),
                StudentId = 1,
                CoursesId = 2
            });
            db.SaveChanges();
            
            db.Homeworks.Add(new Homework
            {
                Content = "homework nomer 2",
                HomeworkContentType = ContentType.pdfOrApplication,
                DateAndTime = new DateTime(2015, 04, 02),
                StudentId = 2,
                CoursesId = 2
              
            });
            db.Homeworks.Add(new Homework
            {
                Content = "homework nomer 3",
                HomeworkContentType = ContentType.zip,
                DateAndTime = new DateTime(2015, 01, 23),
                StudentId = 3,
                CoursesId = 3
            });
            db.SaveChanges();

            db.Resources.Add(new Resources
            {
                Name = "knigi za programirane",
                Resource = TypeOfResource.other,
                Link = "wwww.azSiZnamVsichko.com"
            });
            db.SaveChanges();

            db.Resources.Add(new Resources
            {
                Name = "interner",
                Resource = TypeOfResource.document,
                Link = "wwww.azSiZnamVsichko.com"
            });
            db.SaveChanges();
        }
    }
}
