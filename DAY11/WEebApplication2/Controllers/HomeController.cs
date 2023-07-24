using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        Entities1 db = new Entities1();
        public ActionResult Index()
        {
            ViewBag.PageName = "Home";
            var allEmployees = db.Emps.ToList();

            return View(allEmployees);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddRecord(Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }

        public ActionResult Delete(int id)
        {
            Emp emp = db.Emps.Find(id);
            db.Emps.Remove(emp);
            db.SaveChanges();

            return Redirect("/Home/Index");
        }
        public ActionResult Edit(int id)
        {
            Emp emp = db.Emps.Find(id);

            return View(emp);
        }
        public ActionResult UpdateRecord(Emp emp)
        {
            Emp empToBeUpdated = db.Emps.Find(emp.No);
            empToBeUpdated.Name = emp.Name;
            empToBeUpdated.Address = emp.Address;
            db.SaveChanges();
            return Redirect("/Home/Index");
            //return RedirectToAction("Home", "Index");
        }
    }
}