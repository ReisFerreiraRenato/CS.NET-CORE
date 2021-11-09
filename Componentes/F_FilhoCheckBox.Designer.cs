
namespace Componentes
{
    partial class F_FilhoCheckBox
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
            this.cb_Patinete = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Patinete
            // 
            this.cb_Patinete.AutoSize = true;
            this.cb_Patinete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Patinete.Location = new System.Drawing.Point(37, 132);
            this.cb_Patinete.Name = "cb_Patinete";
            this.cb_Patinete.Size = new System.Drawing.Size(105, 29);
            this.cb_Patinete.TabIndex = 10;
            this.cb_Patinete.Text = "Patinete";
            this.cb_Patinete.UseVisualStyleBackColor = true;
            this.cb_Patinete.CheckedChanged += new System.EventHandler(this.cb_Patinete_CheckedChanged);
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Onibus.Location = new System.Drawing.Point(37, 105);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(97, 29);
            this.cb_Onibus.TabIndex = 9;
            this.cb_Onibus.Text = "Ônibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            this.cb_Onibus.CheckedChanged += new System.EventHandler(this.cb_Onibus_CheckedChanged);
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Navio.Location = new System.Drawing.Point(37, 78);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(84, 29);
            this.cb_Navio.TabIndex = 8;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            this.cb_Navio.CheckedChanged += new System.EventHandler(this.cb_Navio_CheckedChanged);
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Aviao.Location = new System.Drawing.Point(37, 51);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(84, 29);
            this.cb_Aviao.TabIndex = 7;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            this.cb_Aviao.CheckedChanged += new System.EventHandler(this.cb_Aviao_CheckedChanged);
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Carro.Location = new System.Drawing.Point(37, 24);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(83, 29);
            this.cb_Carro.TabIndex = 6;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            this.cb_Carro.CheckedChanged += new System.EventHandler(this.cb_Carro_CheckedChanged);
            // 
            // F_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.cb_Patinete);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Carro);
            this.Name = "F_FilhoCheckBox";
            this.Text = "F_FilhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cb_Patinete;
        public System.Windows.Forms.CheckBox cb_Onibus;
        public System.Windows.Forms.CheckBox cb_Navio;
        public System.Windows.Forms.CheckBox cb_Aviao;
        public System.Windows.Forms.CheckBox cb_Carro;
    }
}