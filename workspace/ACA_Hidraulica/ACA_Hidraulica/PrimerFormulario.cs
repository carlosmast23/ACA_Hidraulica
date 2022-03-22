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
        public List<float> densidades;
        public List<string> materiales;
        public List<float> rugosidad;
        public int temperaturaSeleccionada;
        public int materialSeleccionado;
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
            labelDensidad.Text = "" + densidades[temperaturaSeleccionada];
        }
        private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialSeleccionado = comboBoxMateriales.SelectedIndex;
            labelRugosidad.Text = "" + rugosidad[materialSeleccionado];
        }
        public void DatosIniciales()
        {
            temperaturas = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
            viscosidadesCinematica = new List<float> { 1.792f, 1.732f, 1.674f, 1.619f, 1.568f, 1.519f, 1.473f, 1.429f, 1.387f, 1.348f, 1.310f, 1.274f, 1.240f, 1.207f, 1.176f, 1.146f, 1.117f, 1.089f, 1.061f, 1.036f, 1.011f, 0.986f, 0.963f, 0.940f, 0.918f };
            densidades = new List<float> { 999.9f,999.9f,1000.0f, 1000.0f, 1000.0f, 1000.0f, 1000.0f, 999.9f, 999.9f, 999.8f, 999.7f, 999.6f, 999.5f, 999.4f, 999.3f, 999.1f, 999.0f, 998.8f, 998.6f, 998.4f, 998.2f, 998.0f, 997.8f, 997.6f, 997.5f };
            materiales = new List<string> { "Acero(tubos soldados)", "Acero(tubos estirados)", "Acero galvanizado", "Cobre o latón", "Plásticos(PVC, PE, PP)", "Poliéster reforzado con fibra de vidrio(PRFV)", "Fundición", "Hormigón"};
            rugosidad = new List<float> { 0.03f, 0.0024f, 0.06f, 0.015f, 0.0015f, 0.01f, 0.12f, 0.3f };
        }
        public void CargarCombo()
        {
            foreach (var temperatura in temperaturas)
            {
                comboBox1.Items.Add(temperatura);
            }
            foreach(var material in materiales)
            {
                comboBoxMateriales.Items.Add(material);
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

        private void PrimerFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
