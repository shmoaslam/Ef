using DataModel.Mapping;
using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Context
{
    public partial class EfLearningContext : DbContext
    {
        static EfLearningContext()
        {
            Database.SetInitializer<EfLearningContext>(null);
        }

        public EfLearningContext()
            : base("Name=EfLearningEntities")
        {

        }

        public DbSet<Department> Departments { get; set; }
        
        public DbSet<Employee> Employess { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
        }
    }
}
