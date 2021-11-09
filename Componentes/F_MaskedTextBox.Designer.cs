
namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.tbSenha = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSomenteTexto = new System.Windows.Forms.CheckBox();
            this.btSenha = new System.Windows.Forms.Button();
            this.cbMascara = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(28, 38);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(329, 30);
            this.tbSenha.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(28, 118);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox2.Mask = "00000-000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(113, 30);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(28, 209);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(149, 30);
            this.tbCPF.TabIndex = 3;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(28, 277);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox3.Mask = "00.000.000/0000-0";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(176, 30);
            this.maskedTextBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSomenteTexto
            // 
            this.cbSomenteTexto.AutoSize = true;
            this.cbSomenteTexto.Location = new System.Drawing.Point(184, 211);
            this.cbSomenteTexto.Name = "cbSomenteTexto";
            this.cbSomenteTexto.Size = new System.Drawing.Size(168, 29);
            this.cbSomenteTexto.TabIndex = 9;
            this.cbSomenteTexto.Text = "Somente Texto";
            this.cbSomenteTexto.UseVisualStyleBackColor = true;
            // 
            // btSenha
            // 
            this.btSenha.Location = new System.Drawing.Point(538, 38);
            this.btSenha.Name = "btSenha";
            this.btSenha.Size = new System.Drawing.Size(161, 30);
            this.btSenha.TabIndex = 10;
            this.btSenha.Text = "Exibir";
            this.btSenha.UseVisualStyleBackColor = true;
            this.btSenha.Click += new System.EventHandler(this.btSenha_Click);
            // 
            // cbMascara
            // 
            this.cbMascara.AutoSize = true;
            this.cbMascara.Location = new System.Drawing.Point(364, 40);
            this.cbMascara.Name = "cbMascara";
            this.cbMascara.Size = new System.Drawing.Size(110, 29);
            this.cbMascara.TabIndex = 11;
            this.cbMascara.Text = "Mascara";
            this.cbMascara.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 452);
            this.Controls.Add(this.cbMascara);
            this.Controls.Add(this.btSenha);
            this.Controls.Add(this.cbSomenteTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.tbSenha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbSomenteTexto;
        private System.Windows.Forms.Button btSenha;
        private System.Windows.Forms.CheckBox cbMascara;
    }
}