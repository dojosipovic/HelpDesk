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
    /// Klasa za upravljenje objekata klasa Priority
    /// </summary>
    public class PriorityRepository
    {
        /// <summary>
        /// Vraća sve moguće statuse za popunjavanje ComboBoxa
        /// </summary>
        /// <returns>Lista objekata klase Priority</returns>
        public static List<Priority> GetPrioritiesForComboBox()
        {
            var priorityList = new List<Priority>();
            string sql = "SELECT * FROM Prioriteti";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Priority priority = CreateObject(reader);
                priorityList.Add(priority);
            }
            DB.CloseConnection();

            return priorityList;
        }
        /// <summary>
        /// Vraća prioritet prema proslijeđenom ID-u
        /// </summary>
        /// <param name="id">ID prioriteta</param>
        /// <returns>Priority</returns>
        public static Priority GetPriority(char id)
        {
            string sql = $"SELECT * FROM Prioriteti WHERE ID = '{id}'";
            return GrabPriority(sql);
        }
        /// <summary>
        /// Dohvaća prioritet prema prosliđenom SQL upitu
        /// </summary>
        /// <param name="sql">SQL upit</param>
        /// <returns>Priority</returns>
        private static Priority GrabPriority(string sql)
        {
            Priority priority = null;

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                reader.Read();
                priority = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return priority;
        }
        /// <summary>
        /// Kreira objekt klase Priority prema proslijeđenom čitaču iz baze
        /// </summary>
        /// <param name="reader">Čitač</param>
        /// <returns>Priority</returns>
        private static Priority CreateObject(SqlDataReader reader)
        {
            var priority = new Priority
            {
                Id = char.Parse(reader["ID"].ToString()),
                Name = reader["Naziv"].ToString()
            };

            return priority;
        }
    }
}
