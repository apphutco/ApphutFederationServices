using System;
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
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public Guid CurrencyId { get; set; }
        public string LanguageCode { get; set; }
        public string TimeZone { get; set; }
        public string ContractPerson { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public byte[] Logo { get; set; }
        public bool IsActive { get; set; }

    }
}
