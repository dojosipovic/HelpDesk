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
    /// Forma za prikaz detalja preuzetog zahtjeva
    /// </summary>
    public partial class FrmTakenTicketDetails : Form
    {
        private Ticket ticket;
        public Ticket SelectedTicket { get => ticket; set => ticket = value; }
        public FrmTakenTicketDetails(Ticket selectedTicket)
        {
            InitializeComponent();
            ticket = selectedTicket;
        }

        private void FrmTakenTicketDetails_Load(object sender, EventArgs e)
        {
            Text += " " + SelectedTicket.Id.ToString();
            tbZahtjevBroj.Text = SelectedTicket.Id.ToString();
            tbVrijemeKreiranja.Text = SelectedTicket.CreationTime.ToString();
            tbVrijemePreuzimanja.Text = SelectedTicket.TakingTime.ToString();
            tbOpis.Text = SelectedTicket.Description;
            tbKomentar.Text = SelectedTicket.Comment;

            cbStatus.DataSource = StatusRepository.GetStatusesForComboBox();
            cbStatus.SelectedIndex = cbStatus.FindStringExact(SelectedTicket.Status.ToString());

            cbPrioritet.DataSource = PriorityRepository.GetPrioritiesForComboBox();
            if (SelectedTicket.Priority != null)
            {
                cbPrioritet.SelectedIndex = cbPrioritet.FindStringExact(SelectedTicket.Priority.ToString());
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var option = DialogResult.Yes;
            var status = cbStatus.SelectedItem as Status;
            var priority = cbPrioritet.SelectedItem as Priority;
            var comment = tbKomentar.Text.Trim();

            if (status.Id == 'O')
            {
                option = MessageBox.Show("Postavljanjem statusa na \"Odbijen\" će zatvoriti ovaj zahtjev. Jeste li sigurni da želite to učiniti?", "Zatvaranje zahtjeva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (status.Id == 'A')
            {
                option = MessageBox.Show("Postavljanjem statusa na \"Zatvoren\" će zatvoriti ovaj zahtjev. Jeste li sigurni da želite to učiniti?", "Zatvaranje zahtjeva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (option == DialogResult.Yes)
            {
                TicketRepository.UpdateTicket(SelectedTicket.Id, comment, status.Id, priority.Id);
                Close();
            }
        }
    }
}
