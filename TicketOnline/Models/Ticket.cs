using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOnline.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime EventDate { get; set; }

        public string CoverPhoto { get; set; }

        public string TicketPhoto { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime CreatedOn { get; set; }

        public Ticket()
        {

        }
    }
}
