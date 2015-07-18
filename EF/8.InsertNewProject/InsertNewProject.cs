using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.InsertNewProject
{
    using EF;

    class InsertNewProject
    {
        public static int CreateNewProject(string Name, string Description, DateTime StartDate, DateTime EndDate)
        {
            var softUniEntities = new SoftUniEntities();
            var newProject = new Project
            {
                Name = Name,
                Description = Description,
                StartDate = StartDate,
                EndDate = EndDate
            };

            softUniEntities.Projects.Add(newProject);
            softUniEntities.SaveChanges();

            return newProject.ProjectID;
        }
    }
}
