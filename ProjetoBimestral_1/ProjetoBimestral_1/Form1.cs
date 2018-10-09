using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBimestral_1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFem_Click(object sender, EventArgs e)
        {
            ClienteFem frm = new ClienteFem();
            frm.ShowDialog();
        }

        private void btnMasc_Click(object sender, EventArgs e)
        {
            ClienteMasc frm1 = new ClienteMasc();
            frm1.ShowDialog();
        }
    }
}
