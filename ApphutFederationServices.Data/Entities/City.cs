using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("City")]
    public class City
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CountryId { get; set; }
       
        public string Name { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string Code { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
