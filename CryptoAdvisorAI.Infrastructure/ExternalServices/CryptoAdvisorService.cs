using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;

namespace CryptoAdvisorAI.Infrastructure.ExternalServices
{
    public class CryptoAdvisorService : ICryptoAdvisorService
    {
        public async Task<string> GetAdviceAsync(PortfolioResponse portfolio)
        {
            // Simulando o tempo de resposta de uma IA
            await Task.Delay(1000);

            if (portfolio.CashBalance > 1000)
            {
                return "Notei que você tem um saldo alto parado. O mercado de BTC está em um bom ponto de entrada, que tal diversificar 10% desse valor?";
            }

            return "Seu portfólio está equilibrado. Mantenha sua estratégia de longo prazo.";
        }
    }
}

