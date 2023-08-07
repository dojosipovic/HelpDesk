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
    /// Forma za prikaz prethodnih zahtjeva
    /// </summary>
    public partial class FrmTicketsPrevious : Form
    {
        public FrmTicketsPrevious()
        {
            InitializeComponent();
        }

        private void FrmTicketsPrevious_Load(object sender, EventArgs e)
        {
            ShowPreviousTickets();
        }
        /// <summary>
        /// Prikazuje prethodne zahtjeve korisnika
        /// </summary>
        private void ShowPreviousTickets()
        {
            var previousTickets = TicketRepository.GetPreviousTickets(FrmLogin.LoggedUser);
            dgvPrethodniZahtjevi.DataSource = previousTickets;

            dgvPrethodniZahtjevi.Columns["Comment"].Visible = false;
            dgvPrethodniZahtjevi.Columns["CreationTime"].Visible = false;
            dgvPrethodniZahtjevi.Columns["TakingTime"].Visible = false;
            dgvPrethodniZahtjevi.Columns["Creator"].Visible = false;
            dgvPrethodniZahtjevi.Columns["Taker"].Visible = false;
            dgvPrethodniZahtjevi.Columns["Priority"].Visible = false;

            dgvPrethodniZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvPrethodniZahtjevi.Columns["Taker"].HeaderText = "Djelatnik";
            dgvPrethodniZahtjevi.Columns["Priority"].HeaderText = "Prioritet";
            dgvPrethodniZahtjevi.Columns["Description"].HeaderText = "Opis";

            dgvPrethodniZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvPrethodniZahtjevi.Columns["Taker"].DisplayIndex = 1;
            dgvPrethodniZahtjevi.Columns["Priority"].DisplayIndex = 2;
            dgvPrethodniZahtjevi.Columns["Status"].DisplayIndex = 3;
            dgvPrethodniZahtjevi.Columns["Description"].DisplayIndex = 4;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvPrethodniZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    FrmTicketDetails frmTicketDetails = new FrmTicketDetails(selectedTicket);
                    frmTicketDetails.ShowDialog();
                    ShowPreviousTickets();
                }
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            ShowPreviousTickets();
        }
    }
}
