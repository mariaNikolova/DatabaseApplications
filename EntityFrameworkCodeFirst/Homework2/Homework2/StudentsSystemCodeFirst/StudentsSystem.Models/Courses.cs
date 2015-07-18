using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    public class Courses
    {
        private int id;
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private decimal price;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal  Price { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Resources> Resources { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }

    }
}
