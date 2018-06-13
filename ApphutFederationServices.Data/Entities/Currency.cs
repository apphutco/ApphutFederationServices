using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("Currency")]
    public class Currency
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
