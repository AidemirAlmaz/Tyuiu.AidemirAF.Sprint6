namespace Tyuiu.AidemirAF.Sprint6.Task2.V19
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
            groupBoxTerm = new GroupBox();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            buttonDone = new Button();
            dataGridView = new DataGridView();
            ColumnStart = new DataGridViewTextBoxColumn();
            ColumnResult = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTerm
            // 
            groupBoxTerm.Location = new Point(12, 12);
            groupBoxTerm.Name = "groupBoxTerm";
            groupBoxTerm.Size = new Size(318, 248);
            groupBoxTerm.TabIndex = 0;
            groupBoxTerm.TabStop = false;
            groupBoxTerm.Text = "Условие                                                       Протабулировать функцию sin(x)/x+1.7 - cos(x)*4*x - 6 на заданном диапозоне. Реультат вывести в DataGridView и построить график функции.";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.AccessibleName = "";
            textBoxStartStep.Location = new Point(12, 414);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 1;
            textBoxStartStep.Text = "-5";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(163, 414);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(125, 27);
            textBoxStopStep.TabIndex = 2;
            textBoxStopStep.Text = "5";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.DodgerBlue;
            buttonDone.Location = new Point(333, 392);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(127, 49);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выпонить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridView
            // 
            dataGridView.AccessibleDescription = "";
            dataGridView.AccessibleName = "";
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnStart, ColumnResult });
            dataGridView.Location = new Point(468, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(129, 429);
            dataGridView.TabIndex = 4;
            // 
            // ColumnStart
            // 
            ColumnStart.HeaderText = "X";
            ColumnStart.MinimumWidth = 6;
            ColumnStart.Name = "ColumnStart";
            ColumnStart.Width = 60;
            // 
            // ColumnResult
            // 
            ColumnResult.HeaderText = "F(X)";
            ColumnResult.MinimumWidth = 6;
            ColumnResult.Name = "ColumnResult";
            ColumnResult.Width = 60;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(603, 12);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(567, 429);
            chartFunction.TabIndex = 5;
            chartFunction.Text = "chartResult";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(chartFunction);
            Controls.Add(dataGridView);
            Controls.Add(buttonDone);
            Controls.Add(textBoxStopStep);
            Controls.Add(textBoxStartStep);
            Controls.Add(groupBoxTerm);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 19 | Айдемир А.Ф.";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTerm;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private Button buttonDone;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ColumnStart;
        private DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
