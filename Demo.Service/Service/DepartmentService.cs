﻿using Demo.Database.Models;
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

        public Task<ResponseModel<List<Department>>> GetAllDepartments()
        {
            throw new NotImplementedException();
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
    }
}
