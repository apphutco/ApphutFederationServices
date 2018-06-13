using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("ApplicationInstitutionRole")]
    public class ApplicationInstitutionRole
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid ApplicationId { get; set; }
        [Required]
        public Guid InstitutionId { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }

    }
}
