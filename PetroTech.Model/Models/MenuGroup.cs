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
    public  class MenuGroup
    {
        [Key]
        public string MenuGroupID { get; set; }

        [Required]
        public string MenuGroupName { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
