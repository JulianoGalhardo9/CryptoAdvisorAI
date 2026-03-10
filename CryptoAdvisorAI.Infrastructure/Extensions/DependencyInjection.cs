using CryptoAdvisorAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoAdvisorAI.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // arquivo de configuração
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configuração do (DbContext)
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));

            return services;
        }
    }
}

