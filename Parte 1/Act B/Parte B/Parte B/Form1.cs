namespace Parte_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_Avalor.Text);
            double b = Convert.ToDouble(txt_Bvalor.Text);
            double c = a + b;
            txt_Cvalor.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_Avalor.Text);
            double b = Convert.ToDouble(txt_Bvalor.Text);
            txt_Cvalor.Text = (a * b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_Avalor.Text);
            double b = Convert.ToDouble(txt_Bvalor.Text);
            if (b == 0)
            {
                MessageBox.Show("No podés dividir por cero.");
                return;
            }
            txt_Cvalor.Text = (a / b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_Avalor.Text);
            double b = Convert.ToDouble(txt_Bvalor.Text);
            txt_Cvalor.Text = (a - b).ToString();
        }
    }
}
