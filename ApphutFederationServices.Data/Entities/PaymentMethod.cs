using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("PaymentMethod")]
    public class PaymentMethod
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
