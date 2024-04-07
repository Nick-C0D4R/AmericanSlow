namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankTransaction")]
    public partial class BankTransaction : BaseModel
    {
        public int TransactionType { get; set; }

        public int ClientId { get; set; }

        public int RecieverNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal TransactionSum { get; set; }

        public virtual Client Client { get; set; }

        public virtual TransactionType TransactionType1 { get; set; }
    }
}
