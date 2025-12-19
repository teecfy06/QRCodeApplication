namespace ORCodeApplication
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
            btnGenerateQR = new Button();
            btnReaderQR = new Button();
            SuspendLayout();
            // 
            // btnGenerateQR
            // 
            btnGenerateQR.Location = new Point(-2, 1);
            btnGenerateQR.Name = "btnGenerateQR";
            btnGenerateQR.Size = new Size(803, 211);
            btnGenerateQR.TabIndex = 0;
            btnGenerateQR.Text = "Generate QR Code";
            btnGenerateQR.UseVisualStyleBackColor = true;
            btnGenerateQR.Click += btnGenerateQR_Click;
            // 
            // btnReaderQR
            // 
            btnReaderQR.Location = new Point(-2, 211);
            btnReaderQR.Name = "btnReaderQR";
            btnReaderQR.Size = new Size(803, 240);
            btnReaderQR.TabIndex = 1;
            btnReaderQR.Text = "Read QR Code";
            btnReaderQR.UseVisualStyleBackColor = true;
            btnReaderQR.Click += btnReaderQR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReaderQR);
            Controls.Add(btnGenerateQR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerateQR;
        private Button btnReaderQR;
    }
}
