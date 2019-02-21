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
    [Table("MenuRoles")]
    public class MenuRole
    {
        [Key]
        public int No { get; set; }

        [Key]
        public Guid RoleId { get; set; }

        [Key]
        public Guid MenuGroupId { get; set; }

        [Key]
        public Guid MenuGroupDetailId { get; set; }

        public DateTime? LastUpdatedDatetime { get; set; }

        public bool isPermission { get; set; }

        [ForeignKey("MenuGroupId")]
        public virtual MenuGroup MenuGroup { get; set; }

        [ForeignKey("MenuGroupDetailId")]
        public virtual MenuGroupDetail MenuGroupDetail { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
