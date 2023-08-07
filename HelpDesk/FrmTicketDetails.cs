using HelpDesk.Models;
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
    /// Forma za prikaz detalja zahtjeva
    /// </summary>
    public partial class FrmTicketDetails : Form
    {
        private Ticket ticket;
        public Ticket SelectedTicket { get => ticket; set => ticket = value; }
        public FrmTicketDetails(Ticket selectedTicket)
        {
            InitializeComponent();
            ticket = selectedTicket;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTicketDetails_Load(object sender, EventArgs e)
        {
            Text = "Zahtjev " + SelectedTicket.Id.ToString();
            tbZahtjevBroj.Text = SelectedTicket.Id.ToString();
            tbVrijemeKreiranja.Text = SelectedTicket.CreationTime.ToString();
            tbVrijemePreuzimanja.Text = SelectedTicket.TakingTime != new DateTime(1,1,1,0,0,0) ? SelectedTicket.TakingTime.ToString() : "-";
            tbOpis.Text = SelectedTicket.Description;
            tbZahtjevPreuzeo.Text = SelectedTicket.Taker != null ? SelectedTicket.Taker.ToString() : "-";
            tbKomentar.Text = SelectedTicket.Comment;
            tbStatus.Text = SelectedTicket.Status.ToString();
            tbPrioritet.Text = SelectedTicket.Priority != null ? SelectedTicket.Priority.ToString() : "-";
        }
    }
}
