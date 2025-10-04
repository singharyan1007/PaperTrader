using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Entites
{
    public enum TransactionType
    {
        Buy,
        Sell
    }
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid PortfolioId { get; set; }
        public string TickerSymbol { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal PricePerShare { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        // Navigation property
        public virtual Portfolio Portfolio { get; set; } = default!;

        public Transaction(Guid portfolioId, string tickerSymbol, int quantity, decimal pricePerShare, TransactionType type)
        {
            Id = Guid.NewGuid();
            PortfolioId = portfolioId;
            TickerSymbol = tickerSymbol;
            Quantity = quantity;
            PricePerShare = pricePerShare;
            Type = type;
        }

        // For EF Core
        public Transaction() { }

    }
}
