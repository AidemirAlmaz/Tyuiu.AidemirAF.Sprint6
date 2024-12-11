namespace Tyuiu.AidemirAF.Sprint6.Task7.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBox1 = new TextBox();
            buttonOK_AAF = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 271);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOK_AAF
            // 
            buttonOK_AAF.Location = new Point(430, 280);
            buttonOK_AAF.Name = "buttonOK_AAF";
            buttonOK_AAF.Size = new Size(79, 29);
            buttonOK_AAF.TabIndex = 1;
            buttonOK_AAF.Text = "Ok";
            buttonOK_AAF.UseVisualStyleBackColor = true;
            buttonOK_AAF.Click += this.buttonOK_AAF_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 311);
            Controls.Add(buttonOK_AAF);
            Controls.Add(textBox1);
            Name = "FormAbout";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOK_AAF;
    }
}