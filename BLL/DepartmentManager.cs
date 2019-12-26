using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class DepartmentManager
    {
        private ProjectDbContext _db;

        public DepartmentManager()
        {
            _db= new ProjectDbContext();
        }

        public List<Department> GetAllDepartment()
        {
           return _db.Departments.ToList();
        }

        public bool SaveDepartment(Department deartment)
        {
            _db.Departments.Add(deartment);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
                return true;
            return false;
        }
    }
}
