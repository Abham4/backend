using firstnet.Data;
using firstnet.Infrastracture.Apply;
using firstnet.Infrastracture.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace firstnet.Infrastracture
{
    public static class InfrastructureRegistration 
    {
           public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {

           var mysql = configuration.GetConnectionString("JoshuaBackEnd");
            services.AddDbContext<Context>(c  => {
            c.UseMySql(mysql,ServerVersion.AutoDetect(mysql));
            });

            services.AddScoped(typeof(IBaseRepositery<>),typeof(BaseRepositery<>));
            services.AddScoped<IMemberRepositery,MemberRepositery>();
            services.AddScoped<IStudRepositery,StudRepositery>();
            services.AddScoped<IStaffRepositery,StaffRepositery>();      
            services.AddScoped<IUserRepositery,UserRepositery>(); 
            services.AddScoped<IOrganizationRepositery,OrganizationRepositery>();
            services.AddScoped<IChecRepositery,CheckRepositery>(); 
            return services;
        }
    }
}