using HelpDesk.Models;
using HelpDesk.Repositores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    /// <summary>
    /// Forma za prikaz završenih zahtjeva
    /// </summary>
    public partial class FrmTicketsFinished : Form
    {
        public FrmTicketsFinished()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTicketsFinished_Load(object sender, EventArgs e)
        {
            ShowFinishedTickets();
        }
        /// <summary>
        /// Prikazuje završene zahtjeve djelatnika
        /// </summary>
        private void ShowFinishedTickets()
        {
            var employee = FrmLogin.LoggedEmployee;
            dgvZavrseniZahtjevi.DataSource = TicketRepository.GetFinishedTickets(employee);

            dgvZavrseniZahtjevi.Columns["Comment"].Visible = false;
            dgvZavrseniZahtjevi.Columns["CreationTime"].Visible = false;
            dgvZavrseniZahtjevi.Columns["TakingTime"].Visible = false;
            dgvZavrseniZahtjevi.Columns["Priority"].Visible = false;
            dgvZavrseniZahtjevi.Columns["Taker"].Visible = false;
            dgvZavrseniZahtjevi.Columns["Status"].Visible = false;

            dgvZavrseniZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvZavrseniZahtjevi.Columns["Description"].HeaderText = "Opis";
            dgvZavrseniZahtjevi.Columns["Creator"].HeaderText = "Korisnik";

            dgvZavrseniZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvZavrseniZahtjevi.Columns["Creator"].DisplayIndex = 1;
            dgvZavrseniZahtjevi.Columns["Description"].DisplayIndex = 2;
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            ShowFinishedTickets();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvZavrseniZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    FrmTicketDetails frmTicketDetails = new FrmTicketDetails(selectedTicket);
                    frmTicketDetails.ShowDialog();
                    ShowFinishedTickets();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvZavrseniZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    TicketRepository.DeleteTicket(selectedTicket);
                    ShowFinishedTickets();
                }
            }
        }
    }
}
