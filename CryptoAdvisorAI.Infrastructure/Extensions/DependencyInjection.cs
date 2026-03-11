using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Domain.Interfaces;
using CryptoAdvisorAI.Infrastructure.Data;
using CryptoAdvisorAI.Infrastructure.ExternalServices;
using CryptoAdvisorAI.Infrastructure.Repositories;
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

            // "Sempre que alguém pedir a interface ITransactionRepository, entregue a classe TransactionRepository"
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ICryptoAdvisorService, CryptoAdvisorService>();

            return services;
        }
    }
}

