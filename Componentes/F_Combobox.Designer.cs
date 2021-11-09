
namespace Componentes
{
    partial class F_Combobox
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
            this.cbTransportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.btnLimparElementos = new System.Windows.Forms.Button();
            this.btnResetarElementos = new System.Windows.Forms.Button();
            this.btnAdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.tbTransportes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbTransportes
            // 
            this.cbTransportes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransportes.FormattingEnabled = true;
            this.cbTransportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cbTransportes.Location = new System.Drawing.Point(12, 12);
            this.cbTransportes.Name = "cbTransportes";
            this.cbTransportes.Size = new System.Drawing.Size(279, 31);
            this.cbTransportes.TabIndex = 0;
            this.cbTransportes.SelectedIndexChanged += new System.EventHandler(this.cbTransportes_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionado
            // 
            this.btn_MostrarSelecionado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarSelecionado.Location = new System.Drawing.Point(309, 12);
            this.btn_MostrarSelecionado.Name = "btn_MostrarSelecionado";
            this.btn_MostrarSelecionado.Size = new System.Drawing.Size(274, 31);
            this.btn_MostrarSelecionado.TabIndex = 1;
            this.btn_MostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionado.Click += new System.EventHandler(this.btn_MostrarSelecionado_Click);
            // 
            // btnLimparElementos
            // 
            this.btnLimparElementos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparElementos.Location = new System.Drawing.Point(309, 54);
            this.btnLimparElementos.Name = "btnLimparElementos";
            this.btnLimparElementos.Size = new System.Drawing.Size(274, 33);
            this.btnLimparElementos.TabIndex = 2;
            this.btnLimparElementos.Text = "Limpar Elementos";
            this.btnLimparElementos.UseVisualStyleBackColor = true;
            this.btnLimparElementos.Click += new System.EventHandler(this.btnLimparElementos_Click);
            // 
            // btnResetarElementos
            // 
            this.btnResetarElementos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetarElementos.Location = new System.Drawing.Point(309, 93);
            this.btnResetarElementos.Name = "btnResetarElementos";
            this.btnResetarElementos.Size = new System.Drawing.Size(274, 34);
            this.btnResetarElementos.TabIndex = 3;
            this.btnResetarElementos.Text = "Resetar Elementos";
            this.btnResetarElementos.UseVisualStyleBackColor = true;
            this.btnResetarElementos.Click += new System.EventHandler(this.btnResetarElementos_Click);
            // 
            // btnAdicionarNovoTransporte
            // 
            this.btnAdicionarNovoTransporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNovoTransporte.Location = new System.Drawing.Point(309, 169);
            this.btnAdicionarNovoTransporte.Name = "btnAdicionarNovoTransporte";
            this.btnAdicionarNovoTransporte.Size = new System.Drawing.Size(274, 34);
            this.btnAdicionarNovoTransporte.TabIndex = 4;
            this.btnAdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btnAdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btnAdicionarNovoTransporte.Click += new System.EventHandler(this.btnAdicionarNovoTransporte_Click);
            // 
            // tbTransportes
            // 
            this.tbTransportes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransportes.Location = new System.Drawing.Point(309, 133);
            this.tbTransportes.Name = "tbTransportes";
            this.tbTransportes.Size = new System.Drawing.Size(274, 30);
            this.tbTransportes.TabIndex = 5;
            // 
            // F_Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.tbTransportes);
            this.Controls.Add(this.btnAdicionarNovoTransporte);
            this.Controls.Add(this.btnResetarElementos);
            this.Controls.Add(this.btnLimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionado);
            this.Controls.Add(this.cbTransportes);
            this.MaximizeBox = false;
            this.Name = "F_Combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTransportes;
        private System.Windows.Forms.Button btn_MostrarSelecionado;
        private System.Windows.Forms.Button btnLimparElementos;
        private System.Windows.Forms.Button btnResetarElementos;
        private System.Windows.Forms.Button btnAdicionarNovoTransporte;
        private System.Windows.Forms.TextBox tbTransportes;
    }
}