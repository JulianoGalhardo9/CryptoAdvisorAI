using CryptoAdvisorAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CryptoAdvisorAI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Aqui dizemos: "Crie uma tabela de Transações baseada na minha classe Transaction"
        public DbSet<Transaction> Transactions { get; set; }
    }
}

