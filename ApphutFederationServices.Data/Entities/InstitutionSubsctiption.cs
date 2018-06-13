using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("InstitutionSubsctiption")]
    public class InstitutionSubsctiption
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public Guid SubscriptionSchemeId { get; set; }
        [Required]
        public Guid InstitutionId { get; set; }
        public string SubscriptionTypeCode { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Int64 AllowedTransactions { get; set; }
        public Int64 CurrentTransactions { get; set; }

        public bool IsDateBased { get; set; }
        public bool IsTransactionBased { get; set; }

        public decimal GrossCost { get; set; }
        public Decimal NettCost { get; set; }
        public bool IsDiscounted { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }

        public bool IsActive { get; set; }
        public bool IsRenewed { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }

        public DateTime RenewedDate { get; set; }
        public Guid RenewedBy { get; set; }

        [ForeignKey("SubscriptionSchemeId")]
        public SubscriptionScheme SubscriptionScheme { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

        [ForeignKey("CreatedBy")]
        public User UserCreated { get; set; }

        [ForeignKey("RenewedBy")]
        public User UserRenewed { get; set; }
    }
}
