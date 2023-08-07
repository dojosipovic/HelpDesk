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
    /// Početna forma zaposlenika nakon prijave
    /// </summary>
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            ShowTakenTickets();
            ShowNonTakenTickets();
        }
        /// <summary>
        /// Prikazuje preuzete zahtjeve prijavljenog zaposlenika
        /// </summary>
        private void ShowTakenTickets()
        {
            var employee = FrmLogin.LoggedEmployee;
            var tickets = TicketRepository.GetTakenTickets(employee);

            dgvPreuzetiZahtjevi.DataSource = tickets;

            dgvPreuzetiZahtjevi.Columns["Comment"].Visible = false;
            dgvPreuzetiZahtjevi.Columns["CreationTime"].Visible = false;
            dgvPreuzetiZahtjevi.Columns["TakingTime"].Visible = false;
            dgvPreuzetiZahtjevi.Columns["Priority"].Visible = false;
            dgvPreuzetiZahtjevi.Columns["Taker"].Visible = false;
            dgvPreuzetiZahtjevi.Columns["Status"].Visible = false;

            dgvPreuzetiZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvPreuzetiZahtjevi.Columns["Description"].HeaderText = "Opis";
            dgvPreuzetiZahtjevi.Columns["Creator"].HeaderText = "Korisnik";

            dgvPreuzetiZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvPreuzetiZahtjevi.Columns["Creator"].DisplayIndex = 1;
            dgvPreuzetiZahtjevi.Columns["Description"].DisplayIndex = 2;
        }
        /// <summary>
        /// Prikazuje nepreuzete zahtjeve
        /// </summary>
        private void ShowNonTakenTickets()
        {
            var tickets = TicketRepository.GetNonTakenTickets();
            dgvNoviZahtjevi.DataSource = tickets;

            dgvNoviZahtjevi.Columns["Comment"].Visible = false;
            dgvNoviZahtjevi.Columns["CreationTime"].Visible = false;
            dgvNoviZahtjevi.Columns["TakingTime"].Visible = false;
            dgvNoviZahtjevi.Columns["Priority"].Visible = false;
            dgvNoviZahtjevi.Columns["Taker"].Visible = false;
            dgvNoviZahtjevi.Columns["Status"].Visible = false;

            dgvNoviZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvNoviZahtjevi.Columns["Description"].HeaderText = "Opis";
            dgvNoviZahtjevi.Columns["Creator"].HeaderText = "Korisnik";

            dgvNoviZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvNoviZahtjevi.Columns["Creator"].DisplayIndex = 1;
            dgvNoviZahtjevi.Columns["Description"].DisplayIndex = 2;
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            ShowTakenTickets();
            ShowNonTakenTickets();
        }

        private void btnDetaljiNovi_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvNoviZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    FrmNewTicketsDetails frmNewTicketsDetails = new FrmNewTicketsDetails(selectedTicket);
                    frmNewTicketsDetails.ShowDialog();
                    ShowNonTakenTickets();
                    ShowTakenTickets();
                }
            }
        }

        private void btnDetaljiPreuzeti_Click(object sender, EventArgs e)
        {
            var dgvCurrentRow = dgvPreuzetiZahtjevi.CurrentRow;
            if (dgvCurrentRow != null)
            {
                Ticket selectedTicket = dgvCurrentRow.DataBoundItem as Ticket;
                if (selectedTicket != null)
                {
                    FrmTakenTicketDetails frmTakenTicketDetails = new FrmTakenTicketDetails(selectedTicket);
                    frmTakenTicketDetails.ShowDialog();
                    ShowNonTakenTickets();
                    ShowTakenTickets();
                }
            }
        }

        private void btnZavrseniZahtjevi_Click(object sender, EventArgs e)
        {
            FrmTicketsFinished frmTicketsFinished = new FrmTicketsFinished();
            frmTicketsFinished.ShowDialog();
            ShowNonTakenTickets();
            ShowTakenTickets();
        }

        private void tbPretrazi_KeyUp(object sender, KeyEventArgs e)
        {
            var searchTerm = tbPretrazi.Text.Trim();
            tbPretrazi.Text = searchTerm;

            var tickets = TicketRepository.SearchTickets(searchTerm);
            dgvNoviZahtjevi.DataSource = tickets;

            dgvNoviZahtjevi.Columns["Comment"].Visible = false;
            dgvNoviZahtjevi.Columns["CreationTime"].Visible = false;
            dgvNoviZahtjevi.Columns["TakingTime"].Visible = false;
            dgvNoviZahtjevi.Columns["Priority"].Visible = false;
            dgvNoviZahtjevi.Columns["Taker"].Visible = false;
            dgvNoviZahtjevi.Columns["Status"].Visible = false;

            dgvNoviZahtjevi.Columns["Id"].HeaderText = "Br.";
            dgvNoviZahtjevi.Columns["Description"].HeaderText = "Opis";
            dgvNoviZahtjevi.Columns["Creator"].HeaderText = "Korisnik";

            dgvNoviZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvNoviZahtjevi.Columns["Creator"].DisplayIndex = 1;
            dgvNoviZahtjevi.Columns["Description"].DisplayIndex = 2;
        }
    }
}
