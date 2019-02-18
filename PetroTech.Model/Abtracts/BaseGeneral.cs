using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Model.Abtracts
{
    public abstract class BaseGeneral : IBaseGeneral
    {
        public DateTime? CreateDateTime { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        [MaxLength(256)]
        public string LastUpdatedBy { get; set; }

        [MaxLength(256)]
        public string Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyWord { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}
