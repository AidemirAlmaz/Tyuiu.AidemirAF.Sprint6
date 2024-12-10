namespace Tyuiu.AidemirAF.Sprint6.Task6.V30
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
            openFileDialogTask_AAF = new OpenFileDialog();
            toolTip_AAF = new ToolTip(components);
            buttonOpen_AAF = new Button();
            panelTopTop_AAF = new Panel();
            buttonDone_AAF = new Button();
            buttonHelp_AAF = new Button();
            panelTop_AAF = new Panel();
            groupBoxTerm_AAF = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_AAF = new Panel();
            groupBoxInPut_AAF = new GroupBox();
            textBoxInPut_AAF = new TextBox();
            panelRight_AAF = new Panel();
            groupBoxOutPut_AAF = new GroupBox();
            textBoxResult_AAF = new TextBox();
            panelTopTop_AAF.SuspendLayout();
            panelTop_AAF.SuspendLayout();
            groupBoxTerm_AAF.SuspendLayout();
            panelLeft_AAF.SuspendLayout();
            groupBoxInPut_AAF.SuspendLayout();
            panelRight_AAF.SuspendLayout();
            groupBoxOutPut_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask_AAF
            // 
            openFileDialogTask_AAF.FileName = "openFileDialog1";
            // 
            // toolTip_AAF
            // 
            toolTip_AAF.ToolTipIcon = ToolTipIcon.Info;
            toolTip_AAF.ToolTipTitle = "Подсказка";
            // 
            // buttonOpen_AAF
            // 
            buttonOpen_AAF.Image = (Image)resources.GetObject("buttonOpen_AAF.Image");
            buttonOpen_AAF.Location = new Point(12, 8);
            buttonOpen_AAF.Name = "buttonOpen_AAF";
            buttonOpen_AAF.Size = new Size(94, 63);
            buttonOpen_AAF.TabIndex = 1;
            toolTip_AAF.SetToolTip(buttonOpen_AAF, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_AAF.UseVisualStyleBackColor = true;
            buttonOpen_AAF.Click += buttonOpen_AAF_Click_1;
            // 
            // panelTopTop_AAF
            // 
            panelTopTop_AAF.Controls.Add(buttonOpen_AAF);
            panelTopTop_AAF.Controls.Add(buttonDone_AAF);
            panelTopTop_AAF.Controls.Add(buttonHelp_AAF);
            panelTopTop_AAF.Dock = DockStyle.Top;
            panelTopTop_AAF.Location = new Point(0, 0);
            panelTopTop_AAF.Name = "panelTopTop_AAF";
            panelTopTop_AAF.Padding = new Padding(5);
            panelTopTop_AAF.Size = new Size(897, 77);
            panelTopTop_AAF.TabIndex = 0;
            // 
            // buttonDone_AAF
            // 
            buttonDone_AAF.Image = (Image)resources.GetObject("buttonDone_AAF.Image");
            buttonDone_AAF.Location = new Point(124, 8);
            buttonDone_AAF.Name = "buttonDone_AAF";
            buttonDone_AAF.Size = new Size(94, 63);
            buttonDone_AAF.TabIndex = 2;
            toolTip_AAF.SetToolTip(buttonDone_AAF, "Производит поиск в файле четвертого слова в каждой строке\r\nи выводит эти слова");
            buttonDone_AAF.UseVisualStyleBackColor = true;
            buttonDone_AAF.Click += buttonDone_AAF_Click;
            // 
            // buttonHelp_AAF
            // 
            buttonHelp_AAF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAF.Image = (Image)resources.GetObject("buttonHelp_AAF.Image");
            buttonHelp_AAF.Location = new Point(791, 8);
            buttonHelp_AAF.Name = "buttonHelp_AAF";
            buttonHelp_AAF.Size = new Size(94, 63);
            buttonHelp_AAF.TabIndex = 3;
            toolTip_AAF.SetToolTip(buttonHelp_AAF, "Сведения о программе");
            buttonHelp_AAF.UseVisualStyleBackColor = true;
            buttonHelp_AAF.Click += buttonHelp_AAF_Click;
            // 
            // panelTop_AAF
            // 
            panelTop_AAF.Controls.Add(groupBoxTerm_AAF);
            panelTop_AAF.Dock = DockStyle.Top;
            panelTop_AAF.Location = new Point(0, 77);
            panelTop_AAF.Name = "panelTop_AAF";
            panelTop_AAF.Padding = new Padding(5);
            panelTop_AAF.Size = new Size(897, 113);
            panelTop_AAF.TabIndex = 0;
            // 
            // groupBoxTerm_AAF
            // 
            groupBoxTerm_AAF.Controls.Add(textBox1);
            groupBoxTerm_AAF.Dock = DockStyle.Fill;
            groupBoxTerm_AAF.Location = new Point(5, 5);
            groupBoxTerm_AAF.Name = "groupBoxTerm_AAF";
            groupBoxTerm_AAF.Size = new Size(887, 103);
            groupBoxTerm_AAF.TabIndex = 0;
            groupBoxTerm_AAF.TabStop = false;
            groupBoxTerm_AAF.Text = "Условие :";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(881, 77);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeft_AAF
            // 
            panelLeft_AAF.Controls.Add(groupBoxInPut_AAF);
            panelLeft_AAF.Dock = DockStyle.Left;
            panelLeft_AAF.Location = new Point(0, 190);
            panelLeft_AAF.Name = "panelLeft_AAF";
            panelLeft_AAF.Padding = new Padding(5);
            panelLeft_AAF.Size = new Size(475, 328);
            panelLeft_AAF.TabIndex = 0;
            // 
            // groupBoxInPut_AAF
            // 
            groupBoxInPut_AAF.Controls.Add(textBoxInPut_AAF);
            groupBoxInPut_AAF.Dock = DockStyle.Fill;
            groupBoxInPut_AAF.Location = new Point(5, 5);
            groupBoxInPut_AAF.Name = "groupBoxInPut_AAF";
            groupBoxInPut_AAF.Size = new Size(465, 318);
            groupBoxInPut_AAF.TabIndex = 0;
            groupBoxInPut_AAF.TabStop = false;
            groupBoxInPut_AAF.Text = "Ввод :";
            // 
            // textBoxInPut_AAF
            // 
            textBoxInPut_AAF.Dock = DockStyle.Fill;
            textBoxInPut_AAF.Location = new Point(3, 23);
            textBoxInPut_AAF.Multiline = true;
            textBoxInPut_AAF.Name = "textBoxInPut_AAF";
            textBoxInPut_AAF.Size = new Size(459, 292);
            textBoxInPut_AAF.TabIndex = 1;
            // 
            // panelRight_AAF
            // 
            panelRight_AAF.Controls.Add(groupBoxOutPut_AAF);
            panelRight_AAF.Dock = DockStyle.Right;
            panelRight_AAF.Location = new Point(481, 190);
            panelRight_AAF.Name = "panelRight_AAF";
            panelRight_AAF.Padding = new Padding(5);
            panelRight_AAF.Size = new Size(416, 328);
            panelRight_AAF.TabIndex = 0;
            // 
            // groupBoxOutPut_AAF
            // 
            groupBoxOutPut_AAF.Controls.Add(textBoxResult_AAF);
            groupBoxOutPut_AAF.Dock = DockStyle.Fill;
            groupBoxOutPut_AAF.Location = new Point(5, 5);
            groupBoxOutPut_AAF.Name = "groupBoxOutPut_AAF";
            groupBoxOutPut_AAF.Size = new Size(406, 318);
            groupBoxOutPut_AAF.TabIndex = 0;
            groupBoxOutPut_AAF.TabStop = false;
            groupBoxOutPut_AAF.Text = "Вывод :";
            // 
            // textBoxResult_AAF
            // 
            textBoxResult_AAF.Dock = DockStyle.Fill;
            textBoxResult_AAF.Location = new Point(3, 23);
            textBoxResult_AAF.Multiline = true;
            textBoxResult_AAF.Name = "textBoxResult_AAF";
            textBoxResult_AAF.Size = new Size(400, 292);
            textBoxResult_AAF.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 518);
            Controls.Add(panelLeft_AAF);
            Controls.Add(panelRight_AAF);
            Controls.Add(panelTop_AAF);
            Controls.Add(panelTopTop_AAF);
            Name = "FormMain";
            Text = "Form1";
            panelTopTop_AAF.ResumeLayout(false);
            panelTop_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.ResumeLayout(false);
            groupBoxTerm_AAF.PerformLayout();
            panelLeft_AAF.ResumeLayout(false);
            groupBoxInPut_AAF.ResumeLayout(false);
            groupBoxInPut_AAF.PerformLayout();
            panelRight_AAF.ResumeLayout(false);
            groupBoxOutPut_AAF.ResumeLayout(false);
            groupBoxOutPut_AAF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask_AAF;
        private ToolTip toolTip_AAF;
        private Panel panelTopTop_AAF;
        private Panel panelTop_AAF;
        private Panel panelLeft_AAF;
        private Panel panelRight_AAF;
        private GroupBox groupBoxTerm_AAF;
        private TextBox textBox1;
        private Button buttonHelp_AAF;
        private GroupBox groupBoxInPut_AAF;
        private TextBox textBoxInPut_AAF;
        private GroupBox groupBoxOutPut_AAF;
        private Button buttonDone_AAF;
        private Button buttonOpen_AAF;
        private TextBox textBoxResult_AAF;
    }
}
