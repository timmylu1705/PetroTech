using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuID { get; set; }

        [Required]
        public string MenuName { get; set; }

        [Required]
        public string MenuURL { get; set; }

        public int DisplayOrder { get; set; }

        [Key, Column(Order = 1)]
        public string MenuGroupID { get; set; }

        [ForeignKey("MenuGroupID")]
        public virtual MenuGroup MenuGroup { get; set; }

        public string Target { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
