using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_lab2.Models;

namespace MVC_lab2.Models
{
    public class StudentBusinessLayer
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.FirstName = "Watchanan";
            student1.LastName = "Chantapakul";
            student1.Year = "Junior";
            students.Add(student1);

            Student student2 = new Student();
            student2.FirstName = "Tananut";
            student2.LastName = "Panyagosa";
            student2.Year = "Third";
            students.Add(student2);

            Student student3 = new Student();
            student3.FirstName = "Rattapon";
            student3.LastName = "Kaewpinjai";
            student3.Year = "Freshman";
            students.Add(student3);

            students.Add(new Student() { FirstName = "Tana", LastName = "Tha", Year = "Senior" });
            students.Add(new Student() { FirstName = "Thatchai", LastName = "Chuaubon", Year = "Cnior"});
            students.Add(new Student() { FirstName = "Bhurivat", LastName = "Montri", Year = "Pper" });
            students.Add(new Student() { FirstName = "Thatchapon", LastName = "Wongsri", Year = "Sophomore" });
            students.Add(new Student() { FirstName = "Nuchawee", LastName = "Wiengya", Year = "SOphomore" });

            return students;
        }
    }
}