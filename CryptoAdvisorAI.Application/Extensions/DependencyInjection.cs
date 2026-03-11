using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoAdvisorAI.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICreateTransactionUseCase, CreateTransactionUseCase>();
            services.AddScoped<IGetPortfolioUseCase, GetPortfolioUseCase>();
            services.AddScoped<GenerateAdviceUseCase>();

            return services;
        }
    }
}

