using Demo.Database.Models;
using Demo.Entities.ResponseModel;
using Demo_Repository.Interface;
using Demo_Service.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<ResponseModel<bool>> CreateEmployee(Employee employee)
        {
            ResponseModel<bool> responseModel = new ResponseModel<bool> { IsSuccess = false };
            try
            {
                var theemployee = await _employeeRepository.CreateEmployee(employee);
                responseModel.IsSuccess = true;
                responseModel.Message = "Data Added Successfully";

                return responseModel;
            }
            catch (Exception e)
            {
                responseModel.Message = "Something went wrong";
                responseModel.IsSuccess = false;
                return responseModel;
            }
        }

        public async Task<ResponseModel<bool>> DeleteEmployee(int id)
        {
            ResponseModel<bool> responseModel = new ResponseModel<bool> { IsSuccess = false };
            try
            {
                var theemployee = await _employeeRepository.DeleteEmployee(id);
                responseModel.IsSuccess = true;
                responseModel.Message = "Data Removed Successfully";

                return responseModel;
            }
            catch (Exception e)
            {
                responseModel.Message = "Something went wrong";
                responseModel.IsSuccess = false;
                return responseModel;
            }
        }

        public async Task<ResponseModel<List<Employee>>> GetEmployeeList()
        {

            ResponseModel<List<Employee>> responseModel = new ResponseModel<List<Employee>> { IsSuccess = false };
            try
            {
                var theemployees = await _employeeRepository.GetEmployeeList();
                responseModel.Data = theemployees.ToList();
                responseModel.IsSuccess = true;
                responseModel.Message = "All Data Retrieved Successfully";
                return responseModel;
            }
            catch (Exception e)
            {
                responseModel.Message = "Something went wrong";
                responseModel.IsSuccess = false;
                return responseModel;
            }
        }

        public async Task<ResponseModel<Employee>> UpdateEmployee(Employee employee)
        {
            ResponseModel<Employee> responseModel = new ResponseModel<Employee> { IsSuccess = false };
            try
            {
                var thedepartment = await _employeeRepository.UpdateEmployee(employee);
                responseModel.Data = new Employee
                {
                    FirstName = employee.FirstName, 
                    LastName = employee.LastName,
                    Phone= employee.Phone,
                    Address = employee.Address,
                    EmailAddress = employee.EmailAddress,
                    DepartmentId = employee.DepartmentId
                };
                responseModel.IsSuccess = true;
                responseModel.Message = "Data Updated Successfully";

                return responseModel;
            }
            catch (Exception e)
            {
                responseModel.Message = "Something went wrong";
                responseModel.IsSuccess = false;
                return responseModel;
            }
        }
    }
}
