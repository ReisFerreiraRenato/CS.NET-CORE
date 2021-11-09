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
    public partial class F_ListView : Form
    {
        private void AdicionarProduto()
        {

        }
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbID.Clear();
            tbProduto.Clear();
            tbQuantidade.Clear();
            tbPreco.Clear();
        }

        private void ObterSelecionado()
        {
            Limpar();
            tbID.Text = lvProdutos.SelectedItems[0].SubItems[0].Text;
            tbProduto.Text = lvProdutos.SelectedItems[0].SubItems[1].Text;
            tbQuantidade.Text = lvProdutos.SelectedItems[0].SubItems[2].Text;
            tbPreco.Text = lvProdutos.SelectedItems[0].SubItems[3].Text;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];
            if (tbID.Text == "")
            {
                MessageBox.Show("Favor digitar o ID");
                tbID.Focus();
                return;
            }
            if (tbPreco.Text == "")
            {
                MessageBox.Show("Favor digitar o Preço");
                tbPreco.Focus();
                return;
            }
            if (tbProduto.Text == "")
            {
                MessageBox.Show("Favor digitar o Produto");
                tbProduto.Focus();
                return;
            }
            if (tbQuantidade.Text == "")
            {
                MessageBox.Show("Favor digitar a Quantidade");
                tbQuantidade.Focus();
                return;
            }

            pr[0] = tbID.Text;
            pr[1] = tbProduto.Text;
            pr[2] = tbQuantidade.Text;
            pr[3] = tbPreco.Text;

            ListViewItem l = new ListViewItem(pr);
            lvProdutos.Items.Add(l);
            Limpar();
            tbID.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            lvProdutos.Items.RemoveAt(lvProdutos.SelectedIndices[0]);
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            ObterSelecionado();
        }

        private void lvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count > 0)
            {
                ObterSelecionado();
            }            
        }
    }
}
