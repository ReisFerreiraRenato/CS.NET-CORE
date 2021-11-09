
namespace Componentes
{
    partial class F_LinkLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.llCanal = new System.Windows.Forms.LinkLabel();
            this.llCalculadora = new System.Windows.Forms.LinkLabel();
            this.llMultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 69);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(423, 30);
            this.tbNome.TabIndex = 1;
            // 
            // llCanal
            // 
            this.llCanal.AutoSize = true;
            this.llCanal.Location = new System.Drawing.Point(19, 140);
            this.llCanal.Name = "llCanal";
            this.llCanal.Size = new System.Drawing.Size(60, 23);
            this.llCanal.TabIndex = 2;
            this.llCanal.TabStop = true;
            this.llCanal.Text = "Canal";
            this.llCanal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCanal_LinkClicked);
            // 
            // llCalculadora
            // 
            this.llCalculadora.AutoSize = true;
            this.llCalculadora.Location = new System.Drawing.Point(122, 140);
            this.llCalculadora.Name = "llCalculadora";
            this.llCalculadora.Size = new System.Drawing.Size(114, 23);
            this.llCalculadora.TabIndex = 3;
            this.llCalculadora.TabStop = true;
            this.llCalculadora.Text = "Calculadora";
            this.llCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalculadora_LinkClicked);
            // 
            // llMultiplosLinks
            // 
            this.llMultiplosLinks.AutoSize = true;
            this.llMultiplosLinks.Location = new System.Drawing.Point(19, 287);
            this.llMultiplosLinks.Name = "llMultiplosLinks";
            this.llMultiplosLinks.Size = new System.Drawing.Size(233, 23);
            this.llMultiplosLinks.TabIndex = 4;
            this.llMultiplosLinks.TabStop = true;
            this.llMultiplosLinks.Text = "Google - Canal - Youtube";
            this.llMultiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMultiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 647);
            this.Controls.Add(this.llMultiplosLinks);
            this.Controls.Add(this.llCalculadora);
            this.Controls.Add(this.llCanal);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.LinkLabel llCanal;
        private System.Windows.Forms.LinkLabel llCalculadora;
        private System.Windows.Forms.LinkLabel llMultiplosLinks;
    }
}