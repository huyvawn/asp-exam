using System.Collections.Generic;
using System.Web.Mvc;
using EmployeeManager.Models;

namespace EmployeeManager.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { EmployeeID = "EM001", EmployeeName = "Jonh Carter", Department = "HR", Salary = 3000 },
            new Employee { EmployeeID = "EM002", EmployeeName = "Michael Bean", Department = "SC", Salary = 1300 },
            new Employee { EmployeeID = "EM003", EmployeeName = "Jimmy Floy", Department = "MD", Salary = 2000 },
            new Employee { EmployeeID = "EM004", EmployeeName = "Mary Brown", Department = "MD", Salary = 2000 }
        };

        public ActionResult Index()
        {
            return View(Employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employees.Add(emp);
                    return RedirectToAction("Index");
                }
                return View(emp);
            }
            catch
            {
                ViewBag.Error = "Error occurred while adding employee.";
                return View(emp);
            }
        }
    }
}