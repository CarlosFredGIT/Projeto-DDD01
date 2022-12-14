using Projeto01.Application.Commands.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Application.Contracts
{
    public interface IEmpresaApplicationService
    {
        Task Create(EmpresaCreateCommand command);
        Task Update(EmpresaUpdateCommand command);
        Task Delete(EmpresaDeleteCommand command);
    }
}
