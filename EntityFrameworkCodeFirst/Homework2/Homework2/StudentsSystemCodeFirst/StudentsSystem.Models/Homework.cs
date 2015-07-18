using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    public class Homework
    {
        private int id;
        private string content;
        private ContentType homeworkContentType;
        private DateTime dateAndTime;

        public int Id{ get; set; }
        public string Content { get; set; }
        public ContentType HomeworkContentType { get; set; }
        public DateTime DateAndTime { get; set; }

        public int CoursesId { get; set; }
        public virtual Courses Courses { get; set; }

        public int StudentId { get; set; }
        public virtual Students Student { get; set; }


    }
}
