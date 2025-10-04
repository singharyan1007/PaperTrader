using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperTrader.Domain.Entites
{
   public class User
    {

        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
        public decimal InitialFunds { get; set; }
        public decimal CurrentFunds { get; set; } // Current cash available for trading
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

         public User()
        {
            //For EF Core
        }

        public User(string username, string email, decimal initialFunds)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            InitialFunds = initialFunds;
            CurrentFunds = initialFunds;
        }

    }


}
}
