using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_app.Models;
using MVC_app.ViewModels;

namespace MVC_app.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult GetEmployeeView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            //ViewData
            //ViewData["Employee"] = emp;

            //ViewBag
            //ViewBag.Employee = emp;
            //return View("EmployeeView");

            //Strongly typed view
            //return View("EmployeeView", emp);

            //ViewModel
            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }
            //vmEmp.Username = "Admin";
            return View("EmployeeView", vmEmp);
        }
    }
}