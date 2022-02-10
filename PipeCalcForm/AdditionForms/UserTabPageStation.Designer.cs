
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridPumps = new System.Windows.Forms.DataGridView();
            this.columnCmbBoxBoostPumps = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnCmbBoxMainPumps = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPumps)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Высотная отметка, м";
            // 
            // txtBoxHighMark
            // 
            this.txtBoxHighMark.Location = new System.Drawing.Point(152, 34);
            this.txtBoxHighMark.Name = "txtBoxHighMark";
            this.txtBoxHighMark.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHighMark.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Координата, км";
            // 
            // txtBoxCoordinate
            // 
            this.txtBoxCoordinate.Location = new System.Drawing.Point(152, 5);
            this.txtBoxCoordinate.Name = "txtBoxCoordinate";
            this.txtBoxCoordinate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCoordinate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Насосы";
            // 
            // dataGridPumps
            // 
            this.dataGridPumps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPumps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCmbBoxBoostPumps,
            this.columnCmbBoxMainPumps});
            this.dataGridPumps.Location = new System.Drawing.Point(5, 86);
            this.dataGridPumps.Name = "dataGridPumps";
            this.dataGridPumps.Size = new System.Drawing.Size(266, 125);
            this.dataGridPumps.TabIndex = 24;
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
            this.Controls.Add(this.dataGridPumps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxHighMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCoordinate);
            this.Name = "UserTabPageStation";
            this.Size = new System.Drawing.Size(274, 224);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPumps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHighMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCoordinate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridPumps;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCmbBoxBoostPumps;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCmbBoxMainPumps;
    }
}
