using ManageService.DataAccess.Repositories;
using ManageService.DataAccess.Repositories.Base;
using ManageService.Domain.ManageService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.DataAccess.DependencyInjection
{
    public static class RepositoriesCollectionConfiguration
    {
        public static void AddRepositoriesCollections(this IServiceCollection service)
        {
            service.AddScoped<IBaseRepository<Status>, StatusRepository>();
            service.AddScoped<IBaseRepository<ClientAdress>, ClientAdressRepository>();
            service.AddScoped<IBaseRepository<Client>, ClientRepository>();
            service.AddScoped<IBaseRepository<Service>, ServiceRepository>();
            service.AddScoped<IBaseRepository<TypeService>, TypeServiceRepository>();
        }
    }
}
