using Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.EmployeeDetails.Commands
{
   
    public class DeleteEmployeeDetails : IRequest<string>
    {
        // what request need to be send

        public int Id { get; set; }
    }
    public class DeleteEmployeeDetailsHandler : IRequestHandler<DeleteEmployeeDetails, string>
    {
        private readonly IEmployeeServiceProvider _employeeServiceProvider;

        public DeleteEmployeeDetailsHandler(IEmployeeServiceProvider employeeServiceProvider)
        {
            _employeeServiceProvider = employeeServiceProvider;

        }
        public Task<string> Handle(DeleteEmployeeDetails request, CancellationToken cancellationToken)
        {
            var data = _employeeServiceProvider.DeleteEmployee(request);

            return data;
        }

    }
}
