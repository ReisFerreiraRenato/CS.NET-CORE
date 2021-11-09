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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btnDefinirValor_Click(object sender, EventArgs e)
        {
            if (tbValor.Text!="")
            { 
                if ( (Decimal.Parse(tbValor.Text) >= numericUpDown1.Minimum) &
                    (Decimal.Parse(tbValor.Text) <= numericUpDown1.Maximum) )
                {
                    numericUpDown1.Value = Decimal.Parse(tbValor.Text);
                }
                else
                {
                    MessageBox.Show("Favor digitar o valor dentro do intervalo " + numericUpDown1.Minimum.ToString() + " e " + numericUpDown1.Maximum.ToString(), "Curso C#");
                    tbValor.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Favor digitar o Valor", "Curso C#");
                tbValor.Focus();
            }
        }
    }
}
