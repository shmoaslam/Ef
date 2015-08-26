using DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public partial class DepartmentRepository
    {
        private BaseRepository BaseInstance;

        public DepartmentRepository()
        {
            BaseInstance = new BaseRepository();
        }

        public List<Department> GetDepartmentById(int Id)
        {
            if(Id >0 )
            {
                var data = BaseInstance.GetManyWhere<Department>(x => x.Id == Id);
                if(data != null && data.Count()>0)
                {
                    return data.ToList();
                }
            }
            return null;
        }


        public List<Department> GetAllDepartment()
        {
            var data = BaseInstance.All<Department>();
            if (data != null && data.Count() > 0)
            {
                return data.ToList();
            }
            return null;
        }
    }
}
