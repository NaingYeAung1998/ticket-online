using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOnline.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public int OrderNo { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Qty { get; set; }

        public double Cost { get; set; }

        public Guid TicketId { get; set; }

        public Guid CreatedBy { get; set; }

        public Customer Customer { get; set; }

        public Ticket Ticket { get; set; }

        public Order()
        {

        }
    }
}
