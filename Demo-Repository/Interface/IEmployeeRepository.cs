using Demo.Database.Models;
using Demo_Entity.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<bool> CreateEmployee(EmployeeRequestModel employee);
        Task<List<Employee>> GetEmployeeList();
        Task<bool> UpdateEmployee(EmployeeRequestModel employee);
        Task<bool> DeleteEmployee(int key);
    }
}
