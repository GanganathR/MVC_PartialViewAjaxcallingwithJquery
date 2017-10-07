using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialView_AjaxCalling_Jquerry.Models;
namespace PartialView_AjaxCalling_Jquerry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Partial View listing 

        public ActionResult List()
        {
            StudentEntities db = new StudentEntities();
            return View();
        }

        [HttpGet]
      //  Get Number of Count
        public ActionResult ListPart(int id)
        {
            StudentEntities db = new StudentEntities();
            var studentList = db.Students.Take(id);
            return PartialView(studentList);
        }

    }
}