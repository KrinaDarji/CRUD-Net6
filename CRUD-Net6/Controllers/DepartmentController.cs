using Demo.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        [Route("GetDepartment")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var result = await _departmentService.GetDepartment(id);
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAllDepartments")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var result = await _departmentService.GetAllDepartments();
            if (!result.IsSuccess)
            {
                return StatusCode(500, result);
            }
            return Ok(result);
        }
    }
}
