//Objeto usado para transportar dados entre camadas

namespace CryptoAdvisorAI.Application.DTOs
{
    // Este é o "contrato" do que o usuário deve enviar no JSON
    public record CreateTransactionRequest(
        string Symbol,
        decimal Quantity,
        decimal PriceAtPurchase,
        DateTime PurchaseDate
    );
}

