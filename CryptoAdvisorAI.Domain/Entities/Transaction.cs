namespace CryptoAdvisorAI.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public string Symbol { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal PriceAtPurchase { get; private set; }
        public DateTime PurchaseDate { get; private set; }

        public decimal TotalCost => Quantity * PriceAtPurchase;

        public Transaction(string symbol, decimal quantity, decimal priceAtPurchase, DateTime purchaseDate)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("O símbolo da moeda é obrigatório.");

            if (quantity <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (priceAtPurchase <= 0)
                throw new ArgumentException("O preço de compra deve ser maior que zero.");

            Id = Guid.NewGuid();
            Symbol = symbol.ToUpper();
            Quantity = quantity;
            PriceAtPurchase = priceAtPurchase;
            PurchaseDate = purchaseDate;
        }
    }
}

