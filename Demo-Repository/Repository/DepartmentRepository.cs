using Demo.Database;
using Demo.Database.Models;
using Demo.Entities;
using Demo.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DBContext _dBContext;

        public DepartmentRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<bool> CreateDepartment(DepartmentRequestModel department)
        {
            Department departMent = new Department()
            {
                Department_Name = department.Department_Name
            };
            var addDepartment = await _dBContext.Departments.AddAsync(departMent);
            await _dBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDepartment(int id)
        {
            var deletedepartment = await _dBContext.Departments.FirstOrDefaultAsync(x=>x.DepartmentId == id);
            if(deletedepartment != null)
            {
                _dBContext.Remove(deletedepartment);
            }
            await _dBContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            var result = await _dBContext.Departments.ToListAsync();
            return result;
        }

        public async Task<Department> GetDepartment(int id)
        {
            var theDepartment = await _dBContext.Departments.FindAsync(id);
            return theDepartment;

        }
        public async Task<bool> UpdateDepartment(DepartmentRequestModel department)
        {
            var departmentList = await _dBContext.Departments.FirstOrDefaultAsync(x => x.DepartmentId == department.DepartmentId);
            if (departmentList != null)
            {
                departmentList.Department_Name = department.Department_Name;
                _dBContext.Update(departmentList);
                await _dBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
