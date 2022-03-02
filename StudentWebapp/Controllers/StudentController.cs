using Microsoft.AspNetCore.Mvc;
using StudentWebapp.Context;
using StudentWebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebapp.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbcontext _db;
        public StudentController(StudentDbcontext db)
        {
            _db = db;
        }
        public IActionResult create()
        {
            var list = new List<string>() { "BCA","MCA","BCOM","MCOM","BBA","MBA" };
            ViewBag.list = list;
           
            return View();
        }
        [HttpPost]
        public IActionResult create(Student std)
        {
            var list = new List<string>() { "BCA", "MCA", "BCOM", "MCOM", "BBA", "MBA" };
            ViewBag.list = list;
            if (ModelState.IsValid)
            {
               /* TempData["id"] = std.id;*/
              
                TempData["name"] = std.Firstname;
                TempData["lname"] = std.LastName;
                TempData["Email"] = std.Email;
                TempData["Mobile"] = std.Mobile;
                TempData["Gender"] = std.gender;
                TempData["City"] = std.City;
                TempData["Address"] = std.Address;
                TempData["Course"] = std.Course;
                TempData["Fees"] = std.Fees;
                TempData.Keep();
                /*_db.tblstudent.Add(std);
                _db.SaveChanges();*/
                ModelState.Clear();
                return View();
            }
            return View();
        }
      /*  public IActionResult Index()
        {
        *//*    var db = _db.tblstudent.ToList();*//*
            ViewBag.show = TempData["id"];
            var list = new List<string>() { "BCA", "MCA", "BCOM", "MCOM", "BBA", "MBA" };
            ViewBag.list = list;
            return View("create");
        }*/
    }
}
