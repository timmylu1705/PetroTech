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
    [Table("Roles")]
    public class Role : CurrentBase
    {
        [Key]
        public Guid RoleId { get; set; }

        [Required]
        [MaxLength(250)]
        public string RoleName { get; set; }

        public bool isSystemRole { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}
