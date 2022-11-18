using Demo.Database.Models;
using Demo.Entities;
using Demo.Entities.ResponseModel;

namespace Demo.Repository.Interface
{
    public interface IDepartmentRepository
    {
        public Task<List<Department>> GetAllDepartments();
        public Task<Department> GetDepartment(int id);
        public Task<bool> CreateDepartment(DepartmentRequestModel department);
        public Task<bool> UpdateDepartment(DepartmentRequestModel department);
        public Task<bool> DeleteDepartment(int id);
    }
}
