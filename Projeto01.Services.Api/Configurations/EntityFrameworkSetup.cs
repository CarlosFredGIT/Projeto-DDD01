using Microsoft.EntityFrameworkCore;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Services.Api.Configurations
{
    public static class EntityFrameworkSetup
    {
        public static void AddEntityFramework(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlServerContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Projeto01")));
        }
    }
}
