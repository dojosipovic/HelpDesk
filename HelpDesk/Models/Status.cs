using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    /// <summary>
    /// Klasa za opis objekta statusa
    /// </summary>
    public class Status
    {
        public char Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Vraća status zapisan u obliku stringa
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
