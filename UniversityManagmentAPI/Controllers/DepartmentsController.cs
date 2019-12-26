using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Models;

namespace UniversityManagmentAPI.Controllers
{
    public class DepartmentsController : ApiController
    {
        private DepartmentManager _departmentManager;

        public DepartmentsController()
        {
            _departmentManager = new DepartmentManager();
        }

        // GET: api/Departments
        public IEnumerable<Department> Get()
        {
            return _departmentManager.GetAllDepartment();
        }

        // GET: api/Departments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Departments
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Departments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Departments/5
        public void Delete(int id)
        {
        }
    }
}
