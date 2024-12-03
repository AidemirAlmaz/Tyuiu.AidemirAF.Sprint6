namespace Tyuiu.AidemirAF.Sprint6.Task0.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask = new TextBox();
            pictureBoxTask = new PictureBox();
            buttonResult = new Button();
            textBoxResults = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold);
            textBoxTask.Location = new Point(12, 12);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(425, 171);
            textBoxTask.TabIndex = 4;
            textBoxTask.Text = "Вычислить значение при х = 2 по формуле: ";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(462, 12);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(280, 46);
            pictureBoxTask.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxTask.TabIndex = 5;
            pictureBoxTask.TabStop = false;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = SystemColors.Control;
            buttonResult.Location = new Point(634, 387);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(154, 51);
            buttonResult.TabIndex = 6;
            buttonResult.Text = "Вычислить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(652, 325);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.ReadOnly = true;
            textBoxResults.Size = new Size(125, 27);
            textBoxResults.TabIndex = 2;
            //textBoxResults.TextChanged += textBoxResults_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult);
            Controls.Add(pictureBoxTask);
            Controls.Add(textBoxTask);
            Controls.Add(textBoxResults);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0| Вариант 21 | Айдемир А.Ф.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTask;
        private PictureBox pictureBoxTask;
        private Button buttonResult;
        private TextBox textBoxResults;
    }
}
