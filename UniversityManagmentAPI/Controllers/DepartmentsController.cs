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
            var data = _departmentManager.GetAllDepartment();
            return data;
        }

        // GET: api/Departments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Departments
        public HttpResponseMessage Post([FromBody]Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentManager.SaveDepartment(department);
                    var message = Request.CreateResponse(HttpStatusCode.Created, department);
                    message.Headers.Location = new Uri(Request.RequestUri + department.DepartmentId.ToString());
                    return message;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
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
