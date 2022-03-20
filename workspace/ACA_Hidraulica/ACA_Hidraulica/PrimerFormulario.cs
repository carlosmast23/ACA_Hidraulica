using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACA_Hidraulica
{
    public partial class PrimerFormulario : Form
    {
        public List<int> temperaturas;
        public List<float> viscosidadesCinematica;
        public int temperaturaSeleccionada;
        public float viscosidadCinematica;
        public PrimerFormulario()
        {
            InitializeComponent();
            DatosIniciales();
            CargarCombo();
            temperaturaSeleccionada = 0;
            BloquearText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temperaturaSeleccionada = comboBox1.SelectedIndex;
            viscosidadCinematica = (float)Math.Pow(viscosidadesCinematica[temperaturaSeleccionada], -6);
            labelViscosidadCinematica.Text = "" + viscosidadCinematica;
        }
        public void DatosIniciales()
        {
            temperaturas = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            viscosidadesCinematica = new List<float> { 1.792f, 1.732f, 1.674f, 1.619f, 1.568f, 1.519f, 1.473f, 1.429f, 1.387f, 1.348f, 1.310f, 1.274f, 1.240f, 1.207f, 1.176f, 1.146f, 1.117f, 1.089f, 1.061f, 1.036f, 1.011f, 0.986f, 0.963f, 0.940f, 0.918f };
        }
        public void CargarCombo()
        {
            foreach (var temperatura in temperaturas)
            {
                comboBox1.Items.Add(temperatura);
            }            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textCaudal.Enabled = true;
                textVelocidad.Enabled = false;
                checkBox2.Checked = false;
            }
        }
        private void BloquearText()
        {
            textCaudal.Enabled = false;
            textVelocidad.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textCaudal.Enabled = false;
                textVelocidad.Enabled = true;
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                //float Reinolds = 
            }

            if (checkBox2.Checked)
            {
                if(textVelocidad.Text.Length == 0 || textDiametro.Text.Length == 0 || labelViscosidadCinematica.Text.Length>0)
                {
                    MessageBox.Show("Ingrese todos los datos necesarios para calcular!!");
                    return;
                }
                double Reinolds = (Convert.ToDouble(textVelocidad.Text) * Convert.ToDouble(textDiametro.Text)) / Convert.ToDouble(labelViscosidadCinematica.Text);
                textResultado.Text = "" + Reinolds;
            }

            if(!checkBox1.Checked || !checkBox2.Checked)
            {
                MessageBox.Show("Ingrese todos los datos necesarios para calcular!!");
            }
        }
    }
}
