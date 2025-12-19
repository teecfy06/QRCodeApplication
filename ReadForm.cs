using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using IronBarCode;

namespace ORCodeApplication
{
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "Image Files|*.png;*.jpg;*.bmp";
            if(dialog.ShowDialog() == DialogResult.OK )
            {
                Bitmap bitmap= new Bitmap(dialog.FileName);
                pictureBoxPreview.Image = bitmap;
                var result=BarcodeReader.Read(bitmap);
                if(result!=null)
                {
                    MessageBox.Show("QR Code Result:\n" + result[0].Text);
                }
                else
                {
                    MessageBox.Show("No QR Code found");
                }
            }
        }
    }
}
