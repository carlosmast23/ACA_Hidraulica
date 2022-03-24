using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACA_Hidraulica
{
    public partial class SegundoEjFormulario : Form
    {
        public double gravedad = 9.80665;

        public List<int> temperaturas;
        public List<float> viscosidadesCinematica;
        public List<float> densidades;
        public List<string> materiales;
        public List<float> rugosidad;
        public int temperaturaSeleccionada;
        public int materialSeleccionado;
        public float viscosidadCinematica;
        public SegundoEjFormulario()
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
            viscosidadCinematica = (float)viscosidadesCinematica[temperaturaSeleccionada]*(float)Math.Pow(10, -6);
            labelViscosidadCinematica.Text = "" + viscosidadCinematica;
            labelDensidad.Text = "" + densidades[temperaturaSeleccionada];
        }
        private void comboBoxMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialSeleccionado = comboBoxMateriales.SelectedIndex;
            labelRugosidad.Text = "" + ((float)rugosidad[materialSeleccionado]/1000)*(float)Math.Pow(10, -6);
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

        private double calcularArea()
        {
            double area = (Math.PI / 4) * (Math.Pow(Convert.ToDouble(textDiametro.Text), 2));
            return area;
        }

        private double calcularVelocidad()
        {
            double velocidad = Convert.ToDouble(textCaudal.Text) / calcularArea();
            return velocidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                double velocidad = calcularVelocidad();
                textVelocidad.Text = velocidad.ToString();

            }

            //if (checkBox2.Checked)
            //{
                //if(textVelocidad.Text.Length == 0 || textDiametro.Text.Length == 0 || labelViscosidadCinematica.Text.Length==0)
                //{
                //    MessageBox.Show("Ingrese todos los datos necesarios para calcular!!");
                //    return;
                //}

                double Reinolds = (Convert.ToDouble(textVelocidad.Text) * Convert.ToDouble(textDiametro.Text)) / Convert.ToDouble(labelViscosidadCinematica.Text);
                lblReynolds.Text= "" + Reinolds;

                if (Reinolds < 2000)
                {
                    textResultado.Text = "Flujo Laminar";
                }
                else if (Reinolds > 4000)
                {
                    textResultado.Text = "Flujo Turbulento";
                }
                else
                {
                    textResultado.Text = "Ingrese datos nuevamente";
                }
            perdidasLongitudinales();
            //}

            //if(!checkBox1.Checked || !checkBox2.Checked)
            //{
            //    MessageBox.Show("Ingrese todos los datos necesarios para calcular!!");
            //}
        }

        private void PrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SegundoFormulario segundoFormulario = new SegundoFormulario(obtenerPerdidasLocales(),potenciaNeta(),potenciaInstalada(),calcularPotenciaLongitudinal());
            segundoFormulario.ShowDialog();
            this.Visible = true;
        }

        private double obtenerPerdidasLocales()
        {
            double resultado = (Convert.ToDouble(labelRugosidad.Text) * Convert.ToDouble(textVelocidad.Text)* Convert.ToDouble(textVelocidad.Text)) / (2*gravedad);
            return resultado;
        }

        //Obtiene el caudal o la variable Q
        private double calcularCaudal()
        {
            double resultado = Convert.ToDouble(textVelocidad.Text) * calcularArea();
            return resultado;
        }

        private double calcularCaudalMasivo()
        { 
            double resultado= Convert.ToDouble(labelDensidad.Text) * calcularArea();
            return resultado;
        }

        private double potenciaNeta()
        {
            double resultado = Convert.ToDouble(textElevacion2.Text) - Convert.ToDouble(textElevacion1.Text) + obtenerPerdidasLocales();
            resultado = resultado * calcularCaudalMasivo() * gravedad;
            return resultado;
        }

        private double potenciaInstalada()
        {
            double resultado = potenciaNeta()* Convert.ToDouble(textEficiencia.Text) / 100;
            return resultado;
        }

        private double calcularF()
        {
            double reinolds = Convert.ToDouble(labelRugosidad.Text);
            double rugosidad = Convert.ToDouble(labelRugosidad.Text);
            double densidad = Convert.ToDouble(labelDensidad.Text);
            double diametro = Convert.ToDouble(textDiametro.Text);

            double resultado = (1 / 3.7) * (rugosidad / densidad);
            double numerador = 4.518 * Math.Log(reinolds / 7);
            double denominador = reinolds * (1+1/29*Math.Pow(reinolds,0.52)*Math.Pow((rugosidad/diametro),0.7));
            resultado = resultado + (numerador / denominador);
            resultado = Math.Pow(-2 * Math.Log(resultado), -2);

            return resultado;
        }
        private double perdidasLongitudinales()
        {
            double constante1 = 0.25f;
            double constante2 = 3.7f;
            double constante3 = 5.74f;
            double diametro = Convert.ToDouble(textDiametro.Text);
            double rugosidad = Convert.ToDouble(labelRugosidad.Text);
            double reinolds = Convert.ToDouble(labelRugosidad.Text);

            double fraccion1 = 1 / (constante2 * (diametro / rugosidad));
            double fraccion2 = constante3 / Math.Pow(reinolds, 0.9);
            double denominador = Math.Log(fraccion1 + fraccion2) * Math.Log(fraccion1 + fraccion2);
            double resultado = constante1 / denominador;
            Console.WriteLine("Perdidas longitudinales: " + resultado);
            return resultado;
        }
        private double perdidasLocales()
        {
            double rugosidad = Convert.ToDouble(labelRugosidad.Text);
            double velocidad = Convert.ToDouble(textVelocidad.Text);
            double resultado = rugosidad * ((velocidad * velocidad) / 2 * 9.8);
            Console.WriteLine("Perdidas locales: " + resultado);
            return resultado;
            
        }
        private double calcularPotenciaLongitudinal()
        {
            double resultado = calcularF() * (Convert.ToDouble(textLongitud.Text)/ Convert.ToDouble(textDiametro.Text))*(Math.Pow(Convert.ToDouble(textVelocidad.Text),2))/2*gravedad;
            return resultado;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDiametro.Text = "";
            textCaudal.Text = "";
            textVelocidad.Text = "";
            lblReynolds.Text = "0";
            textResultado.Text = "";

            textLongitud.Text = "";
            textElevacion1.Text = "";
            textElevacion2.Text = "";
            textEficiencia.Text = "";

        }
    }
}
