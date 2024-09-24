using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpresionAlgoritmica
{
    public partial class frmEcuacion : Form
    {
        public frmEcuacion()
        {
            InitializeComponent();
        }

        double a, b, c, resultado;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEcuacion_Load(object sender, EventArgs e)
        {

        }

        private void AsignarDatos()
        {
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
        }
    }
}
