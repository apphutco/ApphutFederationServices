using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApphutFederationServices.Data.Entities
{
    [Table("Application")]
    public class Application
    {
        [Key]
        public Guid ApplicationId { get; set; }
        [Required]
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationUrl { get; set; }
        public string ApplicationSlogan { get; set; }
        public string ApplicationImage { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
