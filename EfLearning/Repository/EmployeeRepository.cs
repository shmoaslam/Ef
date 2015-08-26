using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public partial  class EmployeeRepository
    {
      private BaseRepository BaseInstance;

      public EmployeeRepository()
      {
          BaseInstance = new BaseRepository();
      }

      public List<Employee> GetEmployeeByDepartmentId(int departmentId)
      {
          if(departmentId > 0)
          {
              var data = BaseInstance.GetManyWhere<Employee>(x => x.DepartmentId == departmentId);
              if(data != null && data.Count()>0)
              {
                  return data.ToList();
              }
          }
          return null;
      }
    }
}
