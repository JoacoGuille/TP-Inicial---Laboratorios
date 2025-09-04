using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parte_C
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lst1.Items.Add("Opción 1");
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                lst1.Items.Add("Opción 2");
                radioButton2.Checked = false;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

