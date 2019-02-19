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
    [Table("PostCatelogies")]
    public class PostCatelogy : BaseGeneral
    {
        [Key]
        public string PostCatelogyID { get; set; }

        [Required]
        [MaxLength(256)]
        public string PostCatelogyName { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "nvarchar")]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Desctiption { get; set; }

        public int? PartnerID { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public string HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
