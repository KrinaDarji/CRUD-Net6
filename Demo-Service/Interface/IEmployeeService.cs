using Demo.Database.Models;
using Demo.Entities.ResponseModel;
using Demo_Entity.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Service.Interface
{
    public interface IEmployeeService
    {
        Task<ResponseModel<bool>> CreateEmployee(EmployeeRequestModel employee);
        Task<ResponseModel<List<Employee>>> GetEmployeeList();
        Task<ResponseModel<bool>> UpdateEmployee(EmployeeRequestModel employee);
        Task<ResponseModel<bool>> DeleteEmployee(int key);
    }
}
