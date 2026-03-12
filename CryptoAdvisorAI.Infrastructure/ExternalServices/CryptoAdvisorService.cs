using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;

namespace CryptoAdvisorAI.Infrastructure.ExternalServices;

public class CryptoAdvisorService : ICryptoAdvisorService
{
    public async Task<string> GetAdviceAsync(PortfolioResponse portfolio)
    {
        // Simulamos um pequeno delay para parecer processamento de IA
        await Task.Delay(500);

        // Lógica de Especialista (Heurística)
        if (portfolio.CashBalance > (portfolio.TotalEquity * 0.5m) && portfolio.CashBalance > 0)
        {
            return "Análise: Você tem muito saldo em caixa (Fiat). O mercado sugere que este é um bom momento para diversificar em ativos sólidos como BTC ou ETH para proteger seu poder de compra.";
        }

        if (portfolio.Items.Count == 0)
        {
            return "Análise: Sua carteira está vazia. Comece depositando um saldo virtual e realize sua primeira compra simulada para entender o preço médio.";
        }

        if (portfolio.Items.Any(i => i.Symbol == "BTC"))
        {
            return "Análise: Você possui Bitcoin na carteira. Estratégia recomendada: HODL. Mantenha seus ativos e acompanhe o gráfico de 4 horas para identificar novas oportunidades de aporte.";
        }

        return "Análise: Portfólio equilibrado. Recomendo manter a disciplina nos aportes mensais (DCA) para otimizar seu preço médio a longo prazo.";
    }
}