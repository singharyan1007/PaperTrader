using PaperTrader.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionsByPortfolioIdAsync(Guid portfolioId);
        Task<IEnumerable<Transaction>> GetTransactionsByPortfolioIdAndTickerAsync(Guid portfolioId, string tickerSymbol);
    }
}
