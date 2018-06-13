using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("Institution")]
    public class Institution
    {
        [Key]
        public Guid Id { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public Guid CityId { get; set; }
        [Required]
        public Guid CountryId { get; set; }
        [Required]
        public Guid CurrencyId { get; set; }

        public string LanguageCode { get; set; }
        public string TimeZone { get; set; }
        public string ContractPerson { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }


    }
}
