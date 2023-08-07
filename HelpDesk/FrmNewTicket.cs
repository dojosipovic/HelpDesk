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
    /// Forma za kreiranje novog zahtjeva
    /// </summary>
    public partial class FrmNewTicket : Form
    {
        public FrmNewTicket()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            string description = tbOpis.Text.Trim();
            var user = FrmLogin.LoggedUser;

            if (description.Length == 0 )
            {
                MessageBox.Show("Opis zahtjeva ne može biti prazan!", "Opis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TicketRepository.CreateTicket(user,description);
                Close();
            }
        }
    }
}
