using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOnline.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string CreatedBy { get; set; }

        public ApplicationUser AspNetUser { get; set; }
    }
}
