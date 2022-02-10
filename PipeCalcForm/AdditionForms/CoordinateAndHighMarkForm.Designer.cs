
namespace PipeCalcForm.AdditionForms
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
            this.buttonOkPipeProfil = new System.Windows.Forms.Button();
            this.buttonCancelPipeProfil = new System.Windows.Forms.Button();
            this.buttonRandHigMarks = new System.Windows.Forms.Button();
            this.dataGridXandZ = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXandZ)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOkPipeProfil
            // 
            this.buttonOkPipeProfil.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOkPipeProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOkPipeProfil.Location = new System.Drawing.Point(0, 1);
            this.buttonOkPipeProfil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOkPipeProfil.Name = "buttonOkPipeProfil";
            this.buttonOkPipeProfil.Size = new System.Drawing.Size(246, 19);
            this.buttonOkPipeProfil.TabIndex = 1;
            this.buttonOkPipeProfil.Text = "OK";
            this.buttonOkPipeProfil.UseVisualStyleBackColor = true;
            // 
            // buttonCancelPipeProfil
            // 
            this.buttonCancelPipeProfil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelPipeProfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancelPipeProfil.Location = new System.Drawing.Point(0, 39);
            this.buttonCancelPipeProfil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelPipeProfil.Name = "buttonCancelPipeProfil";
            this.buttonCancelPipeProfil.Size = new System.Drawing.Size(246, 19);
            this.buttonCancelPipeProfil.TabIndex = 2;
            this.buttonCancelPipeProfil.Text = "Cancel";
            this.buttonCancelPipeProfil.UseVisualStyleBackColor = true;
            // 
            // buttonRandHigMarks
            // 
            this.buttonRandHigMarks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRandHigMarks.Location = new System.Drawing.Point(0, 20);
            this.buttonRandHigMarks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandHigMarks.Name = "buttonRandHigMarks";
            this.buttonRandHigMarks.Size = new System.Drawing.Size(246, 19);
            this.buttonRandHigMarks.TabIndex = 3;
            this.buttonRandHigMarks.Text = "Рандомные высотные отметки";
            this.buttonRandHigMarks.UseVisualStyleBackColor = true;
            this.buttonRandHigMarks.Click += new System.EventHandler(this.buttonRandHigMarks_Click);
            // 
            // dataGridXandZ
            // 
            this.dataGridXandZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridXandZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXandZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridXandZ.Location = new System.Drawing.Point(0, 0);
            this.dataGridXandZ.Name = "dataGridXandZ";
            this.dataGridXandZ.Size = new System.Drawing.Size(246, 236);
            this.dataGridXandZ.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOkPipeProfil);
            this.panel1.Controls.Add(this.buttonRandHigMarks);
            this.panel1.Controls.Add(this.buttonCancelPipeProfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 58);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridXandZ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 236);
            this.panel2.TabIndex = 5;
            // 
            // CoordinateAndHighMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(246, 294);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CoordinateAndHighMarkForm";
            this.Text = "CoordinateAndHighMarkTable";
            this.Shown += new System.EventHandler(this.CoordinateAndHighMarkForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXandZ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOkPipeProfil;
        private System.Windows.Forms.Button buttonCancelPipeProfil;
        private System.Windows.Forms.Button buttonRandHigMarks;
        private System.Windows.Forms.DataGridView dataGridXandZ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}