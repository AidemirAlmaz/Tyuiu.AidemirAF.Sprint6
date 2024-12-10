namespace Tyuiu.AidemirAF.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelLeft_AAF = new Panel();
            groupBoxResult_AAF = new GroupBox();
            dataGridViewResult_AAF = new DataGridView();
            panelTop_AAF = new Panel();
            buttonHelp_AAF = new Button();
            buttonOpen_AAF = new Button();
            buttonDone_AAF = new Button();
            groupBoxTerm_AAF = new GroupBox();
            textBoxTerm_AAF = new TextBox();
            panelRight_AAF = new Panel();
            chartFunction_AAF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft_AAF.SuspendLayout();
            groupBoxResult_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAF).BeginInit();
            panelTop_AAF.SuspendLayout();
            groupBoxTerm_AAF.SuspendLayout();
            panelRight_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAF).BeginInit();
            SuspendLayout();
            // 
            // panelLeft_AAF
            // 
            panelLeft_AAF.Controls.Add(groupBoxResult_AAF);
            panelLeft_AAF.Dock = DockStyle.Left;
            panelLeft_AAF.Location = new Point(0, 125);
            panelLeft_AAF.Margin = new Padding(5);
            panelLeft_AAF.Name = "panelLeft_AAF";
            panelLeft_AAF.Size = new Size(250, 325);
            panelLeft_AAF.TabIndex = 0;
            // 
            // groupBoxResult_AAF
            // 
            groupBoxResult_AAF.Controls.Add(dataGridViewResult_AAF);
            groupBoxResult_AAF.Dock = DockStyle.Fill;
            groupBoxResult_AAF.Location = new Point(0, 0);
            groupBoxResult_AAF.Name = "groupBoxResult_AAF";
            groupBoxResult_AAF.Size = new Size(250, 325);
            groupBoxResult_AAF.TabIndex = 0;
            groupBoxResult_AAF.TabStop = false;
            groupBoxResult_AAF.Text = "Вывод данных :";
            // 
            // dataGridViewResult_AAF
            // 
            dataGridViewResult_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_AAF.Dock = DockStyle.Fill;
            dataGridViewResult_AAF.Location = new Point(3, 23);
            dataGridViewResult_AAF.Name = "dataGridViewResult_AAF";
            dataGridViewResult_AAF.RowHeadersWidth = 51;
            dataGridViewResult_AAF.Size = new Size(244, 299);
            dataGridViewResult_AAF.TabIndex = 5;
            // 
            // panelTop_AAF
            // 
            panelTop_AAF.Controls.Add(buttonHelp_AAF);
            panelTop_AAF.Controls.Add(buttonOpen_AAF);
            panelTop_AAF.Controls.Add(buttonDone_AAF);
            panelTop_AAF.Controls.Add(groupBoxTerm_AAF);
            panelTop_AAF.Dock = DockStyle.Top;
            panelTop_AAF.Location = new Point(0, 0);
            panelTop_AAF.Margin = new Padding(5);
            panelTop_AAF.Name = "panelTop_AAF";
            panelTop_AAF.Size = new Size(800, 125);
            panelTop_AAF.TabIndex = 0;
            // 
            // buttonHelp_AAF
            // 
            buttonHelp_AAF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAF.BackColor = Color.Blue;
            buttonHelp_AAF.Location = new Point(710, 34);
            buttonHelp_AAF.Name = "buttonHelp_AAF";
            buttonHelp_AAF.Size = new Size(87, 67);
            buttonHelp_AAF.TabIndex = 4;
            buttonHelp_AAF.Text = "Справка";
            buttonHelp_AAF.UseVisualStyleBackColor = false;
            buttonHelp_AAF.Click += buttonHelp_AAF_Click;
            // 
            // buttonOpen_AAF
            // 
            buttonOpen_AAF.BackColor = Color.Blue;
            buttonOpen_AAF.Location = new Point(601, 34);
            buttonOpen_AAF.Name = "buttonOpen_AAF";
            buttonOpen_AAF.Size = new Size(103, 67);
            buttonOpen_AAF.TabIndex = 3;
            buttonOpen_AAF.Text = "Открыть файл";
            buttonOpen_AAF.UseVisualStyleBackColor = false;
            buttonOpen_AAF.Click += buttonOpen_AAF_Click;
            // 
            // buttonDone_AAF
            // 
            buttonDone_AAF.BackColor = Color.Green;
            buttonDone_AAF.Location = new Point(486, 34);
            buttonDone_AAF.Name = "buttonDone_AAF";
            buttonDone_AAF.Size = new Size(109, 67);
            buttonDone_AAF.TabIndex = 2;
            buttonDone_AAF.Text = "Выполнить";
            buttonDone_AAF.UseVisualStyleBackColor = false;
            buttonDone_AAF.Click += buttonDone_AAF_Click;
            // 
            // groupBoxTerm_AAF
            // 
            groupBoxTerm_AAF.Controls.Add(textBoxTerm_AAF);
            groupBoxTerm_AAF.Location = new Point(12, 12);
            groupBoxTerm_AAF.Name = "groupBoxTerm_AAF";
            groupBoxTerm_AAF.Size = new Size(454, 105);
            groupBoxTerm_AAF.TabIndex = 1;
            groupBoxTerm_AAF.TabStop = false;
            groupBoxTerm_AAF.Text = "Условие :";
            // 
            // textBoxTerm_AAF
            // 
            textBoxTerm_AAF.Dock = DockStyle.Fill;
            textBoxTerm_AAF.Location = new Point(3, 23);
            textBoxTerm_AAF.Multiline = true;
            textBoxTerm_AAF.Name = "textBoxTerm_AAF";
            textBoxTerm_AAF.Size = new Size(448, 79);
            textBoxTerm_AAF.TabIndex = 0;
            textBoxTerm_AAF.Text = "Прочитать данные из файла InPutFileTask5V9.txt.\r\nВывести в dataGridView значения равные нулю и\r\nпостроить диаграмму по этим значениям.";
            // 
            // panelRight_AAF
            // 
            panelRight_AAF.Controls.Add(chartFunction_AAF);
            panelRight_AAF.Dock = DockStyle.Right;
            panelRight_AAF.Location = new Point(256, 125);
            panelRight_AAF.Margin = new Padding(5);
            panelRight_AAF.Name = "panelRight_AAF";
            panelRight_AAF.Size = new Size(544, 325);
            panelRight_AAF.TabIndex = 0;
            // 
            // chartFunction_AAF
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AAF.ChartAreas.Add(chartArea1);
            chartFunction_AAF.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_AAF.Legends.Add(legend1);
            chartFunction_AAF.Location = new Point(0, 0);
            chartFunction_AAF.Name = "chartFunction_AAF";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Green;
            series1.LabelBackColor = Color.White;
            series1.LabelBorderColor = Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.White;
            series1.Name = "Series1";
            chartFunction_AAF.Series.Add(series1);
            chartFunction_AAF.Size = new Size(544, 325);
            chartFunction_AAF.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight_AAF);
            Controls.Add(panelLeft_AAF);
            Controls.Add(panelTop_AAF);
            MinimumSize = new Size(818, 497);
            Name = "FormMain";
            Text = "Form1";
            panelLeft_AAF.ResumeLayout(false);
            groupBoxResult_AAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAF).EndInit();
            panelTop_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.PerformLayout();
            panelRight_AAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft_AAF;
        private Panel panelTop_AAF;
        private Panel panelRight_AAF;
        private GroupBox groupBoxResult_AAF;
        private GroupBox groupBoxTerm_AAF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAF;
        private Button buttonHelp_AAF;
        private Button buttonOpen_AAF;
        private Button buttonDone_AAF;
        private TextBox textBoxTerm_AAF;
        private DataGridView dataGridViewResult_AAF;
    }
}
