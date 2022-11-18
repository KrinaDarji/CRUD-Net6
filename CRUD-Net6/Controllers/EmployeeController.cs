using Demo.Database.Models;
using Demo_Entity.RequestModel;
using Demo_Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Route("GetAllEmployeess")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var result = await _employeeService.GetEmployeeList();
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("CreateEmployees")]
        public async Task<IActionResult> CreateEmployee(EmployeeRequestModel employee)
        {
            var result = await _employeeService.CreateEmployee(employee);
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateDepartment(EmployeeRequestModel employee)
        {
            var result = await _employeeService.UpdateEmployee(employee);
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
    }
}
