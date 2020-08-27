using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DemoMvc.Models
{
    public class Employee
    {

        public int Emp_id { get; set; }

        public string Emp_Name  { get; set; }

        public string  Gender { get; set; }

        public string City { get; set; }

    }
}