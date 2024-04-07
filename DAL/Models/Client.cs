namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            BankTransaction = new HashSet<BankTransaction>();
        }

        [Required]
        [StringLength(25)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(40)]
        public string ClientSurname { get; set; }

        public int ClientType { get; set; }

        public int AccountNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        [Required]
        [StringLength(25)]
        public string ClientLogin { get; set; }

        [Required]
        [StringLength(25)]
        public string ClientPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankTransaction> BankTransaction { get; set; }

        public virtual ClientType ClientType1 { get; set; }
    }
}
