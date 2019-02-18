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
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        public string SupportOnlineID { get; set; }

        [MaxLength(50)]
        public string SupportOnlineName { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(50)]
        public string Facebook { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public int? DisplayOrder { get; set; }

    }
}
