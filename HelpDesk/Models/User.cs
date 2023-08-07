using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    /// <summary>
    /// Klasa za opis objekta korisnika
    /// </summary>
    public class User : Person
    {
        /// <summary>
        /// Metoda za povjeru lozinke korisnika
        /// </summary>
        /// <param name="password">Upisana lozinka</param>
        /// <returns>true ili false</returns>
        public bool CheckPassword(string password)
        {
            return password == Password;
        }
    }
}
