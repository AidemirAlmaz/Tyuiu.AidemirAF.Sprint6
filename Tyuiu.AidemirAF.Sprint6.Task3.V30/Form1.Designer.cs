namespace Tyuiu.AidemirAF.Sprint6.Task3.V30
{
    partial class Form1
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
            buttonDone = new Button();
            helpProvider1 = new HelpProvider();
            buttonHelp = new Button();
            textBoxData = new TextBox();
            dataGridViewMtrx = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(661, 391);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(127, 47);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(598, 391);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(45, 47);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(12, 12);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(417, 294);
            textBoxData.TabIndex = 3;
            textBoxData.Text = "Дан массив 5 на 5 элементов. \r\n\r\n -9  -4  17  -1 -20\r\n\r\n -19  18  -4   2  14\r\n\r\n -12  16  -2   7  18\r\n\r\n -16  15   4 -12 -13\r\n\r\n -15  -4 -16   1 -14\r\n\r\nЗаменить четные значения в пятой строке на 0.";
            // 
            // dataGridViewMtrx
            // 
            dataGridViewMtrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx.Location = new Point(450, 12);
            dataGridViewMtrx.Name = "dataGridViewMtrx";
            dataGridViewMtrx.ReadOnly = true;
            dataGridViewMtrx.RowHeadersWidth = 51;
            dataGridViewMtrx.Size = new Size(267, 244);
            dataGridViewMtrx.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMtrx);
            Controls.Add(textBoxData);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private HelpProvider helpProvider1;
        private Button buttonHelp;
        private TextBox textBoxData;
        private DataGridView dataGridViewMtrx;
    }
}
