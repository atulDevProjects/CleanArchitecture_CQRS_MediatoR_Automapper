using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Dell.Rewards.Creditor.WebApi.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;

        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
