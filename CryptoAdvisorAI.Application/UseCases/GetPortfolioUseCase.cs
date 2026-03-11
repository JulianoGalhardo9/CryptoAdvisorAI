using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Domain.Interfaces;

namespace CryptoAdvisorAI.Application.UseCases
{
    public class GetPortfolioUseCase : IGetPortfolioUseCase
    {
        private readonly ITransactionRepository _repository;

        public GetPortfolioUseCase(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<PortfolioResponse> ExecuteAsync()
        {
            // Busca todas as transações no banco
            var transactions = await _repository.GetAllAsync();

            // agrupa por símbolo (BTC, ETH...) usando LINQ
            // "GroupBy" junta tudo que tem o mesmo nome
            var portfolioItems = transactions
                .GroupBy(t => t.Symbol)
                .Select(group =>
                {
                    var totalQuantity = group.Sum(t => t.Quantity);
                    var totalInvested = group.Sum(t => t.TotalCost);

                    // Cálculo do Preço Médio: Total gasto / Total comprado
                    var averagePrice = totalQuantity > 0 ? totalInvested / totalQuantity : 0;

                    return new WalletItemDto(
                        group.Key,
                        totalQuantity,
                        averagePrice,
                        totalInvested
                    );
                }).ToList();

            var grandTotal = portfolioItems.Sum(x => x.TotalInvested);

            return new PortfolioResponse(portfolioItems, grandTotal);
        }
    }
}

