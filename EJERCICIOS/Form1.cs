using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, n5;
            double promedio;

            n1 = double.Parse(txtNotauno.Text);
            n2 = double.Parse(txtNotados.Text);
            n3 = double.Parse(txtNotatres.Text);
            n4 = double.Parse(txtNotacuatro.Text);
            n5 =double.Parse(txtNotacinco.Text);

            promedio = (n1 + n2 + n3 + n4 + n5) / 5;

            lblPromedio.Text = promedio.ToString();

            if (promedio > 10)
            {
                lblCondicion.Text = "Aprobado";
                lblCondicion.ForeColor = Color.Blue;
                
            }
            else
            {
                lblCondicion.Text = "Desaprobado";
                lblCondicion.ForeColor = Color.Red;
            }
           
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtCurso.Clear();
            txtNombre.Clear();
            txtNotauno.Clear();
            txtNotados.Clear();
            txtNotatres.Clear();
            txtNotacuatro.Clear();
            txtNotacinco.Clear();
        }

        private void txtNotauno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
