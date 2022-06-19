using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelPractice.Models;

namespace ModelPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var data = GetEmployee();
            Employee emp = new Employee()
            {
                Id = 1,
                Address = "badlapur",
                Name = "Siddhesh"
            };
            return View(emp);
        }

        //private Employee GetEmployee()
        //{
        //    return new Employee()
        //    {
        //        Id = 1,
        //        Address = "India",
        //        Name = "Siddhesh"
        //    };
        //}
    }
}