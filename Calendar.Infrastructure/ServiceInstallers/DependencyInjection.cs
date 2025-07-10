using Calendar.Data.Interfaces;
using Calendar.Data.Models;
using Calendar.Data.Repositories;
using Calendar.Infrastructure.Holidays;
using Calendar.Services;
using Calendar.Services.Interfaces;
using Calendar.Services.Interfaces.External;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calendar.Infrastructure.ServiceInstallers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationServices();
            services.AddDataServices();
            services.AddDatabase(configuration);
            services.AddInfrastructure();
            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ICalendarServices, CalendarServices>();
            services.AddScoped<IHolidayProvider, HolidayProvider>();

            return services;
        }

        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAssigmentRepository, AssigmentRepository>();

            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CalendarDBContext>(options =>
                options.UseSqlServer(config.GetConnectionString("CalendarAppDB")));
            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddHttpClient<IHolidayProvider, HolidayProvider>();

            return services;
        }

    }
}
