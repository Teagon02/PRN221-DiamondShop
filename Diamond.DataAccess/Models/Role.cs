using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        //Navigation
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
