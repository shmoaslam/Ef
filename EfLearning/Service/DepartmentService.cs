using DataModel.Model;
using Repository;
using Service.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service
{
    public class DepartmentService
    {
        private DepartmentRepository _departmentRepository;

        public DepartmentService()
        {
            _departmentRepository = new DepartmentRepository();
        }

        public List<DepartmentModel>  GetAllDepartment()
        {
            List<DepartmentModel> result = new List<DepartmentModel>();
            
            var dataResult = _departmentRepository.GetAllDepartment();
            if (dataResult != null && dataResult.Count() > 0)
                result = DepartmentConverter.Convert(dataResult);
            return result;
            
        }

        public List<DepartmentModel> GetDepartmentById(int Id)
        {
            List<DepartmentModel> result = new List<DepartmentModel>();
            var dataResult = _departmentRepository.GetDepartmentById(Id);
            if (dataResult != null && dataResult.Count() > 0)
                result = DepartmentConverter.Convert(dataResult);
            return result;
        }
    }
}
