using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    /// <summary>
    /// Klasa za opis objekta zaposlenika
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Metoda za provjeru lozinke zaposlenika
        /// </summary>
        /// <param name="password">Lozinka za provjeru</param>
        /// <returns>true ili false</returns>
        public bool CheckPassword(string password)
        {
            return password == Password;
        }
    }
}
