using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using WebAPI_OWN.Models;

namespace WebAPI_OWN.Controllers
{
    public class EmployeesController : WEBAPIController
    {
        Employee[] employees = new Employee[]
               {
                    new Employee{ID = 1, Name = "Abhishek", Address = "Wgl", Age = 26, DateOfJoining = DateTime.Parse("27/11/2011")},
                    new Employee{ID = 2, Name = "Raghu", Address = "Hyd", Age = 27, DateOfJoining = DateTime.Parse("7/02/1997")},
                    new Employee{ID = 3, Name = "Virat", Address = "Benguluru", Age = 28, DateOfJoining = DateTime.Parse("27/10/1999")}
               };
        // GET: Employees
        public IEnumerable<Employee> GetEmployees()
        {
           
            return employees;
        }
        public IHttpActionResult GetEmployee(int id)
        {

            var a = employees.FirstOrDefault(x => x.ID == id);
            if (a == null)
            {
                return NotFound();
            }
            return Ok(a);
        }
    }

}