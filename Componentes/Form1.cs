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
    public partial class F_Principal : Form
    {
        public int num;

        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();
                return;
            }
            tb_ListaVeiculos.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void F_Principal_Shown(object sender, EventArgs e)
        {
            tb_veiculo.Focus();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tb_ListaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* String Nome="";
            for (int i=0;i<=Lista.Count;i++)
            {
                Nome += Lista[i] + ", ";
            }
            MessageBox.Show(Nome);*/
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_ListaVeiculos.Text,this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void CheckedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Combobox f_Combobox = new F_Combobox();
            f_Combobox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void mAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*if(e.ClickedItem.Name.ToString() == "tsmiFechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmiRestaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmiMensagem")
            {
                MessageBox.Show("Curso de C#", "Curso");
            }*/
        }

        private void tsmiFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso de C#", "Curso");
        }

        private void tsmiRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }
    }
}
