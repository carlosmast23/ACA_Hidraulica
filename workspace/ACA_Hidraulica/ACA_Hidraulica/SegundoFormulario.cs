using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACA_Hidraulica
{
    public partial class SegundoFormulario : Form
    {
        private double perdidasLocales=0;
        private double potenciaNeta = 0;
        private double potenciaInstalada = 0;

        public SegundoFormulario(double perdidasLocales, double potenciaNeta, double potenciaInstalada)
        {
            InitializeComponent();
            this.perdidasLocales = perdidasLocales;
            this.potenciaNeta = potenciaNeta;
            this.potenciaInstalada = potenciaInstalada;
            cargarResultados();
        }

        private void cargarResultados()
        {
            txtPerdidasLocales.Text = perdidasLocales.ToString();
            txtPotenciaNeta.Text = potenciaNeta.ToString();
            txtPotenciaInstalada.Text = potenciaInstalada.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textDiametro_TextChanged(object sender, EventArgs e)
        {

        }

        private void SegundoFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
