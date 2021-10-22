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
   
    public class AddEmployeeDetails : IRequest<string>
    {
        // what request need to be send

        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }

    }
    public class AddEmployeeDetailsHandler : IRequestHandler<AddEmployeeDetails, string>
    {
        private readonly IEmployeeServiceProvider _employeeServiceProvider;

        public AddEmployeeDetailsHandler(IEmployeeServiceProvider employeeServiceProvider)
        {
            _employeeServiceProvider = employeeServiceProvider;

        }
        public Task<string> Handle(AddEmployeeDetails request, CancellationToken cancellationToken)
        {
            var data = _employeeServiceProvider.AddEmployee(request);

            return data;
        }

    }
}
