using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk.Repositores
{
    /// <summary>
    /// Klasa za upravljanje objektima klase Status
    /// </summary>
    public class StatusRepository
    {
        /// <summary>
        /// Vraća moguće statuse zahtjeva za ComboBox koje djelatnik može dodijeliti zahtjevu
        /// </summary>
        /// <returns>Lista objekata klase Status</returns>
        public static List<Status> GetStatusesForComboBox()
        {
            var statusList = new List<Status>();
            string sql = $"SELECT * FROM Statusi WHERE Id != 'Z'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Status status = CreateObject(reader);
                statusList.Add(status);
            }
            DB.CloseConnection();

            return statusList;
        }
        /// <summary>
        /// Vraća status prema proslijeđenom ID-u statusa
        /// </summary>
        /// <param name="id">ID statusa</param>
        /// <returns>Status</returns>
        public static Status GetStatus(char id)
        {
            string sql = $"SELECT * FROM Statusi WHERE Id = '{id}'";
            return GrabStatus(sql);
        }
        /// <summary>
        /// Dohvaća status prema proslijeđenom SQL upitu
        /// </summary>
        /// <param name="sql">SQL upit</param>
        /// <returns>Status</returns>
        private static Status GrabStatus(string sql)
        {
            Status status = null;

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows == true)
            {
                reader.Read();
                status = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return status;
        }
        /// <summary>
        /// Kreira objekt statusa prema proslijeđenom čitaču
        /// </summary>
        /// <param name="reader">Čitač</param>
        /// <returns>Status</returns>
        private static Status CreateObject(SqlDataReader reader)
        {
            var status = new Status
            {
                Id = char.Parse(reader["Id"].ToString()),
                Name = reader["Naziv"].ToString()
            };

            return status;
        }
    }
}
