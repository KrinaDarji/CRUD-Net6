using Demo.Database.Models;
using Demo_Entity.RequestModel;
using Demo_Repository.Dapper_Repository.Interface;
using Demo_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbRepo _dbRepo;

        public EmployeeRepository(IDbRepo dbRepo)
        {
            _dbRepo = dbRepo;
        }

        public async Task<bool> CreateEmployee(EmployeeRequestModel employee)
        {
            var result =
                await _dbRepo.EditData(
                    "INSERT INTO Employees (FirstName, LastName, EmailAddress, Phone,Address,DepartmentId) VALUES (@FirstName, @LastName, @EmailAddress, @Phone,@Address,@DepartmentId)",
                    employee);
            return true;
        }
        public async Task<bool> DeleteEmployee(int id)
        {
            var deleteEmployee = await _dbRepo.EditData("DELETE FROM Employees WHERE id=@Id", new { id });
            return true;
        }

        public async Task<List<Employee>> GetEmployeeList()
        {
            var employeeList = await _dbRepo.GetAll<Employee>("SELECT * FROM Employees", new { });
            return employeeList;
        }

        public async Task<bool> UpdateEmployee(EmployeeRequestModel employee)
        {
            var updateEmployee =
                await _dbRepo.EditData(
                    "Update Employees SET FirstName=@FirstName, LastName=@LastName, EmailAddress=@EmailAddress,Phone=@Phone,Address=@Address,DepartmentId=@DepartmentId  WHERE id=@Id",
                    employee);
            return true;
        }
    }
}
