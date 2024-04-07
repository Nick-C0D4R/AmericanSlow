using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ClientDTO : BaseDTO
    {
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public int ClientType { get; set; }
        public int AccountNumber { get; set; }
        public decimal? Balance { get; set; }
        public string ClientLogin { get; set; }
        public string ClientPassword { get; set; }
    }
}
