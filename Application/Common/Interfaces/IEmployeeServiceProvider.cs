using Application.EmployeeDetails.Commands;
using Application.EmployeeDetails.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
   
    public interface IEmployeeServiceProvider
    {
        Task<List<EmployeeDTO>> GetAllEmployees();
        Task<EmployeeDTO> GetEmployeesById(EmployeeQueryById employeeQueryById);

        Task<string> AddEmployee(AddEmployeeDetails addEmployeeDetails);

        Task<string> DeleteEmployee(DeleteEmployeeDetails deleteEmployeeDetails);

    }
}
