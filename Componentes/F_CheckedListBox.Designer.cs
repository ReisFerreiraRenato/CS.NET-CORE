
namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_Transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.btn_AddNovoTransporte = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Transportes
            // 
            this.clb_Transportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Transportes.FormattingEnabled = true;
            this.clb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_Transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_Transportes.Name = "clb_Transportes";
            this.clb_Transportes.Size = new System.Drawing.Size(185, 329);
            this.clb_Transportes.TabIndex = 0;
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(203, 12);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(231, 33);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(203, 51);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(231, 37);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar Lista";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetarLista.Location = new System.Drawing.Point(203, 94);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(231, 37);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // btn_AddNovoTransporte
            // 
            this.btn_AddNovoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNovoTransporte.Location = new System.Drawing.Point(203, 268);
            this.btn_AddNovoTransporte.Name = "btn_AddNovoTransporte";
            this.btn_AddNovoTransporte.Size = new System.Drawing.Size(231, 37);
            this.btn_AddNovoTransporte.TabIndex = 4;
            this.btn_AddNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_AddNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AddNovoTransporte.Click += new System.EventHandler(this.btn_AddNovoTransporte_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NovoTransporte.Location = new System.Drawing.Point(203, 311);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(231, 30);
            this.tb_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o Novo Transporte:";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_AddNovoTransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.clb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.Button btn_AddNovoTransporte;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}