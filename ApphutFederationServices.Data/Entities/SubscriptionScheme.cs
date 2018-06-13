using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("SubscriptionScheme")]
    public class SubscriptionScheme
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid SubscriptionTypeId { get; set; }
        public string Name { get; set; }
        [Required]
        public decimal UnitPriceUsd { get; set; }

        [ForeignKey("SubscriptionTypeId")]
        public SubscriptionType SubscriptionType { get; set; }

        public virtual ICollection<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }
        public virtual ICollection<InstitutionPayment> InstitutionPayments { get; set; }

        
    }
}
