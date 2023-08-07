using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Repositores
{
    /// <summary>
    /// Klasa za upravljanje objektima klase Employee
    /// </summary>
    public class EmployeeRepository
    {
        /// <summary>
        /// Vraća zaposlenika iz baze
        /// </summary>
        /// <param name="username">Korisničko ime zaposlenika</param>
        /// <returns>Employee</returns>
        public static Employee GetEmployee(string username)
        {
            string sql = $"SELECT * FROM Djelatnici WHERE KorisnickoIme = '{username}'";
            return GrabEmployee(sql);
        }
        /// <summary>
        /// Vraća zaposlenika iz baze
        /// </summary>
        /// <param name="id">ID zaposlenika</param>
        /// <returns>Employee</returns>
        public static Employee GetEmployee(int id)
        {
            string sql = $"SELECT * FROM Djelatnici WHERE ID = '{id}'";
            return GrabEmployee(sql);
        }
        /// <summary>
        /// Dohvaća zaposlenika iz baze prema upitu
        /// </summary>
        /// <param name="sql">SQL upit</param>
        /// <returns>Employee</returns>
        private static Employee GrabEmployee(string sql)
        {
            Employee employee = null;

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return employee;
        }
        /// <summary>
        /// Kreira objekt zaposlenika
        /// </summary>
        /// <param name="reader">Čitač baze podataka</param>
        /// <returns>Employee</returns>
        private static Employee CreateObject(SqlDataReader reader)
        {
            var employee = new Employee
            {
                Id = int.Parse(reader["ID"].ToString()),
                Name = reader["Ime"].ToString(),
                Surname = reader["Prezime"].ToString(),
                Username = reader["KorisnickoIme"].ToString(),
                Password = reader["Lozinka"].ToString(),
                Email = reader["Email"].ToString()
            };

            return employee;
        } 
    }
}
