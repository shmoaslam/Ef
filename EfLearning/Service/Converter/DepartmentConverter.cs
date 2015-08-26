using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service.Converter
{
    public static class DepartmentConverter
    {
        public static List<DepartmentModel> Convert(List<Department> departmentList)
        {
            List<DepartmentModel> departmentModelList = new List<DepartmentModel>();
            if(departmentList != null && departmentList.Count() > 0)
            {
                foreach (var department in departmentList)
                {
                    if (department != null)
                        departmentModelList.Add(Convert(department));
                }
            }
            return departmentModelList;
        }

        public static DepartmentModel Convert(Department department)
        {
            DepartmentModel departmentModel = new DepartmentModel();
            if(department != null)
            {
                departmentModel.Name = department.Name;
                departmentModel.Id = department.Id;
                departmentModel.Employees = EmployeeConverter.Convert(department.Employees.ToList());
            }
            return departmentModel;
        }
    }
}
