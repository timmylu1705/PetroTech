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
    [Table("UserPasswords")]
    public class UserPassword : CurrentBase
    {
        [Key]
        public string CompanyCode { get; set; }

        [Key]
        public Guid UserId { get; set; }

        public string Password { get; set; }

        public int LoginCountTime { get; set; }

        public bool isLock { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
