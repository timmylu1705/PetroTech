using PetroTech.Model.Abtracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetroTech.Model.Models
{
    [Table("Products")]
    public class Product : BaseGeneral
    {
        [Key]
        public string ProductID { get; set; }

        [Required]
        [MaxLength(256)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        public int ProductCatelogyID { get; set; }

        public string Image { get; set; }

        public XElement MoreImage { get; set; }

        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public string HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [ForeignKey("ProductCatelogyID")]
        public virtual ProductCatelogy ProductCatelogy { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
