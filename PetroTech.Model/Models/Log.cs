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
    [Table("Logs")]
    public class Log
    {
        [Key]
        public Guid ErrorId { get; set; }

        public string MessageError { get; set; }

        public string StackTrance { get; set; }

        public DateTime? CreatedDateTime { get; set; }
    }
}
