using Application.EmployeeDetails.Commands;
using Application.EmployeeDetails.Queries;
using Dell.Rewards.Creditor.WebApi.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_MediatoR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ApiControllerBase
    {
        public DetailsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("GetAllDetails")]
        public Task<List<EmployeeDTO>> GetDetails()
        {
            EmployeeQuery employeeQuery = new();
            return Mediator.Send(employeeQuery);
        }

        // request param if needed
        [HttpPut]
        [Route("GetDetailsById")]
        public Task<EmployeeDTO> GetDetailsById([FromQuery] EmployeeQueryById employeeQueryById)
        {
            return Mediator.Send(employeeQueryById);
        }

        [HttpPost]
        [Route("AddEmployeeDetails")]
        public Task<string> AddEmployeeDetails([FromQuery] AddEmployeeDetails addEmployeeDetails)
        {
            return Mediator.Send(addEmployeeDetails);
        }

        [HttpDelete]
        [Route("DeleteEmployeeDetails")]
        public Task<string> DeleteEmployeeDetails([FromQuery] DeleteEmployeeDetails deleteEmployeeDetails)
        {
            return Mediator.Send(deleteEmployeeDetails);
        }
    }
}
