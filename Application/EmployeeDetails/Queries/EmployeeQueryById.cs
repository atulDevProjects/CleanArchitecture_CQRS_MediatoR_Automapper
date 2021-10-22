using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.EmployeeDetails.Queries
{
   
    public class EmployeeQueryById : IRequest<EmployeeDTO>
    {
        // what request need to be send

        public int Id { get; set; }
       
    }
    public class EmployeeQueryByIdHandler : IRequestHandler<EmployeeQueryById, EmployeeDTO>
    {
        private readonly IEmployeeServiceProvider _employeeServiceProvider;

        public EmployeeQueryByIdHandler(IEmployeeServiceProvider employeeServiceProvider)
        {
            _employeeServiceProvider = employeeServiceProvider;

        }
        public Task<EmployeeDTO> Handle(EmployeeQueryById request, CancellationToken cancellationToken)
        {
            var data = _employeeServiceProvider.GetEmployeesById(request);

            return data;
        }

    }
}
