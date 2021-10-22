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
   
    public class EmployeeQuery : IRequest<List<EmployeeDTO>>
    {
        
    }
    public class EmployeeQueryHandler : IRequestHandler<EmployeeQuery, List<EmployeeDTO>>
    {
        private readonly IEmployeeServiceProvider _employeeServiceProvider;

        public EmployeeQueryHandler(IEmployeeServiceProvider employeeServiceProvider)
        {
            _employeeServiceProvider = employeeServiceProvider;

        }
        public Task<List<EmployeeDTO>> Handle(EmployeeQuery request, CancellationToken cancellationToken)
        {
            var data = _employeeServiceProvider.GetAllEmployees();

            return data;
        }

    }
}
