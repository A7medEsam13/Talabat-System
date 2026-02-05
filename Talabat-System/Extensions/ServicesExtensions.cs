using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Talabat_System.Infrastructure;

namespace Talabat_System.Extensions
{
    public static class ServicesExtensions
    {
        extension(IServiceCollection services)
        {
            public void ConnectDatabase(ConfigurationManager configuration)
            {
                services.AddDbContext<AppDbContext>(options =>

                    options
                    .UseSqlServer(configuration.GetConnectionString("Default"))
                );
            }
        }
    }
}
