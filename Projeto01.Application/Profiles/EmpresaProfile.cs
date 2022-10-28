using AutoMapper;
using Projeto01.Application.Commands.Empresas;
using Projeto01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Application.Profiles
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            #region Commands To Entities

            CreateMap<EmpresaCreateCommand, Empresa>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.NewGuid();
                    //dest.NomeFantasia = src.NomeFantasia;
                });

            CreateMap<EmpresaUpdateCommand, Empresa>();
            CreateMap<EmpresaDeleteCommand, Empresa>();

            #endregion
        }
    }
}
