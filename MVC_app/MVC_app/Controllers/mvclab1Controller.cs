using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_app.Models; /*IMPORTANT*/

namespace MVC_app.Controllers
{
    public class mvclab1Controller : Controller
    {
        public ActionResult GetMyStudentInfo()
        {
            //ViewData
            MyStudentInfo myStudent1 = new MyStudentInfo(); /*Need using*/
            myStudent1.Name = "Watchanan";
            myStudent1.Surname = "Chantapakul";
            myStudent1.StudentCode = "570610601";
            ViewData["MyStudentInfo"] = myStudent1;
            return View("GetMyStudentInfoView");
        }
    }
}