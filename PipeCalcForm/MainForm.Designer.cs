
namespace PipeCalcForm
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelBorderConditions = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtBoxEndHigh = new System.Windows.Forms.TextBox();
            this.txtBoxEndPressure = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBorderConditions = new System.Windows.Forms.Button();
            this.panelStationProperties = new System.Windows.Forms.Panel();
            this.tabCntrStations = new System.Windows.Forms.TabControl();
            this.tabPageMainStation = new System.Windows.Forms.TabPage();
            this.panelMainStation = new System.Windows.Forms.Panel();
            this.btnStationProperties = new System.Windows.Forms.Button();
            this.panelPipeProperties = new System.Windows.Forms.Panel();
            this.txtBoxRoughness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtBoxThickness = new System.Windows.Forms.TextBox();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDiameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPipeProperties = new System.Windows.Forms.Button();
            this.panelOilProperties = new System.Windows.Forms.Panel();
            this.txtBoxVapourPres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxViscos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOilProperties = new System.Windows.Forms.Button();
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelPipelineProfile = new System.Windows.Forms.Panel();
            this.btnPipelineProfile = new System.Windows.Forms.Button();
            this.btnSetMarks = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelBorderConditions.SuspendLayout();
            this.panelStationProperties.SuspendLayout();
            this.tabCntrStations.SuspendLayout();
            this.tabPageMainStation.SuspendLayout();
            this.panelPipeProperties.SuspendLayout();
            this.panelOilProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            this.panelPipelineProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSideMenu.Controls.Add(this.panelPipelineProfile);
            this.panelSideMenu.Controls.Add(this.btnPipelineProfile);
            this.panelSideMenu.Controls.Add(this.panelBorderConditions);
            this.panelSideMenu.Controls.Add(this.btnBorderConditions);
            this.panelSideMenu.Controls.Add(this.panelStationProperties);
            this.panelSideMenu.Controls.Add(this.btnStationProperties);
            this.panelSideMenu.Controls.Add(this.panelPipeProperties);
            this.panelSideMenu.Controls.Add(this.btnPipeProperties);
            this.panelSideMenu.Controls.Add(this.panelOilProperties);
            this.panelSideMenu.Controls.Add(this.btnOilProperties);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(282, 701);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelBorderConditions
            // 
            this.panelBorderConditions.BackColor = System.Drawing.Color.Silver;
            this.panelBorderConditions.Controls.Add(this.richTextBox2);
            this.panelBorderConditions.Controls.Add(this.txtBoxEndHigh);
            this.panelBorderConditions.Controls.Add(this.txtBoxEndPressure);
            this.panelBorderConditions.Controls.Add(this.label9);
            this.panelBorderConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderConditions.Location = new System.Drawing.Point(0, 495);
            this.panelBorderConditions.Name = "panelBorderConditions";
            this.panelBorderConditions.Size = new System.Drawing.Size(282, 69);
            this.panelBorderConditions.TabIndex = 9;
            this.panelBorderConditions.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Silver;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(13, 31);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(136, 38);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Конечная высотная отметка, м";
            // 
            // txtBoxEndHigh
            // 
            this.txtBoxEndHigh.Location = new System.Drawing.Point(170, 37);
            this.txtBoxEndHigh.Name = "txtBoxEndHigh";
            this.txtBoxEndHigh.Size = new System.Drawing.Size(109, 23);
            this.txtBoxEndHigh.TabIndex = 5;
            // 
            // txtBoxEndPressure
            // 
            this.txtBoxEndPressure.Location = new System.Drawing.Point(170, 6);
            this.txtBoxEndPressure.Name = "txtBoxEndPressure";
            this.txtBoxEndPressure.Size = new System.Drawing.Size(109, 23);
            this.txtBoxEndPressure.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Конечный напор, м";
            // 
            // btnBorderConditions
            // 
            this.btnBorderConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorderConditions.Location = new System.Drawing.Point(0, 465);
            this.btnBorderConditions.Name = "btnBorderConditions";
            this.btnBorderConditions.Size = new System.Drawing.Size(282, 30);
            this.btnBorderConditions.TabIndex = 8;
            this.btnBorderConditions.Text = "Граничные условия";
            this.btnBorderConditions.UseVisualStyleBackColor = true;
            this.btnBorderConditions.Click += new System.EventHandler(this.btnBorderConditions_Click);
            // 
            // panelStationProperties
            // 
            this.panelStationProperties.BackColor = System.Drawing.Color.Silver;
            this.panelStationProperties.Controls.Add(this.tabCntrStations);
            this.panelStationProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStationProperties.Location = new System.Drawing.Point(0, 308);
            this.panelStationProperties.Name = "panelStationProperties";
            this.panelStationProperties.Size = new System.Drawing.Size(282, 157);
            this.panelStationProperties.TabIndex = 7;
            this.panelStationProperties.Visible = false;
            // 
            // tabCntrStations
            // 
            this.tabCntrStations.Controls.Add(this.tabPageMainStation);
            this.tabCntrStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCntrStations.Location = new System.Drawing.Point(0, 0);
            this.tabCntrStations.Name = "tabCntrStations";
            this.tabCntrStations.SelectedIndex = 0;
            this.tabCntrStations.Size = new System.Drawing.Size(282, 157);
            this.tabCntrStations.TabIndex = 0;
            this.tabCntrStations.DoubleClick += new System.EventHandler(this.tabCntrStations_DoubleClick);
            // 
            // tabPageMainStation
            // 
            this.tabPageMainStation.Controls.Add(this.panelMainStation);
            this.tabPageMainStation.Location = new System.Drawing.Point(4, 25);
            this.tabPageMainStation.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMainStation.Name = "tabPageMainStation";
            this.tabPageMainStation.Size = new System.Drawing.Size(274, 128);
            this.tabPageMainStation.TabIndex = 0;
            this.tabPageMainStation.Text = "МНПС";
            this.tabPageMainStation.UseVisualStyleBackColor = true;
            // 
            // panelMainStation
            // 
            this.panelMainStation.Location = new System.Drawing.Point(0, 0);
            this.panelMainStation.Name = "panelMainStation";
            this.panelMainStation.Size = new System.Drawing.Size(274, 128);
            this.panelMainStation.TabIndex = 0;
            // 
            // btnStationProperties
            // 
            this.btnStationProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStationProperties.Location = new System.Drawing.Point(0, 278);
            this.btnStationProperties.Name = "btnStationProperties";
            this.btnStationProperties.Size = new System.Drawing.Size(282, 30);
            this.btnStationProperties.TabIndex = 6;
            this.btnStationProperties.Text = "Перекачивающие станции";
            this.btnStationProperties.UseVisualStyleBackColor = true;
            this.btnStationProperties.Click += new System.EventHandler(this.btnStationProperties_Click);
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
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Шероховатость, мм";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(136, 38);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Толщина стенки трубы, м";
            // 
            // txtBoxThickness
            // 
            this.txtBoxThickness.Location = new System.Drawing.Point(170, 64);
            this.txtBoxThickness.Name = "txtBoxThickness";
            this.txtBoxThickness.Size = new System.Drawing.Size(109, 23);
            this.txtBoxThickness.TabIndex = 7;
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
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Протяженность, км";
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
            // chartGraphic
            // 
            this.chartGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend1);
            this.chartGraphic.Location = new System.Drawing.Point(282, 0);
            this.chartGraphic.Name = "chartGraphic";
            this.chartGraphic.Size = new System.Drawing.Size(785, 701);
            this.chartGraphic.TabIndex = 1;
            this.chartGraphic.Text = "График гидроуклона";
            // 
            // panelPipelineProfile
            // 
            this.panelPipelineProfile.BackColor = System.Drawing.Color.Silver;
            this.panelPipelineProfile.Controls.Add(this.button3);
            this.panelPipelineProfile.Controls.Add(this.btnSetMarks);
            this.panelPipelineProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPipelineProfile.Location = new System.Drawing.Point(0, 594);
            this.panelPipelineProfile.Name = "panelPipelineProfile";
            this.panelPipelineProfile.Size = new System.Drawing.Size(282, 77);
            this.panelPipelineProfile.TabIndex = 11;
            this.panelPipelineProfile.Visible = false;
            // 
            // btnPipelineProfile
            // 
            this.btnPipelineProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPipelineProfile.Location = new System.Drawing.Point(0, 564);
            this.btnPipelineProfile.Name = "btnPipelineProfile";
            this.btnPipelineProfile.Size = new System.Drawing.Size(282, 30);
            this.btnPipelineProfile.TabIndex = 10;
            this.btnPipelineProfile.Text = "Профиль трубопровода";
            this.btnPipelineProfile.UseVisualStyleBackColor = true;
            this.btnPipelineProfile.Click += new System.EventHandler(this.btnPipelineProfile_Click);
            // 
            // btnSetMarks
            // 
            this.btnSetMarks.Location = new System.Drawing.Point(52, 6);
            this.btnSetMarks.Name = "btnSetMarks";
            this.btnSetMarks.Size = new System.Drawing.Size(83, 53);
            this.btnSetMarks.TabIndex = 0;
            this.btnSetMarks.Text = "Задать отметки";
            this.btnSetMarks.UseVisualStyleBackColor = true;
            this.btnSetMarks.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "Загрузить отметки";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 701);
            this.Controls.Add(this.chartGraphic);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Гидравлический расчет нефтепровода";
            this.panelSideMenu.ResumeLayout(false);
            this.panelBorderConditions.ResumeLayout(false);
            this.panelBorderConditions.PerformLayout();
            this.panelStationProperties.ResumeLayout(false);
            this.tabCntrStations.ResumeLayout(false);
            this.tabPageMainStation.ResumeLayout(false);
            this.panelPipeProperties.ResumeLayout(false);
            this.panelPipeProperties.PerformLayout();
            this.panelOilProperties.ResumeLayout(false);
            this.panelOilProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            this.panelPipelineProfile.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelBorderConditions;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txtBoxEndPressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBorderConditions;
        private System.Windows.Forms.Panel panelStationProperties;
        private System.Windows.Forms.TabControl tabCntrStations;
        private System.Windows.Forms.TabPage tabPageMainStation;
        private System.Windows.Forms.Panel panelMainStation;
        private System.Windows.Forms.Button btnStationProperties;
        private System.Windows.Forms.TextBox txtBoxEndHigh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.Panel panelPipelineProfile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSetMarks;
        private System.Windows.Forms.Button btnPipelineProfile;
    }
}

