using DataModel.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service
{
    public class EmployeeService
    {

        EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public List<EmployeeModel> GetEmployeeByDepartmentId(int departmentId)
        {
            List<EmployeeModel> result = new List<EmployeeModel>();
            List<Employee> dataResult = new List<Employee>();
            dataResult = _employeeRepository.GetEmployeeByDepartmentId(departmentId);
            //if (dataResult != null && dataResult.Count() > 0)
            //    result = EmplyeeConverter.Convert(dataResult);
            return result;
        }
    }
}
