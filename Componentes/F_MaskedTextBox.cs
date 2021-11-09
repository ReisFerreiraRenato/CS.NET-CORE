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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (cbSomenteTexto.Checked)
            {
                tbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                tbCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            String msg = tbCPF.Text;
            MessageBox.Show(msg);
        }

        private void btSenha_Click(object sender, EventArgs e)
        {
            if (cbMascara.Checked)
            {
                tbSenha.PasswordChar = '*';
            }
            else
            {
                tbSenha.PasswordChar = '\u0000';
            }
        }
    }
}
