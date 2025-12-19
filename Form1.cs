namespace QRCodeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            GenerateForm genForm=new GenerateForm();
            genForm.Show();
        }

        private void btnReaderQR_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm();
            readForm.Show();
        }
    }
}
