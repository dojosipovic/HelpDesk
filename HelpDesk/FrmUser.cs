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
    /// Početna forma nakon prijave korisnika
    /// </summary>
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            ShowActiveTickets();
        }
        /// <summary>
        /// Prikaz aktivnih zahtjeva
        /// </summary>
        private void ShowActiveTickets()
        {
            var tickets = TicketRepository.GetActiveTickets(FrmLogin.LoggedUser);
            dgvAktivniZahtjevi.DataSource = tickets;

            dgvAktivniZahtjevi.Columns["Comment"].Visible = false;
            dgvAktivniZahtjevi.Columns["CreationTime"].Visible = false;
            dgvAktivniZahtjevi.Columns["TakingTime"].Visible = false;
            dgvAktivniZahtjevi.Columns["Creator"].Visible = false;
            dgvAktivniZahtjevi.Columns["Taker"].Visible = false;
            dgvAktivniZahtjevi.Columns["Priority"].Visible = false;

            dgvAktivniZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvAktivniZahtjevi.Columns["Taker"].HeaderText = "Djelatnik";
            dgvAktivniZahtjevi.Columns["Priority"].HeaderText = "Prioritet";
            dgvAktivniZahtjevi.Columns["Description"].HeaderText = "Opis";

            dgvAktivniZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvAktivniZahtjevi.Columns["Taker"].DisplayIndex = 1;
            dgvAktivniZahtjevi.Columns["Priority"].DisplayIndex = 2;
            dgvAktivniZahtjevi.Columns["Status"].DisplayIndex = 3;
            dgvAktivniZahtjevi.Columns["Description"].DisplayIndex = 4;
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            FrmNewTicket frmNewTicket = new FrmNewTicket();
            frmNewTicket.Text = FrmLogin.LoggedUser.ToString();
            frmNewTicket.ShowDialog();
            ShowActiveTickets();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvAktivniZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    FrmTicketDetails frmTicketDetails = new FrmTicketDetails(selectedTicket);
                    frmTicketDetails.ShowDialog();
                    ShowActiveTickets();
                }
            }
        }

        private void btnPrethodniZahtjevi_Click(object sender, EventArgs e)
        {
            FrmTicketsPrevious frmTicketsPrevious = new FrmTicketsPrevious();
            frmTicketsPrevious.Text += " - " + FrmLogin.LoggedUser.ToString();
            frmTicketsPrevious.ShowDialog();
            ShowActiveTickets();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            ShowActiveTickets();
        }
    }
}
