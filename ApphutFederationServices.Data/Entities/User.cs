using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public string language { get; set; }
        public string theme { get; set; }
        [Required]
        public Guid RoleId { get; set; }
        [Required]
        public Guid UserTypeId { get; set; }
        [Required]
        public Guid InstitutionId { get; set; }

        [ForeignKey("RoleId")]
        public ApplicationInstitutionRole Role { get; set; }
        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }
}
