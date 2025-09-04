namespace Parte_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Txt1.Text = "";
            Txt2.Text = "";
            TxtRta.Text = "";

        }

        private void Btnif_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txt1.Text, out int n1) && int.TryParse(Txt2.Text, out int n2))
            {
                if (Optresta.Checked)
                {
                    TxtRta.Text = (n1 - n2).ToString();
                }

                if (Optsuma.Checked)
                {
                    TxtRta.Text = (n1 + n2).ToString();
                }

                if (OptCoc.Checked && n2 != 0)
                {
                    TxtRta.Text = (n1 / n2).ToString();
                }

                if (Optprod.Checked)
                {
                    TxtRta.Text = (n1 * n2).ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingresá valores numéricos válidos.");
            }
        }


        private void btnswitch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txt1.Text, out int n1) && int.TryParse(Txt2.Text, out int n2))
            {
                int opcion = 0;
                if (Optsuma.Checked) opcion = 1;
                if (Optresta.Checked) opcion = 2;
                if (Optprod.Checked) opcion = 3;
                if (OptCoc.Checked && n2 != 0) opcion = 4;

                switch (opcion)
                {
                    case 1:
                        TxtRta.Text = (n1 + n2).ToString();
                        break;
                    case 2:
                        TxtRta.Text = (n1 - n2).ToString();
                        break;
                    case 3:
                        TxtRta.Text = (n1 * n2).ToString();
                        break;
                    case 4:
                        TxtRta.Text = (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("La operación no se puede realizar.");
                        limpiar();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ingresá valores numéricos válidos.");
            }
        }
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            Txt1.Text = "";
            Txt2.Text = "";
            TxtRta.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Optresta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OptCoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Optprod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
 
