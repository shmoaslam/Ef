using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DepartmentModel
    {
        public DepartmentModel()
        {
            this.Employees = new List<EmployeeModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<EmployeeModel> Employees { get; set; }
    }
}
