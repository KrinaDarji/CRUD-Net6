using Demo.Entities.ResponseModel;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Database.Models;

namespace Demo.Service.Interface
{
    public interface IDepartmentService
    {
        public Task<ResponseModel<List<Department>>> GetAllDepartments();
        public Task<ResponseModel<Department>> GetDepartment(int id);
        public Task<ResponseModel<Department>> CreateDepartment(DepartmentRequestModel department);
        public Task<ResponseModel<Department>> UpdateDepartment(DepartmentRequestModel department);
        public Task<ResponseModel<bool>> DeleteDepartment(int id);

    }
}
