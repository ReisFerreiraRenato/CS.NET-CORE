
namespace Componentes
{
    partial class F_CheckBox
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
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.btn_TransportesMarcados = new System.Windows.Forms.Button();
            this.cb_Patinete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Carro.Location = new System.Drawing.Point(41, 47);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(83, 29);
            this.cb_Carro.TabIndex = 0;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Aviao.Location = new System.Drawing.Point(41, 74);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(84, 29);
            this.cb_Aviao.TabIndex = 1;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Navio.Location = new System.Drawing.Point(41, 101);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(84, 29);
            this.cb_Navio.TabIndex = 2;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Onibus.Location = new System.Drawing.Point(41, 128);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(97, 29);
            this.cb_Onibus.TabIndex = 3;
            this.cb_Onibus.Text = "Ônibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // btn_TransportesMarcados
            // 
            this.btn_TransportesMarcados.Location = new System.Drawing.Point(156, 47);
            this.btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            this.btn_TransportesMarcados.Size = new System.Drawing.Size(292, 23);
            this.btn_TransportesMarcados.TabIndex = 4;
            this.btn_TransportesMarcados.Text = "Transportes Marcados";
            this.btn_TransportesMarcados.UseVisualStyleBackColor = true;
            this.btn_TransportesMarcados.Click += new System.EventHandler(this.btn_TransportesMarcados_Click);
            // 
            // cb_Patinete
            // 
            this.cb_Patinete.AutoSize = true;
            this.cb_Patinete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Patinete.Location = new System.Drawing.Point(41, 155);
            this.cb_Patinete.Name = "cb_Patinete";
            this.cb_Patinete.Size = new System.Drawing.Size(105, 29);
            this.cb_Patinete.TabIndex = 5;
            this.cb_Patinete.Text = "Patinete";
            this.cb_Patinete.UseVisualStyleBackColor = true;
            this.cb_Patinete.CheckedChanged += new System.EventHandler(this.cb_Patinete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir Form Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Patinete);
            this.Controls.Add(this.btn_TransportesMarcados);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TransportesMarcados;
        public System.Windows.Forms.CheckBox cb_Carro;
        public System.Windows.Forms.CheckBox cb_Aviao;
        public System.Windows.Forms.CheckBox cb_Navio;
        public System.Windows.Forms.CheckBox cb_Onibus;
        public System.Windows.Forms.CheckBox cb_Patinete;
        private System.Windows.Forms.Button button1;
    }
}