using PaperTrader.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Interfaces
{
    public interface IPortfolioRepository : IRepository<Portfolio>
    {
        Task<Portfolio?> GetPortfolioWithHoldingsAndTransactionsAsync(Guid portfolioId);
        Task<IEnumerable<Portfolio>> GetPortfoliosByUserIdAsync(Guid userId);
    }
}
