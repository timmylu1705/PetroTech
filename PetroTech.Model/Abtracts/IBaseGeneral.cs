using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Model.Abtracts
{
    public interface IBaseGeneral
    {
        DateTime? CreateDateTime { get; set; }

        string CreatedBy { get; set; }

        DateTime? LastUpdatedDateTime { get; set; }

        string LastUpdatedBy { get; set; }

        string Status { get; set; }

        string MetaKeyWord { get; set; }

        string MetaDescription { get; set; }
    }
}
