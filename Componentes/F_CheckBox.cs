﻿using System;
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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp=new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_Carro);
            transp.Add(cb_Aviao);
            transp.Add(cb_Navio);
            transp.Add(cb_Onibus);
            transp.Add(cb_Patinete);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show("Transportes marcados: " + txt);
        }

        private void cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Patinete.Checked)
            {
                MessageBox.Show("Patinte Marcada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
