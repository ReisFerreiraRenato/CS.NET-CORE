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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }


        private void btnObterData_Click(object sender, EventArgs e)
        {
            tbData.Text = dtpData.Text;
            tbDia.Text = dtpData.Value.Day.ToString();
            tbMes.Text = dtpData.Value.Month.ToString();
            tbAno.Text = dtpData.Value.Year.ToString();
        }

        private void btnSetarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tbDia.Text);
            m = Int32.Parse(tbMes.Text);
            a = Int32.Parse(tbAno.Text);

            DateTime dt = new DateTime( a, m, d);

            dtpData.Value = dt;



        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Today;
        }
    }
}
