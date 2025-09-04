using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_C
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            if (Chk1.Checked && !Chk2.Checked)
            {
                Lbl1.BackColor = Color.Aquamarine;
                Lbl2.BackColor = Color.Beige;
                Lbl3.BackColor = Color.Black;
            }
            else if (!Chk1.Checked && Chk2.Checked)
            {
                Lbl1.BackColor = Color.Green;
                Lbl2.BackColor = Color.LightPink;
                Lbl3.BackColor = Color.Linen;
            }
            else if (Chk1.Checked && Chk2.Checked)
            {
                Lbl1.BackColor = Color.Blue;
                Lbl2.BackColor = Color.White;
                Lbl3.BackColor = Color.Blue;
            }
            else
            {
                Lbl1.BackColor = DefaultBackColor;
                Lbl2.BackColor = DefaultBackColor;
                Lbl3.BackColor = DefaultBackColor;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
