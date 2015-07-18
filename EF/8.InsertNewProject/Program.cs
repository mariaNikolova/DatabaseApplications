using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.InsertNewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertNewProject.CreateNewProject("C# Project", "Team Project", new DateTime(2015, 01, 01), DateTime.Now);
            Console.WriteLine("Created new project.");
        }
    }
}
