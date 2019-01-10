using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public string OpenedBy { get; set; }

        [ScaffoldColumn(false)]
        public string ClosedBy { get; set; }

        public bool Closed { get; set; }
    }
}
