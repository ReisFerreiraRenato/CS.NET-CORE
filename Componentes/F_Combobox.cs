using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Combobox : Form
    {
        public F_Combobox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbTransportes.Text);
        }

        private void btnLimparElementos_Click(object sender, EventArgs e)
        {
            cbTransportes.Items.Clear();
            cbTransportes.Text = "";
            tbTransportes.Clear();
        }

        private void btnResetarElementos_Click(object sender, EventArgs e)
        {
            cbTransportes.Items.Clear();
            /*cbTransportes.Items.Add("Carro");
            cbTransportes.Items.Add("Avião");
            cbTransportes.Items.Add("Navio");
            cbTransportes.Items.Add("Ônibus");
            cbTransportes.Items.Add("Trem");*/

            List<string> tr = new List<string>();

            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            cbTransportes.Items.AddRange(tr.ToArray());
        }

        private void cbTransportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTransportes.Text = cbTransportes.Text;
        }

        private void btnAdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tbTransportes.Text != "")
            {
                if (cbTransportes.FindString(tbTransportes.Text) < 0)
                {
                    cbTransportes.Items.Add(tbTransportes.Text);
                    tbTransportes.Clear();
                    tbTransportes.Focus();
                }
                else
                {
                    MessageBox.Show("Elemento "+ tbTransportes.Text + " já existe");
                    tbTransportes.Clear();
                    tbTransportes.Focus();
                }
            }
        }
    }
}
