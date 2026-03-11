using CryptoAdvisorAI.Domain.Entities;

namespace CryptoAdvisorAI.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        // Contrato para salvar uma transação
        // Task significa que é uma operação "Assíncrona" (o sistema não trava enquanto salva)
        Task AddAsync(Transaction transaction);

        // Contrato para buscar todas as transações cadastradas
        Task<IEnumerable<Transaction>> GetAllAsync();
    }
}

