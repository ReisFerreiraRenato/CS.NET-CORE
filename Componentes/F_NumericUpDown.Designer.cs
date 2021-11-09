
namespace Componentes
{
    partial class F_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnDefinirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(221, 30);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(262, 45);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 30);
            this.tbValor.TabIndex = 1;
            // 
            // btnDefinirValor
            // 
            this.btnDefinirValor.Location = new System.Drawing.Point(379, 45);
            this.btnDefinirValor.Name = "btnDefinirValor";
            this.btnDefinirValor.Size = new System.Drawing.Size(194, 30);
            this.btnDefinirValor.TabIndex = 2;
            this.btnDefinirValor.Text = "Definir Valor";
            this.btnDefinirValor.UseVisualStyleBackColor = true;
            this.btnDefinirValor.Click += new System.EventHandler(this.btnDefinirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 374);
            this.Controls.Add(this.btnDefinirValor);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnDefinirValor;
    }
}