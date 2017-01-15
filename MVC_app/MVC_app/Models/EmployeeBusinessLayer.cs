using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_app.DataAccessLayer;

namespace MVC_app.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            //Use Data Access Layer
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();

            //List<Employee> employees = new List<Employee>();

            //Employee emp = new Employee();
            //emp.FirstName = "Johnson";
            //emp.LastName = "Fernades";
            //emp.Salary = 14000;
            //employees.Add(emp);

            //Employee emp2 = new Employee();
            //emp2.FirstName = "Super";
            //emp2.LastName = "Man";
            //emp2.Salary = 24000;
            //employees.Add(emp2);

            //Employee emp3 = new Employee();
            //emp3.FirstName = "Doctor";
            //emp3.LastName = "Strange";
            //emp3.Salary = 5555;
            //employees.Add(emp3);

            //Employee emp4 = new Employee();
            //emp4.FirstName = "Steve";
            //emp4.LastName = "Jobs";
            //emp4.Salary = 456789;
            //employees.Add(emp4);

            //Employee emp5 = new Employee();
            //emp5.FirstName = "Cat";
            //emp5.LastName = "Dog";
            //emp5.Salary = 140;
            //employees.Add(emp5);

            //return employees;
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal=  new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
    }
}