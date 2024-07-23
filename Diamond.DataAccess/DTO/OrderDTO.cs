using Diamond.DataAccess.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.DTO
{
    public class OrderDTO
    {
        public int UserId { get; set; }
        public double Total { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
