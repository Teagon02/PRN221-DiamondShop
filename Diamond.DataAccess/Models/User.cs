using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreateOn { get; set; }
        public bool Status { get; set; }
        //Navigation
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
