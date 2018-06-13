using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("ApplicationInstitution")]
    public class ApplicationInstitution
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid ApplicationId { get; set; }
        [Required]
        public Guid InstitutionId { get; set; }

        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

    }
}
