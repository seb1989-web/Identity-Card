using Identity_Card.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Identity_Card.Controllers
{
    public class PersonsController : Controller
    {
        public DbConnection db;
        public PersonsController()
        {
            this.db = new DbConnection();
        }
        // GET: Persons
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPerson(PersonDetails person, HttpPostedFileBase fileBase)
        {
            string path = Path.Combine(Server.MapPath("~/image"), Path.GetFileName(fileBase.FileName));
            fileBase.SaveAs(path);
            person.Photo = "~/image/" + fileBase.FileName;
            db.Person.Add(person);
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("GetPersons", "Persons");
        }
        [HttpGet]
        public ActionResult GetPersons()
        {
            var persons = from p in db.Person
                          select p;
            return View(persons);
        }
        public ActionResult Edit(int id)
        {
            var query = db.Person.Find(id);
            return View(query);
        } 
        
        [HttpPost]
        public ActionResult EditPerson(PersonDetails person, HttpPostedFileBase fileBase)
        {
            string path = Path.Combine(Server.MapPath("~/image"), Path.GetFileName(fileBase.FileName));
            fileBase.SaveAs(path);
            person.Photo = "~/image/" + fileBase.FileName;
            db.Entry(person).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GetPersons");
        }
        public ActionResult Delete(int id)
        {
            var person = db.Person.Find(id);
            db.Person.Remove(person);
            db.SaveChanges();
            return RedirectToAction("GetPersons");
        }

    }
}