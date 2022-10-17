using Demo.Database;
using Demo.Database.Models;
using Demo.Entities;
using Demo.Entities.ResponseModel;
using Demo.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DBContext _dBContext;

        public DepartmentRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<bool> CreateDepartment(Department department)
        {
          var addDepartment =   await _dBContext.Departments.AddAsync(department);
            return addDepartment != null;
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public async Task<Department> GetDepartment(int id)
        {
            var theDepartment = await _dBContext.Departments.FindAsync(id);
            return theDepartment;

        }
    }
}
