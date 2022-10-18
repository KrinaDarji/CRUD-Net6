using Demo.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<bool> CreateEmployee(Employee employee);
        Task<List<Employee>> GetEmployeeList();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int key);
    }
}
