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
    [Table("ProductCatelogies")]
    public class ProductCatelogy : BaseGeneral
    {
        [Key]
        public string ProductCatelogyID { get; set; }

        [Required]
        [MaxLength(256)]
        public string ProductCatelogyName { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? PartnerID { get; set; }

        public int? DisplayOrder { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public string HomeFlag { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
