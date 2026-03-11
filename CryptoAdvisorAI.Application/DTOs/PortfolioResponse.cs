namespace CryptoAdvisorAI.Application.DTOs
{
    // Um registro para mostrar o resumo de cada moeda
    public record WalletItemDto(
        string Symbol,
        decimal TotalQuantity,
        decimal AveragePrice,
        decimal TotalInvested
    );

    // O resumo geral da carteira
    public record PortfolioResponse(
        List<WalletItemDto> Items,
        decimal CashBalance,
        decimal TotalEquity
    );
}

