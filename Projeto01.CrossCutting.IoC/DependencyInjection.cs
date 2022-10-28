using Microsoft.Extensions.DependencyInjection;
using Projeto01.Application.Contracts;
using Projeto01.Application.Services;
using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Contracts.Services;
using Projeto01.Domain.Services;
using Projeto01.Infra.Data.SqlServer.Repositories;

namespace Projeto01.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            #region Application

            services.AddTransient<IEmpresaApplicationService, EmpresaApplicationService>();
            //services.AddTransient<IFuncionarioApplicationService, FuncionarioApplicationService>();

            #endregion

            #region Domain

            services.AddTransient<IEmpresaDomainService, EmpresaDomainService>();
            services.AddTransient<IFuncionarioDomainService, FuncionarioDomainService>();

            #endregion

            #region InfraStructures

            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion
        }
    }
}