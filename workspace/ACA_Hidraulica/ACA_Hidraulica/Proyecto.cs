using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACA_Hidraulica
{
    public partial class Proyecto : Form
    {
        public Proyecto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalculo1.Checked)
            {
                checkBoxCalculo2.Enabled = false;
            }
            else
            {
                checkBoxCalculo1.Enabled = true;
                checkBoxCalculo2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (checkBoxCalculo1.Checked)
            {
                PrimerFormulario primerFormulario = new PrimerFormulario();
                primerFormulario.ShowDialog();
            }
            if (checkBoxCalculo2.Checked)
            {
                SegundoEjFormulario segundoEjFormulario = new SegundoEjFormulario();
                segundoEjFormulario.ShowDialog();
            }
            this.Visible = true;
        }

        private void checkBoxCalculo2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalculo2.Checked)
            {
                checkBoxCalculo1.Enabled = false;
            }
            else
            {
                checkBoxCalculo1.Enabled = true;
                checkBoxCalculo2.Enabled = true;
            }
        }
    }
}
