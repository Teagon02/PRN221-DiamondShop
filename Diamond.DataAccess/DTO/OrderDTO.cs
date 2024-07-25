using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public string PhoneNumber { get; set; }
       
    }
}
