using Demo.Database.Models;
using Demo.Entities;
using Demo.Entities.ResponseModel;
using Demo.Repository.Interface;
using Demo.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Service.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<ResponseModel<Department>> CreateDepartment(Department department)
        {
            ResponseModel<Department> responseModel = new ResponseModel<Department> { IsSuccess = false };
            try
            {
                var thedepartment = await _departmentRepository.CreateDepartment(department);
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

        public async Task<ResponseModel<bool>> DeleteDepartment(int id)
        {
            ResponseModel<bool> responseModel = new ResponseModel<bool> { IsSuccess = false };
            try
            {
                var thedepartments = await _departmentRepository.DeleteDepartment(id);
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

        public async Task<ResponseModel<List<Department>>> GetAllDepartments()
        {
            ResponseModel<List<Department>> responseModel = new ResponseModel<List<Department>> { IsSuccess = false };
            try
            {
                var thedepartments = await _departmentRepository.GetAllDepartments();
                responseModel.Data = thedepartments.ToList();
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

        public async Task<ResponseModel<Department>> GetDepartment(int id)
        {
            ResponseModel<Department> responseModel = new ResponseModel<Department> { IsSuccess = false };
            try
            {
                var thedepartment = await _departmentRepository.GetDepartment(id);
                responseModel.Data = thedepartment;
                responseModel.IsSuccess = true;
                responseModel.Message = "Data Retrived Successfully";

                return responseModel;
            }
            catch (Exception e)
            {
                responseModel.Message = "Something went wrong";
                responseModel.IsSuccess = false;
                return responseModel;
            }
        }

        public async Task<ResponseModel<Department>> UpdateDepartment(Department department)
        {
            ResponseModel<Department> responseModel = new ResponseModel<Department> { IsSuccess = false };
            try
            {
                var thedepartment = await _departmentRepository.UpdateDepartment(department);
                responseModel.Data = new Department
                {
                    DepartmentId = department.DepartmentId,
                    Department_Name = department.Department_Name
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
