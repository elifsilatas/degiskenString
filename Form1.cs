namespace Degiskenler_String
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void Sring_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, meslek, cinsiyet;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            meslek = textBox4.Text;
            cinsiyet = textBox3.Text;

            string yas;
            yas = maskedTextBox1.Text;


            listBox1.Items.Add ( ad + " - " + soyad + " - " + yas + " - " + cinsiyet + " - " + meslek); 
        }
    }
}