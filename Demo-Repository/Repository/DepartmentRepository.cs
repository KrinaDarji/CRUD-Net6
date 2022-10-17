using Demo.Database;
using Demo.Database.Models;
using Demo.Entities;
using Demo.Entities.ResponseModel;
using Demo.Repository.Interface;
using Microsoft.EntityFrameworkCore;
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
            var result = await _dBContext.Departments.ToListAsync();
            return result;
        }

        public async Task<Department> GetDepartment(int id)
        {
            var theDepartment = await _dBContext.Departments.FindAsync(id);
            return theDepartment;

        }
    }
}
