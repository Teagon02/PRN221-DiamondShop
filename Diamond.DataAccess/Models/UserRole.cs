using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class UserRole
    {
        [Key]
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }


        // relationship
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
