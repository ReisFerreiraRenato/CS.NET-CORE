
namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnObterData = new System.Windows.Forms.Button();
            this.btnSetarData = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btnHoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(16, 17);
            this.dtpData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(403, 30);
            this.dtpData.TabIndex = 0;
            // 
            // btnObterData
            // 
            this.btnObterData.Location = new System.Drawing.Point(427, 17);
            this.btnObterData.Name = "btnObterData";
            this.btnObterData.Size = new System.Drawing.Size(243, 30);
            this.btnObterData.TabIndex = 1;
            this.btnObterData.Text = "Obter Data";
            this.btnObterData.UseVisualStyleBackColor = true;
            this.btnObterData.Click += new System.EventHandler(this.btnObterData_Click);
            // 
            // btnSetarData
            // 
            this.btnSetarData.Location = new System.Drawing.Point(427, 91);
            this.btnSetarData.Name = "btnSetarData";
            this.btnSetarData.Size = new System.Drawing.Size(243, 30);
            this.btnSetarData.TabIndex = 2;
            this.btnSetarData.Text = "Setar Data";
            this.btnSetarData.UseVisualStyleBackColor = true;
            this.btnSetarData.Click += new System.EventHandler(this.btnSetarData_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(16, 54);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(403, 30);
            this.tbData.TabIndex = 5;
            // 
            // tbDia
            // 
            this.tbDia.Location = new System.Drawing.Point(16, 91);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(130, 30);
            this.tbDia.TabIndex = 6;
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(152, 91);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(130, 30);
            this.tbMes.TabIndex = 7;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(288, 91);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(130, 30);
            this.tbAno.TabIndex = 8;
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(427, 127);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(243, 30);
            this.btnHoje.TabIndex = 9;
            this.btnHoje.Text = "Hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.btnHoje);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnSetarData);
            this.Controls.Add(this.btnObterData);
            this.Controls.Add(this.dtpData);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnObterData;
        private System.Windows.Forms.Button btnSetarData;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btnHoje;
    }
}