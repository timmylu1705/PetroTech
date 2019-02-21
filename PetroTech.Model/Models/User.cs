using PetroTech.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Model.Models
{
    [Table("Users")]
    public class User : CurrentBase
    {
        [Key]
        public string CompanyCode { get; set; }

        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }

        [Required]
        public int Phone { get; set; }

        public string Status { get; set; }

        public virtual IEnumerable<UserPassword> UserPasswords { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}
