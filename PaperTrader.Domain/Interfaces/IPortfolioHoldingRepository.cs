using PaperTrader.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Interfaces
{
    public interface IPortfolioHoldingRepository : IRepository<PortfolioHolding>
    {
        Task<PortfolioHolding?> GetByPortfolioAndTickerAsync(Guid portfolioId, string tickerSymbol);
        Task<IEnumerable<PortfolioHolding>> GetHoldingsByPortfolioIdAsync(Guid portfolioId);
    }
}
