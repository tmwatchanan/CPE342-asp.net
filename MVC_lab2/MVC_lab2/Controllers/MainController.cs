using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_lab2.Models;
using MVC_lab2.ViewModels;

namespace MVC_lab2.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult GetView()
        {
            StudentListViewModel studentListViewModel = new StudentListViewModel();
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>();

            StudentBusinessLayer studentBal = new StudentBusinessLayer();
            List<Student> students = studentBal.GetStudents();

            foreach (Student student in students)
            {
                StudentViewModel studentViewModel = new StudentViewModel();
                studentViewModel.Name = student.FirstName + " " + student.LastName;
                studentViewModel.Year = student.Year;
                switch (student.Year)
                {
                    case "Freshman":
                    case "Sophomore":
                    case "Junior":
                    case "Senior":
                        break;
                    default:
                        studentViewModel.YearTextColor = "white";
                        studentViewModel.YearBackgroundColor = "red";
                        break;
                }
                studentViewModels.Add(studentViewModel);
            }
            studentListViewModel.Students = studentViewModels;
            return View("GetView", studentListViewModel);
        }
    }
}