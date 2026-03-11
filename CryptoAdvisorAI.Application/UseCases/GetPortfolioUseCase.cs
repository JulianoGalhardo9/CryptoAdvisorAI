using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Domain.Entities;
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
            var transactions = await _repository.GetAllAsync();

            // 1. Calculamos o Saldo em Dinheiro (Cash)
            var deposits = transactions.Where(t => t.Type == TransactionType.Deposit).Sum(t => t.TotalCost);
            var buys = transactions.Where(t => t.Type == TransactionType.Buy).Sum(t => t.TotalCost);
            var cashBalance = deposits - buys;

            // 2. Calculamos as Criptos (Apenas o que é Buy)
            var portfolioItems = transactions
                .Where(t => t.Type == TransactionType.Buy)
                .GroupBy(t => t.Symbol)
                .Select(group => {
                    var totalQty = group.Sum(t => t.Quantity);
                    var totalCost = group.Sum(t => t.TotalCost);
                    return new WalletItemDto(group.Key, totalQty, totalCost / totalQty, totalCost);
                }).ToList();

            return new PortfolioResponse(portfolioItems, cashBalance, cashBalance + portfolioItems.Sum(x => x.TotalInvested));
        }
    }
}

