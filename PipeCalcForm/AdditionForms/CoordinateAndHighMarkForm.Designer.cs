
namespace PipeCalcForm
{
    partial class CoordinateAndHighMarkForm
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
            this.dataGridXandZ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXandZ)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridXandZ
            // 
            this.dataGridXandZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXandZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridXandZ.Location = new System.Drawing.Point(0, 0);
            this.dataGridXandZ.Name = "dataGridXandZ";
            this.dataGridXandZ.Size = new System.Drawing.Size(246, 274);
            this.dataGridXandZ.TabIndex = 0;
            // 
            // CoordinateAndHighMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(246, 274);
            this.Controls.Add(this.dataGridXandZ);
            this.Name = "CoordinateAndHighMarkForm";
            this.Text = "CoordinateAndHighMarkTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXandZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridXandZ;
    }
}