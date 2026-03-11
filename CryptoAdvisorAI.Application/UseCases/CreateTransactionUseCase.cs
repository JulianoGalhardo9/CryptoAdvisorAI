using CryptoAdvisorAI.Application.DTOs;
using CryptoAdvisorAI.Application.Interfaces;
using CryptoAdvisorAI.Domain.Entities;
using CryptoAdvisorAI.Domain.Interfaces;

namespace CryptoAdvisorAI.Application.UseCases
{
    public class CreateTransactionUseCase : ICreateTransactionUseCase
    {
        private readonly ITransactionRepository _repository;

        // O UseCase pede o repositório para conseguir salvar os dados
        public CreateTransactionUseCase(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<Transaction> ExecuteAsync(CreateTransactionRequest request)
        {
            // Aqui é onde as REGRAS DE NEGÓCIO moram.
            // Por enquanto, apenas criamos e salvamos.

            var transaction = new Transaction(
                request.Symbol,
                request.Quantity,
                request.PriceAtPurchase,
                request.PurchaseDate
            );

            await _repository.AddAsync(transaction);

            return transaction;
        }
    }
}

