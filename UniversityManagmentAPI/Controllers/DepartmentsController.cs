﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UniversityManagmentAPI.Controllers
{
    public class DepartmentsController : ApiController
    {
        // GET: api/Departments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
