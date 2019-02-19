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
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string TagID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TagName { get; set; }

        [Required]
        [MaxLength(50)]
        public string TagType { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}
