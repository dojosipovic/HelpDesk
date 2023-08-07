using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    /// <summary>
    /// Klasa za prikaz objekta prioriteta
    /// </summary>
    public class Priority
    {
        public char Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Vraća objekt zapisan u obliku stringa
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
