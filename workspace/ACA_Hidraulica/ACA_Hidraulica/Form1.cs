using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACA_Hidraulica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcoTeorico frm = new MarcoTeorico();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proyecto frm = new Proyecto();
            frm.Show();
        }
    }
}
