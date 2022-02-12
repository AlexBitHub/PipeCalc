
namespace PipeCalcForm.AdditionForms
{
    partial class UserTabPageStation
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHighMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCoordinate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridPumps = new System.Windows.Forms.DataGridView();
            this.columnCmbBoxBoostPumps = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnCmbBoxMainPumps = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPumps)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Высотная отметка, м";
            // 
            // txtBoxHighMark
            // 
            this.txtBoxHighMark.Location = new System.Drawing.Point(184, 40);
            this.txtBoxHighMark.Name = "txtBoxHighMark";
            this.txtBoxHighMark.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHighMark.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Координата, км";
            // 
            // txtBoxCoordinate
            // 
            this.txtBoxCoordinate.Location = new System.Drawing.Point(184, 11);
            this.txtBoxCoordinate.Name = "txtBoxCoordinate";
            this.txtBoxCoordinate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCoordinate.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtBoxCoordinate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxHighMark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 98);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridPumps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 161);
            this.panel2.TabIndex = 26;
            // 
            // dataGridPumps
            // 
            this.dataGridPumps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPumps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPumps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCmbBoxBoostPumps,
            this.columnCmbBoxMainPumps});
            this.dataGridPumps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPumps.Location = new System.Drawing.Point(0, 0);
            this.dataGridPumps.Name = "dataGridPumps";
            this.dataGridPumps.Size = new System.Drawing.Size(310, 161);
            this.dataGridPumps.TabIndex = 25;
            // 
            // columnCmbBoxBoostPumps
            // 
            this.columnCmbBoxBoostPumps.HeaderText = "Подпорные";
            this.columnCmbBoxBoostPumps.Name = "columnCmbBoxBoostPumps";
            this.columnCmbBoxBoostPumps.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCmbBoxBoostPumps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnCmbBoxMainPumps
            // 
            this.columnCmbBoxMainPumps.HeaderText = "Магистральные";
            this.columnCmbBoxMainPumps.Name = "columnCmbBoxMainPumps";
            this.columnCmbBoxMainPumps.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCmbBoxMainPumps.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserTabPageStation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserTabPageStation";
            this.Size = new System.Drawing.Size(310, 259);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPumps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHighMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCoordinate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridPumps;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCmbBoxBoostPumps;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCmbBoxMainPumps;
    }
}
