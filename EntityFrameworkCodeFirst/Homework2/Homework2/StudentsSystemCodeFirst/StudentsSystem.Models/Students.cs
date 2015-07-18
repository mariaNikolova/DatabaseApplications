using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    public class Students
    {
        private int id;
        private string name;
        private string phoneNumber;
        private DateTime registrationDate;
        private DateTime birthday;

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime Birthday { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }


    }
}
