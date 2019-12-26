using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DAL.Seeds;

namespace DAL
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext():base("name = UniversityApiDB")
        {
            Database.SetInitializer<ProjectDbContext>(new SemesterInitializerSeed<ProjectDbContext>());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
