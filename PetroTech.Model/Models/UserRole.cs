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
    [Table("UserRoles")]
    public class UserRole
    {
        [Key]
        public Guid UserRoleId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public DateTime? LastUpdatedDatetime { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
