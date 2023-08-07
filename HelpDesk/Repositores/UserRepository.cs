using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HelpDesk.Repositores
{
    /// <summary>
    /// Klasa koja upravlja objektima klase User
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Dohvaća korisnika iz baze prema proslijeđenom korisničkom imenu
        /// </summary>
        /// <param name="username">Korisničko ime</param>
        /// <returns>User</returns>
        public static User GetUser(string username)
        {
            string sql = $"SELECT * FROM Korisnici WHERE KorisnickoIme = '{username}'";
            return GrabUser(sql);
        }
        /// <summary>
        /// Dohvaća korisnika iz baze prema proslieđenom ID-u korisnika
        /// </summary>
        /// <param name="id">ID korisnika</param>
        /// <returns>User</returns>
        public static User GetUser(int id)
        {
            string sql = $"SELECT * FROM Korisnici WHERE ID = '{id}'";
            return GrabUser(sql);
        }
        /// <summary>
        /// Dohvaća korisnika prema proslijeđenom SQL upitu
        /// </summary>
        /// <param name="sql">SQL upit</param>
        /// <returns>User</returns>
        private static User GrabUser(string sql)
        {
            User user = null;

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                reader.Read();
                user = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return user;
        }
        /// <summary>
        /// Kreira objekt klase User prema proslijeđenom čitaču
        /// </summary>
        /// <param name="reader">Čitač</param>
        /// <returns>User</returns>
        public static User CreateObject(SqlDataReader reader)
        {
            var user = new User
            {
                Id = int.Parse(reader["ID"].ToString()),
                Name = reader["Ime"].ToString(),
                Surname = reader["Prezime"].ToString(),
                Username = reader["KorisnickoIme"].ToString(),
                Password = reader["Lozinka"].ToString(),
                Email = reader["Email"].ToString()
            };

            return user;
        }
    }
}
