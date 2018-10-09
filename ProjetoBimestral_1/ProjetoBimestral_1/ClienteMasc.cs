using System;
using System.Collections;
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
    public partial class ClienteMasc : Form
    {
        public ClienteMasc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Confirma Inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SexoMasc masc = new SexoMasc();
                    masc.nome = txtNome.Text;
                    ltbNomes.Items.Add(masc.nome.ToUpper());
                    txtNome.Clear();
                    txtCel.Clear();
                    txtFixo.Clear();
                    txtNasc.Clear();
                    txtLogra.Clear();
                    txtNum.Clear();
                    txtComp.Clear();
                    txtBairro.Clear();
                    txtCid.Clear();
                    txtEst.Clear();
                    txtNome.Focus();
                }
    }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int valor = ltbNomes.SelectedIndex;
            if (valor == -1)
            {
                MessageBox.Show("Selecione o nome para exclusão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(MessageBox.Show("Tem certeza que deseja excluir este nome?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    ltbNomes.Items.RemoveAt(valor);
            }
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            ArrayList ordenar = new ArrayList();
            foreach (var item in ltbNomes.Items)
            {
                ordenar.Add(item);
            }
            ordenar.Sort();
            ltbNomes.Items.Clear();
            foreach (var item in ordenar)
            {
                ltbNomes.Items.Add(item);
            }
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            ArrayList ordenar = new ArrayList();
            foreach (var item in ltbNomes.Items)
            {
                ordenar.Add(item);
            }
            ordenar.Reverse();
            ltbNomes.Items.Clear();
            foreach (var item in ordenar)
            {
                ltbNomes.Items.Add(item);
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLogra_Validating(object sender, CancelEventArgs e)
        {
            if (txtLogra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe a Rua do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
            if (txtNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe o número da casa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBairro_Validating(object sender, CancelEventArgs e)
        {
            if (txtBairro.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe o Bairro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCid_Validating(object sender, CancelEventArgs e)
        {
            if (txtCid.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe o município!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEst_Validating(object sender, CancelEventArgs e)
        {
            if (txtEst.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor, informe o Estado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNasc_Validating(object sender, CancelEventArgs e)
        {
           
        }
    }
}
