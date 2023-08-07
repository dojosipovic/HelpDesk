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
    /// Forma za pregled novih zahtjeva u sustavu
    /// </summary>
    public partial class FrmNewTicketsDetails : Form
    {
        private Ticket ticket;
        public Ticket SelectedTicket { get => ticket; set => ticket = value; }
        public FrmNewTicketsDetails(Ticket selectedTicket)
        {
            InitializeComponent();
            ticket = selectedTicket;
        }

        private void FrmNewTicketsDetails_Load(object sender, EventArgs e)
        {
            Text += " " + SelectedTicket.Id.ToString();
            tbZahtjevBroj.Text = SelectedTicket.Id.ToString();
            tbVrijemeKreiranja.Text = SelectedTicket.CreationTime.ToString();
            tbZahtjevPodnio.Text = SelectedTicket.Creator.ToString();
            tbOpis.Text = SelectedTicket.Description;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            var employee = FrmLogin.LoggedEmployee;
            var ticket = SelectedTicket;
            TicketRepository.AssignTicket(employee, ticket);
            Close();
        }
    }
}
