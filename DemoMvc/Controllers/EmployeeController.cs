using DemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntities employeeEntities = new EmployeeEntities();


        // GET: Employee
        public ActionResult Index()
        {
            //Employee employee = new Employee();

           var data =  employeeEntities.EmployeeDetails.ToList();

            return View(data);
        }
    }
}