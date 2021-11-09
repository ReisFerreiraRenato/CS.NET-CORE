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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            llMultiplosLinks.Links.Add(0, 6,"www.google.com.br");
            llMultiplosLinks.Links.Add(9, 5, "www.youtube.com/cfbcursos");
            llMultiplosLinks.Links.Add(17, 7, "www.youtube.com");

            //Desabilitar o link
            llMultiplosLinks.Links[2].Enabled = false;
        }

        private void llCanal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos?nome="+tbNome.Text);
            
            LinkLabel Locll = (LinkLabel)sender;
            Locll.LinkVisited = true;
        }

        private void llCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

            LinkLabel Locll = (LinkLabel)sender;
            Locll.LinkVisited = true;
        }

        private void llMultiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
