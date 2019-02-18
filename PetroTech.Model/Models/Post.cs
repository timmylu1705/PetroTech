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
    [Table("Posts")]
    public class Post : BaseGeneral
    {
        [Key]
        [MaxLength(50)]
        public string PostID { get; set; }

        [Required]
        [MaxLength(256)]
        public string PostName { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [Required]
        public int PostCatelogyID { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int ViewCount { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }

        [ForeignKey("PostCatelogyID")]
        public virtual PostCatelogy PostCatelogy { get; set; }
    }
}
