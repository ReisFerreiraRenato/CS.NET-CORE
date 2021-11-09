
namespace Componentes
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.tb_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_valnum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(251, 66);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(106, 38);
            this.btn_Adicionar.TabIndex = 0;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_veiculo.Location = new System.Drawing.Point(11, 69);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(233, 30);
            this.tb_veiculo.TabIndex = 1;
            // 
            // tb_ListaVeiculos
            // 
            this.tb_ListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ListaVeiculos.Location = new System.Drawing.Point(9, 105);
            this.tb_ListaVeiculos.Multiline = true;
            this.tb_ListaVeiculos.Name = "tb_ListaVeiculos";
            this.tb_ListaVeiculos.ReadOnly = true;
            this.tb_ListaVeiculos.Size = new System.Drawing.Size(349, 340);
            this.tb_ListaVeiculos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um veículo";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(9, 446);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(348, 54);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exibir Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(11, 501);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(348, 54);
            this.btn_Mostrar.TabIndex = 6;
            this.btn_Mostrar.Text = "Mostrar Veículos";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_valnum
            // 
            this.btn_valnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valnum.Location = new System.Drawing.Point(11, 556);
            this.btn_valnum.Name = "btn_valnum";
            this.btn_valnum.Size = new System.Drawing.Size(348, 56);
            this.btn_valnum.TabIndex = 7;
            this.btn_valnum.Text = "Valor da variável num";
            this.btn_valnum.UseVisualStyleBackColor = true;
            this.btn_valnum.Click += new System.EventHandler(this.btn_valnum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 31);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.CheckedListBoxToolStripMenuItem,
            this.comboboxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.mAsToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // CheckedListBoxToolStripMenuItem
            // 
            this.CheckedListBoxToolStripMenuItem.Name = "CheckedListBoxToolStripMenuItem";
            this.CheckedListBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.CheckedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.CheckedListBoxToolStripMenuItem.Click += new System.EventHandler(this.CheckedListBoxToolStripMenuItem_Click);
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.comboboxToolStripMenuItem.Text = "Combobox";
            this.comboboxToolStripMenuItem.Click += new System.EventHandler(this.comboboxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // mAsToolStripMenuItem
            // 
            this.mAsToolStripMenuItem.Name = "mAsToolStripMenuItem";
            this.mAsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.mAsToolStripMenuItem.Text = "MaskedTextBox";
            this.mAsToolStripMenuItem.Click += new System.EventHandler(this.mAsToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Componentes C#";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestaurar,
            this.tsmiMensagem,
            this.tsmiFechar});
            this.MenuNotificacoes.Name = "MenuNotificacoes";
            this.MenuNotificacoes.Size = new System.Drawing.Size(152, 76);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmiRestaurar
            // 
            this.tsmiRestaurar.Name = "tsmiRestaurar";
            this.tsmiRestaurar.Size = new System.Drawing.Size(210, 24);
            this.tsmiRestaurar.Text = "Restaurar";
            this.tsmiRestaurar.Click += new System.EventHandler(this.tsmiRestaurar_Click);
            // 
            // tsmiMensagem
            // 
            this.tsmiMensagem.Name = "tsmiMensagem";
            this.tsmiMensagem.Size = new System.Drawing.Size(210, 24);
            this.tsmiMensagem.Text = "Mensagem";
            this.tsmiMensagem.Click += new System.EventHandler(this.tsmiMensagem_Click);
            // 
            // tsmiFechar
            // 
            this.tsmiFechar.Name = "tsmiFechar";
            this.tsmiFechar.Size = new System.Drawing.Size(210, 24);
            this.tsmiFechar.Text = "Fechar";
            this.tsmiFechar.Click += new System.EventHandler(this.tsmiFechar_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 626);
            this.Controls.Add(this.btn_valnum);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ListaVeiculos);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - C#";
            this.Shown += new System.EventHandler(this.F_Principal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_valnum;
        public System.Windows.Forms.TextBox tb_ListaVeiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmiMensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmiFechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
    }
}

