using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Seeds
{
    class SemesterInitializerSeed<T>: CreateDatabaseIfNotExists<ProjectDbContext>
    {
        protected override void Seed(ProjectDbContext context)
        {
            List<Semester> semesters = new List<Semester>();
            semesters.Add(new Semester(){Name = "Sem-1",});
            semesters.Add(new Semester(){Name = "Sem-2",});
            semesters.Add(new Semester(){Name = "Sem-3",});
            semesters.Add(new Semester(){Name = "Sem-4",});
            semesters.Add(new Semester(){Name = "Sem-5",});
            semesters.Add(new Semester(){Name = "Sem-6",});
            semesters.Add(new Semester(){Name = "Sem-7",});
            semesters.Add(new Semester(){Name = "Sem-8",});

            foreach (Semester semester in semesters)
            {
                context.Semesters.Add(semester);
            }
            base.Seed(context);
        }
    }
}
