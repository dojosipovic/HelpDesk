using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    /// <summary>
    /// Abstraktna klasa koja opisuje osobu
    /// </summary>
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Zapisuje objekt u obliku stringa
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
