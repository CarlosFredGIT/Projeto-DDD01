using MediatR;
using Projeto01.Application.Commands.Empresas;
using Projeto01.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Application.Services
{
    public class EmpresaApplicationService : IEmpresaApplicationService
    {
        private readonly IMediator _mediator;

        public EmpresaApplicationService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Create(EmpresaCreateCommand command)
        {
            await _mediator.Send(command); // EmpresaRequestHandler
        }

        public async Task Delete(EmpresaDeleteCommand command)
        {
            await _mediator.Send(command); // EmpresaRequestHandler
        }

        public async Task Update(EmpresaUpdateCommand command)
        {
            await _mediator.Send(command); // EmpresaRequestHandler
        }
    }
}
