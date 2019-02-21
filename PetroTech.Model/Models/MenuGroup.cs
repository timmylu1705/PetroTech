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
    [Table("MenuGroups")]
    public class MenuGroup : CurrentBase
    {
        [Key]
        public Guid MenuGroupId { get; set; }

        [Required]
        [MaxLength(250)]
        public string MenuTag { get; set; }

        [Required]
        [MaxLength(250)]
        public string MenuGroupUrl { get; set; }

        public virtual IEnumerable<MenuGroupDetail> MenuGroupDetails { get; set; }

        public virtual IEnumerable<MenuRole> MenuRoles { get; set; }
    }
}
