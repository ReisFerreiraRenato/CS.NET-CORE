
namespace Componentes
{
    partial class F_ListBox
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
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbcarros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.brtnObter = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCarros
            // 
            this.lbCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.ItemHeight = 25;
            this.lbCarros.Location = new System.Drawing.Point(18, 19);
            this.lbCarros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(274, 479);
            this.lbCarros.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(322, 102);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(321, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbcarros
            // 
            this.tbcarros.Location = new System.Drawing.Point(322, 62);
            this.tbcarros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcarros.Name = "tbcarros";
            this.tbcarros.Size = new System.Drawing.Size(321, 30);
            this.tbcarros.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carro";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(322, 148);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(321, 36);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // brtnObter
            // 
            this.brtnObter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brtnObter.Location = new System.Drawing.Point(322, 194);
            this.brtnObter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brtnObter.Name = "brtnObter";
            this.brtnObter.Size = new System.Drawing.Size(321, 36);
            this.brtnObter.TabIndex = 5;
            this.brtnObter.Text = "Obter";
            this.brtnObter.UseVisualStyleBackColor = true;
            this.brtnObter.Click += new System.EventHandler(this.brtnObter_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(322, 240);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(321, 36);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.Location = new System.Drawing.Point(322, 286);
            this.btRestaurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(321, 36);
            this.btRestaurar.TabIndex = 7;
            this.btRestaurar.Text = "Restaurar";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 518);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.brtnObter);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcarros);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbCarros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCarros;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbcarros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button brtnObter;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btRestaurar;
    }
}