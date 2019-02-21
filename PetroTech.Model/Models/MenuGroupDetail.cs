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
    public class MenuGroupDetail : CurrentBase
    {
        public int No { get; set; }

        public Guid MenuGroupDetailId { get; set; }

        public Guid MenuGroupId { get; set; }

        public string MenuGroupDetailName { get; set; }

        public string MenuGroupDetailUrl { get; set; }

        [ForeignKey("MenuGroupId")]
        public virtual MenuGroup MenuGroup { get; set; }

        public virtual IEnumerable<MenuRole> MenuRoles { get; set; }

    }
}
