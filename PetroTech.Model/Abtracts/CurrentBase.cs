using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Model.Abtracts
{
    public class CurrentBase
    {
        public DateTime? CreateDateTime { get; set; }

        [MaxLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        [MaxLength(250)]
        public string LastUpdatedBy { get; set; }
    }
}
