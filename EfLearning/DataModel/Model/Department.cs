using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Model
{
    public partial class Department
    {

        public Department()
        {
            this.Employees = new List<Employee>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }


    }
}
