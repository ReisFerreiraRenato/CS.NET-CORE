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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string t in clb_Transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            
            MessageBox.Show(txt);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
            //object carro = "Carro";
            //clb_Transportes.Items.Add(carro, false);
            /*clb_Transportes.Items.Clear();
            clb_Transportes.Items.Add("Carro", false);
            clb_Transportes.Items.Add("Avião", false);
            clb_Transportes.Items.Add("Navio", false);
            clb_Transportes.Items.Add("Ônibus", false);
            clb_Transportes.Items.Add("Trem", false);*/

            List<string> tr = new List<string>();

            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_Transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_AddNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_NovoTransporte.Text != "")
            {
                clb_Transportes.Items.Add(tb_NovoTransporte.Text);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            }
            else
            {
                MessageBox.Show("Digite o nome do transporte");
                tb_NovoTransporte.Focus();
            }
        }
    }
}
