using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BankTransactionDTO : BaseDTO
    {
        public int TransactionId { get; set; }
        public int ClientId { get; set; }
        public int RecieverNumber { get; set; }
        public decimal TransactionSum { get; set; }
    }
}
