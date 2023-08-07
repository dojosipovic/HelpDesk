using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Ticket
    {
        /// <summary>
        /// Klasa za opis objekta zahtjeva
        /// </summary>
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime TakingTime { get; set; }
        public string Description { get; set; }
        public User Creator { get; set; }
        public Employee Taker { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }

    }
}
