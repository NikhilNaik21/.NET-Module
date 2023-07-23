using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        List<Employee> lst = new List<Employee>()
        {
            new Employee() { Id=1, Name = "Nikhil" , Address = "Nashik"},
            new Employee() { Id=2, Name = "Prajwal" , Address = "Satana"},
            new Employee() { Id=3, Name = "Mohit" , Address = "Jalgaon"},
        };
        public ActionResult Index()
        {
            return View("ViewHome",lst);
        }
    }
}