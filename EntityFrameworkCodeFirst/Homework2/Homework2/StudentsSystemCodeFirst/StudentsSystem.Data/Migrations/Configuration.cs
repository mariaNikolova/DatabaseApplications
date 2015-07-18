namespace StudentsSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentsSystem.Models;
    using System.Data.Entity.Migrations.Infrastructure;

    public sealed class Configuration : DbMigrationsConfiguration<StudentsSystem.Data.StudentsSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentsSystem.Data.StudentsSystemDbContext";
        }

        protected override void Seed(StudentsSystem.Data.StudentsSystemDbContext context)
        {
           
            var student = new Students
            {
                Name = "Ivan",
                PhoneNumber = "098765421",
                RegistrationDate = new DateTime(2015, 01, 10),
                Birthday = new DateTime(1994, 04, 23)
            };
            context.Students.Add(student);
            context.SaveChanges();
            
            var homework = new Homework
            {
                Content = "Homework for c#",
                HomeworkContentType = ContentType.zip,
                DateAndTime = new DateTime(2015,03,08),
                StudentId = 1,
                CoursesId = 2
            };
            context.Homeworks.Add(homework);
            context.SaveChanges();

            var courses = new Courses
            {
                Name = "JavaScript za naprednali",
                Description = "kurs za naprednali",
                StartDate = new DateTime(2015, 01, 03),
                EndDate = new DateTime(2015, 04, 24)
            };

           
        }
    }
}
