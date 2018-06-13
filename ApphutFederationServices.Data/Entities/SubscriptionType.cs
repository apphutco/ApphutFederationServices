using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("SubscriptionType")]
    public class SubscriptionType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SubscriptionScheme> SubscriptionSchemes { get; set; }
    }
}
