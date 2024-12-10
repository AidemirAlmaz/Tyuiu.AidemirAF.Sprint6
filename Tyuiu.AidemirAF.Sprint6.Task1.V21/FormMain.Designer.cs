namespace Tyuiu.AidemirAF.Sprint6.Task1.V21
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
            button_Done = new Button();
            textBox_Result = new TextBox();
            groupBox_Term = new GroupBox();
            textBox_StartStep = new TextBox();
            textBox_StopStep = new TextBox();
            SuspendLayout();
            // 
            // button_Done
            // 
            button_Done.BackColor = Color.RoyalBlue;
            button_Done.Location = new Point(663, 394);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(125, 44);
            button_Done.TabIndex = 0;
            button_Done.Text = "Выпонить";
            button_Done.UseVisualStyleBackColor = false;
            button_Done.Click += button_Done_Click;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Result.Location = new Point(526, 12);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.ScrollBars = ScrollBars.Vertical;
            textBox_Result.Size = new Size(262, 341);
            textBox_Result.TabIndex = 1;
            // 
            // groupBox_Term
            // 
            groupBox_Term.Location = new Point(12, 12);
            groupBox_Term.Name = "groupBox_Term";
            groupBox_Term.Size = new Size(487, 341);
            groupBox_Term.TabIndex = 2;
            groupBox_Term.TabStop = false;
            groupBox_Term.Text = "Протабулировать функцию cos(x) + sin(x)/(2 - 2x) - 4x.               Результат вывести на экран.";
            // 
            // textBox_StartStep
            // 
            textBox_StartStep.Location = new Point(12, 394);
            textBox_StartStep.Name = "textBox_StartStep";
            textBox_StartStep.Size = new Size(125, 27);
            textBox_StartStep.TabIndex = 3;
            textBox_StartStep.Text = "-5";
            // 
            // textBox_StopStep
            // 
            textBox_StopStep.Location = new Point(169, 394);
            textBox_StopStep.Name = "textBox_StopStep";
            textBox_StopStep.Size = new Size(125, 27);
            textBox_StopStep.TabIndex = 4;
            textBox_StopStep.Text = "5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_StopStep);
            Controls.Add(textBox_StartStep);
            Controls.Add(groupBox_Term);
            Controls.Add(textBox_Result);
            Controls.Add(button_Done);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Done;
        private TextBox textBox_Result;
        private GroupBox groupBox_Term;
        private TextBox textBox_StartStep;
        private TextBox textBox_StopStep;
    }
}
