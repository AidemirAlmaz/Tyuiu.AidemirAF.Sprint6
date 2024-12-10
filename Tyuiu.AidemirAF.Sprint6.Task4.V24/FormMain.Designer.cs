namespace Tyuiu.AidemirAF.Sprint6.Task4.V24
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonDone_AAF = new Button();
            buttonSave_AAF = new Button();
            button2 = new Button();
            chartFunction_AAF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxStartStep_AAF = new TextBox();
            textBoxStopStep_AAF = new TextBox();
            groupBox_AAF = new GroupBox();
            panelTop_AAF = new Panel();
            buttonHelp_AAF = new Button();
            groupBoxTerm_AAF = new GroupBox();
            textBoxTerm_AAF = new TextBox();
            panelLeft_AAF = new Panel();
            groupBoxResult_AAF = new GroupBox();
            textBoxResult_AAF = new TextBox();
            panelRight_AAF = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAF).BeginInit();
            groupBox_AAF.SuspendLayout();
            panelTop_AAF.SuspendLayout();
            groupBoxTerm_AAF.SuspendLayout();
            panelLeft_AAF.SuspendLayout();
            groupBoxResult_AAF.SuspendLayout();
            panelRight_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_AAF
            // 
            buttonDone_AAF.BackColor = Color.Green;
            buttonDone_AAF.Location = new Point(581, 22);
            buttonDone_AAF.Name = "buttonDone_AAF";
            buttonDone_AAF.Size = new Size(103, 58);
            buttonDone_AAF.TabIndex = 0;
            buttonDone_AAF.Text = "Выполнить";
            buttonDone_AAF.UseVisualStyleBackColor = false;
            buttonDone_AAF.Click += buttonDone_AAF_Click;
            // 
            // buttonSave_AAF
            // 
            buttonSave_AAF.BackColor = Color.Blue;
            buttonSave_AAF.Location = new Point(697, 22);
            buttonSave_AAF.Name = "buttonSave_AAF";
            buttonSave_AAF.Size = new Size(103, 58);
            buttonSave_AAF.TabIndex = 1;
            buttonSave_AAF.Text = "Сохранить";
            buttonSave_AAF.UseVisualStyleBackColor = false;
            buttonSave_AAF.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            // 
            // chartFunction_AAF
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_AAF.ChartAreas.Add(chartArea2);
            chartFunction_AAF.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunction_AAF.Legends.Add(legend2);
            chartFunction_AAF.Location = new Point(5, 5);
            chartFunction_AAF.Name = "chartFunction_AAF";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_AAF.Series.Add(series2);
            chartFunction_AAF.Size = new Size(658, 411);
            chartFunction_AAF.TabIndex = 3;
            chartFunction_AAF.Text = "chart1";
            title2.BackColor = Color.White;
            title2.BorderColor = Color.White;
            title2.ForeColor = Color.Blue;
            title2.Name = "TitleFunction_AAF";
            title2.Text = "График функции F(x)";
            chartFunction_AAF.Titles.Add(title2);
            // 
            // textBoxStartStep_AAF
            // 
            textBoxStartStep_AAF.Location = new Point(6, 26);
            textBoxStartStep_AAF.Name = "textBoxStartStep_AAF";
            textBoxStartStep_AAF.Size = new Size(125, 27);
            textBoxStartStep_AAF.TabIndex = 4;
            textBoxStartStep_AAF.Text = "-5";
            // 
            // textBoxStopStep_AAF
            // 
            textBoxStopStep_AAF.Location = new Point(147, 26);
            textBoxStopStep_AAF.Name = "textBoxStopStep_AAF";
            textBoxStopStep_AAF.Size = new Size(125, 27);
            textBoxStopStep_AAF.TabIndex = 5;
            textBoxStopStep_AAF.Text = "5";
            // 
            // groupBox_AAF
            // 
            groupBox_AAF.Controls.Add(textBoxStartStep_AAF);
            groupBox_AAF.Controls.Add(textBoxStopStep_AAF);
            groupBox_AAF.Location = new Point(284, 12);
            groupBox_AAF.Name = "groupBox_AAF";
            groupBox_AAF.Size = new Size(278, 70);
            groupBox_AAF.TabIndex = 7;
            groupBox_AAF.TabStop = false;
            groupBox_AAF.Text = "Ввод данных";
            // 
            // panelTop_AAF
            // 
            panelTop_AAF.Controls.Add(buttonHelp_AAF);
            panelTop_AAF.Controls.Add(groupBoxTerm_AAF);
            panelTop_AAF.Controls.Add(groupBox_AAF);
            panelTop_AAF.Controls.Add(buttonDone_AAF);
            panelTop_AAF.Controls.Add(button2);
            panelTop_AAF.Controls.Add(buttonSave_AAF);
            panelTop_AAF.Dock = DockStyle.Top;
            panelTop_AAF.Location = new Point(0, 0);
            panelTop_AAF.Name = "panelTop_AAF";
            panelTop_AAF.Size = new Size(912, 93);
            panelTop_AAF.TabIndex = 8;
            // 
            // buttonHelp_AAF
            // 
            buttonHelp_AAF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAF.BackColor = Color.Blue;
            buttonHelp_AAF.Location = new Point(808, 22);
            buttonHelp_AAF.Name = "buttonHelp_AAF";
            buttonHelp_AAF.Size = new Size(101, 58);
            buttonHelp_AAF.TabIndex = 10;
            buttonHelp_AAF.Text = "Справка";
            buttonHelp_AAF.UseVisualStyleBackColor = false;
            buttonHelp_AAF.Click += buttonHelp_AAF_Click_1;
            // 
            // groupBoxTerm_AAF
            // 
            groupBoxTerm_AAF.Controls.Add(textBoxTerm_AAF);
            groupBoxTerm_AAF.Dock = DockStyle.Left;
            groupBoxTerm_AAF.Location = new Point(0, 0);
            groupBoxTerm_AAF.Name = "groupBoxTerm_AAF";
            groupBoxTerm_AAF.Size = new Size(247, 93);
            groupBoxTerm_AAF.TabIndex = 10;
            groupBoxTerm_AAF.TabStop = false;
            groupBoxTerm_AAF.Text = "Условие";
            // 
            // textBoxTerm_AAF
            // 
            textBoxTerm_AAF.Dock = DockStyle.Fill;
            textBoxTerm_AAF.Location = new Point(3, 23);
            textBoxTerm_AAF.Multiline = true;
            textBoxTerm_AAF.Name = "textBoxTerm_AAF";
            textBoxTerm_AAF.ScrollBars = ScrollBars.Vertical;
            textBoxTerm_AAF.Size = new Size(241, 67);
            textBoxTerm_AAF.TabIndex = 0;
            textBoxTerm_AAF.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V24.txt по нажатию кнопки.";
            // 
            // panelLeft_AAF
            // 
            panelLeft_AAF.Controls.Add(groupBoxResult_AAF);
            panelLeft_AAF.Dock = DockStyle.Left;
            panelLeft_AAF.Location = new Point(0, 93);
            panelLeft_AAF.Name = "panelLeft_AAF";
            panelLeft_AAF.Size = new Size(229, 421);
            panelLeft_AAF.TabIndex = 9;
            // 
            // groupBoxResult_AAF
            // 
            groupBoxResult_AAF.Controls.Add(textBoxResult_AAF);
            groupBoxResult_AAF.Dock = DockStyle.Fill;
            groupBoxResult_AAF.Location = new Point(0, 0);
            groupBoxResult_AAF.Name = "groupBoxResult_AAF";
            groupBoxResult_AAF.Padding = new Padding(5);
            groupBoxResult_AAF.Size = new Size(229, 421);
            groupBoxResult_AAF.TabIndex = 0;
            groupBoxResult_AAF.TabStop = false;
            groupBoxResult_AAF.Text = "Вывод данных";
            // 
            // textBoxResult_AAF
            // 
            textBoxResult_AAF.Dock = DockStyle.Fill;
            textBoxResult_AAF.Location = new Point(5, 25);
            textBoxResult_AAF.Multiline = true;
            textBoxResult_AAF.Name = "textBoxResult_AAF";
            textBoxResult_AAF.Size = new Size(219, 391);
            textBoxResult_AAF.TabIndex = 0;
            // 
            // panelRight_AAF
            // 
            panelRight_AAF.Controls.Add(chartFunction_AAF);
            panelRight_AAF.Dock = DockStyle.Right;
            panelRight_AAF.Location = new Point(244, 93);
            panelRight_AAF.Name = "panelRight_AAF";
            panelRight_AAF.Padding = new Padding(5);
            panelRight_AAF.Size = new Size(668, 421);
            panelRight_AAF.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 514);
            Controls.Add(panelRight_AAF);
            Controls.Add(panelLeft_AAF);
            Controls.Add(panelTop_AAF);
            MaximumSize = new Size(930, 561);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 24 | Айдемир А.Ф.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAF).EndInit();
            groupBox_AAF.ResumeLayout(false);
            groupBox_AAF.PerformLayout();
            panelTop_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.PerformLayout();
            panelLeft_AAF.ResumeLayout(false);
            groupBoxResult_AAF.ResumeLayout(false);
            groupBoxResult_AAF.PerformLayout();
            panelRight_AAF.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_AAF;
        private Button buttonSave_AAF;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAF;
        private TextBox textBoxStartStep_AAF;
        private TextBox textBoxStopStep_AAF;
        private GroupBox groupBox_AAF;
        private Panel panelTop_AAF;
        private Panel panelLeft_AAF;
        private GroupBox groupBoxResult_AAF;
        private Panel panelRight_AAF;
        private GroupBox groupBoxTerm_AAF;
        private TextBox textBoxTerm_AAF;
        private TextBox textBoxResult_AAF;
        private Button buttonHelp_AAF;
    }
}
