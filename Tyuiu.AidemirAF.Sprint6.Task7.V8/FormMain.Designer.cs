namespace Tyuiu.AidemirAF.Sprint6.Task7.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_AAF = new Button();
            buttonSave_AAF = new Button();
            buttonResult_AAF = new Button();
            buttonOpen_AAF = new Button();
            panel2 = new Panel();
            groupBoxTerm_AAF = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBoxIn_AAF = new GroupBox();
            dataGridViewIn_AAF = new DataGridView();
            panel4 = new Panel();
            groupBoxOut_AAF = new GroupBox();
            dataGridViewOut_AAF = new DataGridView();
            openFileDialogTask_AAF = new OpenFileDialog();
            saveFileDialogMtrx_AAF = new SaveFileDialog();
            toolTip_AAF = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTerm_AAF.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxIn_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AAF).BeginInit();
            panel4.SuspendLayout();
            groupBoxOut_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AAF).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_AAF);
            panel1.Controls.Add(buttonSave_AAF);
            panel1.Controls.Add(buttonResult_AAF);
            panel1.Controls.Add(buttonOpen_AAF);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_AAF
            // 
            buttonHelp_AAF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAF.Image = (Image)resources.GetObject("buttonHelp_AAF.Image");
            buttonHelp_AAF.Location = new Point(694, 10);
            buttonHelp_AAF.Name = "buttonHelp_AAF";
            buttonHelp_AAF.Size = new Size(94, 59);
            buttonHelp_AAF.TabIndex = 3;
            buttonHelp_AAF.UseVisualStyleBackColor = true;
            buttonHelp_AAF.Click += buttonHelp_AAF_Click;
            // 
            // buttonSave_AAF
            // 
            buttonSave_AAF.Image = (Image)resources.GetObject("buttonSave_AAF.Image");
            buttonSave_AAF.Location = new Point(212, 8);
            buttonSave_AAF.Name = "buttonSave_AAF";
            buttonSave_AAF.Size = new Size(94, 63);
            buttonSave_AAF.TabIndex = 2;
            buttonSave_AAF.UseVisualStyleBackColor = true;
            buttonSave_AAF.Click += buttonSave_AAF_Click;
            // 
            // buttonResult_AAF
            // 
            buttonResult_AAF.Image = (Image)resources.GetObject("buttonResult_AAF.Image");
            buttonResult_AAF.Location = new Point(112, 8);
            buttonResult_AAF.Name = "buttonResult_AAF";
            buttonResult_AAF.Size = new Size(94, 63);
            buttonResult_AAF.TabIndex = 1;
            buttonResult_AAF.UseVisualStyleBackColor = true;
            buttonResult_AAF.Click += buttonResult_AAF_Click;
            // 
            // buttonOpen_AAF
            // 
            buttonOpen_AAF.Image = (Image)resources.GetObject("buttonOpen_AAF.Image");
            buttonOpen_AAF.Location = new Point(12, 8);
            buttonOpen_AAF.Name = "buttonOpen_AAF";
            buttonOpen_AAF.Size = new Size(94, 63);
            buttonOpen_AAF.TabIndex = 0;
            toolTip_AAF.SetToolTip(buttonOpen_AAF, "Загрузить файл");
            buttonOpen_AAF.UseVisualStyleBackColor = true;
            buttonOpen_AAF.Click += buttonOpen_AAF_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTerm_AAF);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 154);
            panel2.TabIndex = 0;
            // 
            // groupBoxTerm_AAF
            // 
            groupBoxTerm_AAF.Controls.Add(textBox1);
            groupBoxTerm_AAF.Dock = DockStyle.Fill;
            groupBoxTerm_AAF.Location = new Point(0, 0);
            groupBoxTerm_AAF.Name = "groupBoxTerm_AAF";
            groupBoxTerm_AAF.Size = new Size(800, 154);
            groupBoxTerm_AAF.TabIndex = 4;
            groupBoxTerm_AAF.TabStop = false;
            groupBoxTerm_AAF.Text = "Условие :";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(794, 128);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxIn_AAF);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 218);
            panel3.TabIndex = 0;
            // 
            // groupBoxIn_AAF
            // 
            groupBoxIn_AAF.Controls.Add(dataGridViewIn_AAF);
            groupBoxIn_AAF.Dock = DockStyle.Fill;
            groupBoxIn_AAF.Location = new Point(0, 0);
            groupBoxIn_AAF.Name = "groupBoxIn_AAF";
            groupBoxIn_AAF.Size = new Size(460, 218);
            groupBoxIn_AAF.TabIndex = 0;
            groupBoxIn_AAF.TabStop = false;
            groupBoxIn_AAF.Text = "Ввод данных :";
            // 
            // dataGridViewIn_AAF
            // 
            dataGridViewIn_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_AAF.Dock = DockStyle.Fill;
            dataGridViewIn_AAF.Location = new Point(3, 23);
            dataGridViewIn_AAF.Name = "dataGridViewIn_AAF";
            dataGridViewIn_AAF.RowHeadersWidth = 51;
            dataGridViewIn_AAF.Size = new Size(454, 192);
            dataGridViewIn_AAF.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOut_AAF);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(466, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 218);
            panel4.TabIndex = 0;
            // 
            // groupBoxOut_AAF
            // 
            groupBoxOut_AAF.Controls.Add(dataGridViewOut_AAF);
            groupBoxOut_AAF.Dock = DockStyle.Fill;
            groupBoxOut_AAF.Location = new Point(0, 0);
            groupBoxOut_AAF.Name = "groupBoxOut_AAF";
            groupBoxOut_AAF.Size = new Size(334, 218);
            groupBoxOut_AAF.TabIndex = 4;
            groupBoxOut_AAF.TabStop = false;
            groupBoxOut_AAF.Text = "Вывод данных :";
            // 
            // dataGridViewOut_AAF
            // 
            dataGridViewOut_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_AAF.Dock = DockStyle.Fill;
            dataGridViewOut_AAF.Location = new Point(3, 23);
            dataGridViewOut_AAF.Name = "dataGridViewOut_AAF";
            dataGridViewOut_AAF.RowHeadersWidth = 51;
            dataGridViewOut_AAF.Size = new Size(328, 192);
            dataGridViewOut_AAF.TabIndex = 0;
            // 
            // openFileDialogTask_AAF
            // 
            openFileDialogTask_AAF.FileName = "openFileDialogTask_AAF";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 8 | Айдемир А.Ф.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTerm_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxIn_AAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_AAF).EndInit();
            panel4.ResumeLayout(false);
            groupBoxOut_AAF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_AAF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_AAF;
        private Button buttonSave_AAF;
        private Button buttonResult_AAF;
        private Button buttonOpen_AAF;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBoxTerm_AAF;
        private TextBox textBox1;
        private GroupBox groupBoxIn_AAF;
        private DataGridView dataGridViewIn_AAF;
        private GroupBox groupBoxOut_AAF;
        private DataGridView dataGridViewOut_AAF;
        private OpenFileDialog openFileDialogTask_AAF;
        private SaveFileDialog saveFileDialogMtrx_AAF;
        private ToolTip toolTip_AAF;
    }
}
