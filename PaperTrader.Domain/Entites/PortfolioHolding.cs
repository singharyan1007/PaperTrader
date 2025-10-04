using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Entites
{
    public class PortfolioHolding
    {
        //Represents the stock held in a user's portfolio
        public Guid Id { get; set; }
        public Guid PortfolioId { get; set; }
        public string TickerSymbol { get; set; } = string.Empty; // e.g., "MSFT", "AAPL"
        public int Quantity { get; set; }
        public decimal AverageCostPerShare { get; set; } // Weighted average cost
        public DateTime AcquiredAt { get; set; } = DateTime.UtcNow; // Initial acquisition date

        // Navigation property
        public virtual Portfolio Portfolio { get; set; } = default!;

        public PortfolioHolding(Guid portfolioId, string tickerSymbol, int quantity, decimal averageCostPerShare)
        {
            Id = Guid.NewGuid();
            PortfolioId = portfolioId;
            TickerSymbol = tickerSymbol;
            Quantity = quantity;
            AverageCostPerShare = averageCostPerShare;
        }

        // For EF Core
        private PortfolioHolding() { }
    }
}
