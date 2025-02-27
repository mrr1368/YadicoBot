using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yadico.DataLayer.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public long ChatID { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(150)]
        public string UserName { get; set; }

        [Required]
        public DateTime DateJoined { get; set; }
    }
}
