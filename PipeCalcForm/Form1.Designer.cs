
namespace PipeCalcForm
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelOilProperties = new System.Windows.Forms.Panel();
            this.txtBoxVapourPres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxViscos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOilProperties = new System.Windows.Forms.Button();
            this.btnPipeProperties = new System.Windows.Forms.Button();
            this.panelPipeProperties = new System.Windows.Forms.Panel();
            this.txtBoxDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxThickness = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtBoxRoughness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSideMenu.SuspendLayout();
            this.panelOilProperties.SuspendLayout();
            this.panelPipeProperties.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSideMenu.Controls.Add(this.tabControl1);
            this.panelSideMenu.Controls.Add(this.panelPipeProperties);
            this.panelSideMenu.Controls.Add(this.btnPipeProperties);
            this.panelSideMenu.Controls.Add(this.panelOilProperties);
            this.panelSideMenu.Controls.Add(this.btnOilProperties);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(282, 554);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelOilProperties
            // 
            this.panelOilProperties.BackColor = System.Drawing.Color.Silver;
            this.panelOilProperties.Controls.Add(this.txtBoxVapourPres);
            this.panelOilProperties.Controls.Add(this.label3);
            this.panelOilProperties.Controls.Add(this.txtBoxViscos);
            this.panelOilProperties.Controls.Add(this.label2);
            this.panelOilProperties.Controls.Add(this.txtBoxDens);
            this.panelOilProperties.Controls.Add(this.label1);
            this.panelOilProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOilProperties.Location = new System.Drawing.Point(0, 30);
            this.panelOilProperties.Name = "panelOilProperties";
            this.panelOilProperties.Size = new System.Drawing.Size(282, 92);
            this.panelOilProperties.TabIndex = 1;
            this.panelOilProperties.Visible = false;
            // 
            // txtBoxVapourPres
            // 
            this.txtBoxVapourPres.Location = new System.Drawing.Point(170, 62);
            this.txtBoxVapourPres.Name = "txtBoxVapourPres";
            this.txtBoxVapourPres.Size = new System.Drawing.Size(109, 23);
            this.txtBoxVapourPres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Упругость паров, МПа";
            // 
            // txtBoxViscos
            // 
            this.txtBoxViscos.Location = new System.Drawing.Point(170, 33);
            this.txtBoxViscos.Name = "txtBoxViscos";
            this.txtBoxViscos.Size = new System.Drawing.Size(109, 23);
            this.txtBoxViscos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вязкость, сСт";
            // 
            // txtBoxDens
            // 
            this.txtBoxDens.Location = new System.Drawing.Point(170, 4);
            this.txtBoxDens.Name = "txtBoxDens";
            this.txtBoxDens.Size = new System.Drawing.Size(109, 23);
            this.txtBoxDens.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Плотность, кг/м3";
            // 
            // btnOilProperties
            // 
            this.btnOilProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOilProperties.Location = new System.Drawing.Point(0, 0);
            this.btnOilProperties.Name = "btnOilProperties";
            this.btnOilProperties.Size = new System.Drawing.Size(282, 30);
            this.btnOilProperties.TabIndex = 0;
            this.btnOilProperties.Text = "Свойства нефти";
            this.btnOilProperties.UseVisualStyleBackColor = true;
            this.btnOilProperties.Click += new System.EventHandler(this.btnOilProperties_Click);
            // 
            // btnPipeProperties
            // 
            this.btnPipeProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPipeProperties.Location = new System.Drawing.Point(0, 122);
            this.btnPipeProperties.Name = "btnPipeProperties";
            this.btnPipeProperties.Size = new System.Drawing.Size(282, 30);
            this.btnPipeProperties.TabIndex = 2;
            this.btnPipeProperties.Text = "Параметры трубопровода";
            this.btnPipeProperties.UseVisualStyleBackColor = true;
            this.btnPipeProperties.Click += new System.EventHandler(this.btnPipeProperties_Click);
            // 
            // panelPipeProperties
            // 
            this.panelPipeProperties.BackColor = System.Drawing.Color.Silver;
            this.panelPipeProperties.Controls.Add(this.txtBoxRoughness);
            this.panelPipeProperties.Controls.Add(this.label6);
            this.panelPipeProperties.Controls.Add(this.richTextBox1);
            this.panelPipeProperties.Controls.Add(this.txtBoxThickness);
            this.panelPipeProperties.Controls.Add(this.txtBoxLength);
            this.panelPipeProperties.Controls.Add(this.label5);
            this.panelPipeProperties.Controls.Add(this.txtBoxDiameter);
            this.panelPipeProperties.Controls.Add(this.label4);
            this.panelPipeProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPipeProperties.Location = new System.Drawing.Point(0, 152);
            this.panelPipeProperties.Name = "panelPipeProperties";
            this.panelPipeProperties.Size = new System.Drawing.Size(282, 126);
            this.panelPipeProperties.TabIndex = 3;
            this.panelPipeProperties.Visible = false;
            // 
            // txtBoxDiameter
            // 
            this.txtBoxDiameter.Location = new System.Drawing.Point(170, 6);
            this.txtBoxDiameter.Name = "txtBoxDiameter";
            this.txtBoxDiameter.Size = new System.Drawing.Size(109, 23);
            this.txtBoxDiameter.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Диаметр, м";
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(170, 35);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(109, 23);
            this.txtBoxLength.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Протяженность, км";
            // 
            // txtBoxThickness
            // 
            this.txtBoxThickness.Location = new System.Drawing.Point(170, 64);
            this.txtBoxThickness.Name = "txtBoxThickness";
            this.txtBoxThickness.Size = new System.Drawing.Size(109, 23);
            this.txtBoxThickness.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(13, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(136, 38);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Толщина стенки трубы, м";
            // 
            // txtBoxRoughness
            // 
            this.txtBoxRoughness.Location = new System.Drawing.Point(170, 93);
            this.txtBoxRoughness.Name = "txtBoxRoughness";
            this.txtBoxRoughness.Size = new System.Drawing.Size(109, 23);
            this.txtBoxRoughness.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Шероховатость, мм";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 278);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 276);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(274, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelOilProperties.ResumeLayout(false);
            this.panelOilProperties.PerformLayout();
            this.panelPipeProperties.ResumeLayout(false);
            this.panelPipeProperties.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelOilProperties;
        private System.Windows.Forms.TextBox txtBoxVapourPres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxViscos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOilProperties;
        private System.Windows.Forms.Panel panelPipeProperties;
        private System.Windows.Forms.Button btnPipeProperties;
        private System.Windows.Forms.TextBox txtBoxDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxThickness;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtBoxRoughness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

