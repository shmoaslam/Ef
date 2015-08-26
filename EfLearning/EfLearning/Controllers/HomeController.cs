using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfLearning.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private DepartmentService _departmentService;
        private EmployeeService _employeeService;

        public HomeController()
        {
            _departmentService = new DepartmentService();
            _employeeService = new EmployeeService();
        }

        public ActionResult Index()
        {
            //var data = _employeeService.GetEmployeeByDepartmentId(1);
            //var data1 = _departmentService.GetAllDepartment();
            var data2 = _departmentService.GetDepartmentById(1);
            return View();
        }
    }
}