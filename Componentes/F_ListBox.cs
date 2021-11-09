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
    
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        private void AtualizarListBox(ListBox lb, List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void RestaurarListaCarros()
        {
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");
        }

        public F_ListBox()
        {
            InitializeComponent();

            RestaurarListaCarros();
            lbCarros.DataSource = carros;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbcarros.Text =="")
            {
                MessageBox.Show("Digite um carro");
                tbcarros.Focus();
            }
            else
            {
                carros.Add(tbcarros.Text);
                AtualizarListBox(lbCarros, carros);
                tbcarros.Clear();
                tbcarros.Focus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lbCarros.SelectedIndex);
            AtualizarListBox(lbCarros, carros);
        }

        private void brtnObter_Click(object sender, EventArgs e)
        {
            tbcarros.Text = carros[lbCarros.SelectedIndex];
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizarListBox(lbCarros, carros);
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            RestaurarListaCarros();
            AtualizarListBox(lbCarros, carros);
        }
    }
}
