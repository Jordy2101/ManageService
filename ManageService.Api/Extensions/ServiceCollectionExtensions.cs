using ManageService.DataAccess.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace ManageService.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddContextInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ManageServiceContext>(options => options.UseNpgsql(configuration.GetValue<string>("connectionString:PostgresSQLConnection")));
        }
    }
}
