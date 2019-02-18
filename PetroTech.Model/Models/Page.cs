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
    [Table("Pages")]
    public class Page : BaseGeneral
    {
        [Key]
        public string PageID { get; set; }

        [Required]
        [MaxLength(256)]
        public string PageName { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}
