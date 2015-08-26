using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service.Converter
{
   public static class EmployeeConverter
    {
       public static EmployeeModel Convert(Employee employee)
       {
           EmployeeModel employeeModel = new EmployeeModel();
           if (employee != null)
           {
               employeeModel.Name = employee.Name;
               employeeModel.Email = employee.Email;
               employeeModel.DepartmentId = employee.DepartmentId;
           }
           return employeeModel;
       }

       public static List<EmployeeModel> Convert(List<Employee> employeeList)
       {
           List<EmployeeModel> employeeModelList = new List<EmployeeModel>();
           if (employeeList != null && employeeList.Count() > 0)
           {
               foreach (var employee in employeeList)
               {
                   if (employee != null)
                       employeeModelList.Add(Convert(employee));
               }
           }
           return employeeModelList;
       }
    }
}
