namespace QRCodeApplication
{
    partial class GenerateForm
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
            txtInput = new TextBox();
            btnGenerate = new Button();
            pictureBoxQR = new PictureBox();
            labelInput = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(-1, 21);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(402, 42);
            txtInput.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(120, 65);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 35);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate QR Code";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxQR.Location = new Point(22, 106);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(355, 355);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQR.TabIndex = 2;
            pictureBoxQR.TabStop = false;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(-1, -2);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(223, 20);
            labelInput.TabIndex = 3;
            labelInput.Text = "Enter text to generate QR Code :";
            // 
            // GenerateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 473);
            Controls.Add(labelInput);
            Controls.Add(pictureBoxQR);
            Controls.Add(btnGenerate);
            Controls.Add(txtInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GenerateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnGenerate;
        private PictureBox pictureBoxQR;
        private Label labelInput;
    }
}