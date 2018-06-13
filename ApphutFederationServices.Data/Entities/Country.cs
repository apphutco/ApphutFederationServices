using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
