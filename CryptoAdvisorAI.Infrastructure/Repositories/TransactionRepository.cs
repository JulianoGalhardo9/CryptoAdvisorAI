
using CryptoAdvisorAI.Domain.Entities;
using CryptoAdvisorAI.Domain.Interfaces;
using CryptoAdvisorAI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CryptoAdvisorAI.Infrastructure.Repositories
{
    // Esta classe "Realiza" o contrato ITransactionRepository
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;

        // O ABC da Injeção: O repositório pede o Gerente do Banco (Context) no construtor
        public TransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Transaction transaction)
        {
            // Adiciona o objeto na fila do banco
            await _context.Transactions.AddAsync(transaction);

            // Salva as mudanças de verdade no PostgreSQL
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            // Busca todas as transações e transforma em uma lista
            return await _context.Transactions.ToListAsync();
        }
    }
}

