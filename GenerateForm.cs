using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using QRCoder;

namespace ORCodeApplication
{
    public partial class GenerateForm : Form
    {
        public GenerateForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(txtInput.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode=new QRCode(data);
            Bitmap qrImage = qrCode.GetGraphic(20);
            pictureBoxQR.Image = qrImage;
        }
    }
}
