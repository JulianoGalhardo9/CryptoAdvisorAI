namespace CryptoAdvisorAI.Domain.Entities
{
    public enum TransactionType
    {
        Deposit = 1, // Adicionar saldo "imaginário" na carteira
        Buy = 2,     // Usar saldo para comprar uma cripto
        Sell = 3     // Vender cripto e voltar para o saldo
    }
}

