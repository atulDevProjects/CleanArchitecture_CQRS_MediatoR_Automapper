using Application.Common.Interfaces;
using Application.EmployeeDetails.Commands;
using Application.EmployeeDetails.Queries;
using AutoMapper;
using Domain.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmployeeServiceProvider : IEmployeeServiceProvider
    {
        public EmpDBContext dBContext { get; set; }
        private readonly IMapper mapper;
        public EmployeeServiceProvider(EmpDBContext _dBContext, IMapper _mapper)
        {
            dBContext = _dBContext;
            mapper = _mapper;
        }
        public Task<List<EmployeeDTO>> GetAllEmployees()
        {
            var result = dBContext.Employees.ToList();

            #region map manually
            // mapping from dbModel model to DtoModel model manually

            //List<EmployeeDTO> employeeDTOs = result.Select(dbObj => new EmployeeDTO()
            //{
            //    Id = dbObj.Id,
            //    Name = dbObj.Name,
            //    Age = dbObj.Age,
            //    Address = dbObj.Address,
            //}).ToList();
            #endregion

            var employeeDTOs = mapper.Map<List<EmployeeDTO>>(result);

            return Task.FromResult(employeeDTOs.ToList());
        }

        public Task<EmployeeDTO> GetEmployeesById(EmployeeQueryById employeeQueryById)
        {
            var result = dBContext.Employees.Where(x=>x.Id== employeeQueryById.Id).FirstOrDefault();

            var employeeDTOs = mapper.Map<EmployeeDTO>(result);

            return Task.FromResult(employeeDTOs);
        }

        public Task<string> AddEmployee(AddEmployeeDetails addEmployeeDetails)
        {
            var employeeDTOs = mapper.Map<Employee>(addEmployeeDetails);

            dBContext.Employees.Add(employeeDTOs);

            dBContext.SaveChanges();

            return Task.FromResult("Inserted Successfully");
        }

        public Task<string> DeleteEmployee(DeleteEmployeeDetails deleteEmployeeDetails)
        {
            var data = dBContext.Employees.Where(d => d.Id == deleteEmployeeDetails.Id).FirstOrDefault();

            dBContext.Employees.Remove(data);
           
            dBContext.SaveChanges();

            return Task.FromResult("Deleted Successfully");
        }
        
    }
}
