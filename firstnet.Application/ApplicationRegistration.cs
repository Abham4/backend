using firstnet.Application.Apply;
using firstnet.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace firstnet.Application
{
    public static class ApplicationRegistration 
    {
          public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMember,ApplyMember>();
            services.AddScoped<IStud,ApplyStud>();
            services.AddScoped<IStaff,ApplyStaff>();
            services.AddScoped<IUser,ApplyUser>();
            services.AddScoped<IOrganization,ApplyOrganization>();
            services.AddScoped<ICheck,ApplyCheck>();
            return services;
        }
    }

}