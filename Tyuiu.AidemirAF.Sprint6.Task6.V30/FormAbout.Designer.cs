namespace Tyuiu.AidemirAF.Sprint6.Task6.V30
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
            textBoxAbout_AAF = new TextBox();
            pictureBoxAvatar_AAF = new PictureBox();
            buttonOK_AAF = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAF).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout_AAF
            // 
            textBoxAbout_AAF.Location = new Point(372, 12);
            textBoxAbout_AAF.Multiline = true;
            textBoxAbout_AAF.Name = "textBoxAbout_AAF";
            textBoxAbout_AAF.Size = new Size(240, 440);
            textBoxAbout_AAF.TabIndex = 0;
            textBoxAbout_AAF.Text = resources.GetString("textBoxAbout_AAF.Text");
            // 
            // pictureBoxAvatar_AAF
            // 
            pictureBoxAvatar_AAF.ErrorImage = (Image)resources.GetObject("pictureBoxAvatar_AAF.ErrorImage");
            pictureBoxAvatar_AAF.Image = (Image)resources.GetObject("pictureBoxAvatar_AAF.Image");
            pictureBoxAvatar_AAF.ImageLocation = "12:12";
            pictureBoxAvatar_AAF.InitialImage = null;
            pictureBoxAvatar_AAF.Location = new Point(12, 12);
            pictureBoxAvatar_AAF.Name = "pictureBoxAvatar_AAF";
            pictureBoxAvatar_AAF.Size = new Size(320, 449);
            pictureBoxAvatar_AAF.TabIndex = 1;
            pictureBoxAvatar_AAF.TabStop = false;
            // 
            // buttonOK_AAF
            // 
            buttonOK_AAF.Location = new Point(518, 458);
            buttonOK_AAF.Name = "buttonOK_AAF";
            buttonOK_AAF.Size = new Size(94, 29);
            buttonOK_AAF.TabIndex = 2;
            buttonOK_AAF.Text = "Ok";
            buttonOK_AAF.UseVisualStyleBackColor = true;
            buttonOK_AAF.Click += buttonOK_AAF_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 499);
            Controls.Add(buttonOK_AAF);
            Controls.Add(pictureBoxAvatar_AAF);
            Controls.Add(textBoxAbout_AAF);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О пргорамме";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_AAF;
        private PictureBox pictureBoxAvatar_AAF;
        private Button buttonOK_AAF;
    }
}