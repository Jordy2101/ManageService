using ManageService.Application.Services;
using ManageService.Application.Services.Base;
using ManageService.Application.Services.Contract;
using ManageService.Domain.ManageService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManageService.Application.DependecyInjection
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IServicesBase<Status>, StatusService>();
            services.AddScoped<IServicesBase<TypeService>, TypeServiceService>();
            services.AddScoped<IServicesBase<ClientAdress>, ClientAdressService>();
            services.AddScoped<IClientAdressService, ClientAdressService>(); 
            services.AddScoped<IServicesBase<Client>, ClientService>();
            services.AddScoped<IClientService, ClientService>(); 
            services.AddScoped<IServicesBase<Service>, ServiceService>();
            services.AddScoped<IServiceService, ServiceService >(); 
        }
    }
}