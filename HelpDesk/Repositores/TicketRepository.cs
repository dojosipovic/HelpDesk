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
    /// Klasa za upravljanje objektima klase Ticket
    /// </summary>
    public class TicketRepository
    {
        /// <summary>
        /// Vraća pretražene nepreuzete zahtjeve prema proslieđenom pojmu
        /// </summary>
        /// <param name="term">Pojam</param>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> SearchTickets(string term)
        {
            var tickets = new List<Ticket>();
            string sql = $"SELECT * FROM Zahtjevi WHERE (Komentar LIKE '%{term}%' OR Opis LIKE '%{term}%') AND Status_ID = 'Z' AND Djelatnik_ID IS NULL";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();

            return tickets;
        }
        /// <summary>
        /// Briše zapis zahtjeva iz baze prema proslieđenom zahtjevu
        /// </summary>
        /// <param name="ticket">Zahtjev</param>
        public static void DeleteTicket(Ticket ticket)
        {
            string sql = $"DELETE FROM Zahtjevi WHERE ID = {ticket.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Vraća sve zahtjeve koje je djelatnik odradio
        /// </summary>
        /// <param name="employee">Djelatnik</param>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> GetFinishedTickets(Employee employee)
        {
            var tickets = new List<Ticket>();
            string sql = $"SELECT * FROM Zahtjevi WHERE Djelatnik_ID = {employee.Id} AND (Status_ID = 'O' OR Status_ID = 'A')";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();

            return tickets;
        }
        /// <summary>
        /// Ažurira preuzet zahtjev djelatnika
        /// </summary>
        /// <param name="id">ID zahtjeva</param>
        /// <param name="comment">Komentar</param>
        /// <param name="statusID">ID statusa</param>
        /// <param name="priorityID">ID prioriteta</param>
        public static void UpdateTicket(int id, string comment, char statusID, char priorityID)
        {
            string sql = $"UPDATE Zahtjevi SET Komentar = '{comment}', Prioritet_ID = '{priorityID}' , Status_ID = '{statusID}' WHERE ID = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Dohvaća preuzete zahtjeve djelatnika iz baze
        /// </summary>
        /// <param name="employee">Djelatniik</param>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> GetTakenTickets(Employee employee)
        {
            var tickets = new List<Ticket>();
            string sql = $"SELECT * FROM Zahtjevi WHERE Djelatnik_ID = {employee.Id} AND Status_ID = 'U'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();


            return tickets;
        }
        /// <summary>
        /// Dodijeluje zahtjev djelatniku
        /// </summary>
        /// <param name="employee">Djelatnik</param>
        /// <param name="ticket">Zahtjev</param>
        public static void AssignTicket(Employee employee, Ticket ticket)
        {
            string sql = $"UPDATE Zahtjevi SET Djelatnik_ID = {employee.Id}, Status_ID = 'U', VrijemePreuzimanja = GETDATE() WHERE ID = {ticket.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Vraća sve nepreuzete zahtjeve u sustavu
        /// </summary>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> GetNonTakenTickets()
        {
            var tickets = new List<Ticket>();
            string sql = "SELECT * FROM Zahtjevi WHERE Djelatnik_ID IS NULL";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();


            return tickets;
        }
        /// <summary>
        /// Dohvaća sve prethodne zahtjeve korisnika koji su završeni ili odbijeni
        /// </summary>
        /// <param name="user">Korisnik</param>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> GetPreviousTickets(User user)
        {
            var tickets = new List<Ticket>();
            string sql = $"SELECT * FROM Zahtjevi WHERE Korisnik_ID = {user.Id} AND (Status_ID = 'O' OR Status_ID = 'A')";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();

            return tickets;
        }
        /// <summary>
        /// Dohvaća aktivne zahtjeve korisnika
        /// </summary>
        /// <param name="user">Korisnik</param>
        /// <returns>Lista zahtjeva</returns>
        public static List<Ticket> GetActiveTickets(User user)
        {
            var tickets = new List<Ticket>();
            string sql = $"SELECT * FROM Zahtjevi WHERE Korisnik_ID = {user.Id} AND (Status_ID = 'Z' OR Status_ID = 'U')";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Ticket ticket = CreateObject(reader);
                tickets.Add(ticket);
            }
            DB.CloseConnection();

            return tickets;
        }
        /// <summary>
        /// Kreira objekt klase Ticket prema proslijeđenom čitaču
        /// </summary>
        /// <param name="reader">Čitač</param>
        /// <returns>Ticket</returns>
        private static Ticket CreateObject(SqlDataReader reader)
        {
            int idUser = int.Parse(reader["Korisnik_ID"].ToString());
            int idEmployee;
            int.TryParse(reader["Djelatnik_ID"].ToString(), out idEmployee);
            char idStatus = char.Parse(reader["Status_ID"].ToString());
            char idPriority;
            char.TryParse(reader["Prioritet_ID"].ToString(), out idPriority);

            int id = int.Parse(reader["ID"].ToString());
            string comment = reader["Komentar"].ToString();
            DateTime creationTime = DateTime.Parse(reader["VrijemeKreiranja"].ToString());
            DateTime takingTime;
            DateTime.TryParse(reader["VrijemePreuzimanja"].ToString(), out takingTime);
            string description = reader["Opis"].ToString();
            User creator = UserRepository.GetUser(idUser);
            Employee taker = EmployeeRepository.GetEmployee(idEmployee);
            Status status = StatusRepository.GetStatus(idStatus);
            Priority priority = PriorityRepository.GetPriority(idPriority);

            var ticket = new Ticket
            {
                Id = id,
                Comment = comment,
                CreationTime = creationTime,
                TakingTime = takingTime,
                Description = description,
                Creator = creator,
                Taker = taker,
                Status = status,
                Priority = priority
            };

            return ticket;
        }

        /// <summary>
        /// Kreira zahtjev korisnika
        /// </summary>
        /// <param name="user">Korisnik</param>
        /// <param name="description">Opis</param>
        public static void CreateTicket(User user, string description)
        {
            string sql = $"INSERT INTO Zahtjevi (VrijemeKreiranja, Opis, Korisnik_ID) VALUES (GETDATE(), '{description}', {user.Id})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
