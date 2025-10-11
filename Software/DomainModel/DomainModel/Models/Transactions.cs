using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
