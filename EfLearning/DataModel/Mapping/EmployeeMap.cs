using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Mapping
{
    public partial class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.HasKey(x => x.Id);

            this.ToTable("Employee");

            this.Property(x => x.Id).HasColumnName("ID");
            this.Property(x => x.Name).HasColumnName("Name");
            this.Property(x => x.Email).HasColumnName("Email");
            this.Property(x => x.DepartmentId).HasColumnName("DepartmentId");

            this.HasRequired(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId);
        }
    }
}
