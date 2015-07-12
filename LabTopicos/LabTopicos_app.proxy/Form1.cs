using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTopicos;

namespace LabTopicos_app.proxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Hide();
            lbres.Hide();
            lbk.Hide();
            tbK.Hide();
            lblConstante.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbPotencia_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Show();
            lbk.Show();
            lblConstante.Hide();
        }

        private void rbSimple_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
            lblConstante.Hide();
        }

        private void rbConstante_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Show();
            lbk.Hide();
            lblConstante.Show();
        }

        private void rbLogaritmo_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
            lblConstante.Hide();
        }

        private void rbExponencial_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
            lblConstante.Hide();
        }

        private void rbSeno_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
            lblConstante.Hide();
        }

        private void rbCoseno_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
            lblConstante.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int opcion = 0;
            double valuea = double.Parse(tbA.Text);
            double valueb = double.Parse(tbB.Text);
            double valuek = 0;
            double constante = 0;


            Service1 lt = new Service1();

            if (rbSimple.Checked == true)
            {
                opcion = 1;
                lblResultado.Text = ""+lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbConstante.Checked == true)
            {
                opcion = 2;
                constante = double.Parse(tbK.Text);
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbPotencia.Checked == true)
            {
                opcion = 3;
                valuek = double.Parse(tbK.Text);
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbLogaritmo.Checked == true)
            {
                opcion = 4;
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbExponencial.Checked == true)
            {
                opcion = 5;
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbSeno.Checked == true)
            {
                opcion = 6;
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbCoseno.Checked == true)
            {
                opcion = 7;
                lblResultado.Text = "" + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }

            lbres.Show();
            //lblResultado.Text = metodo(opcion, valuea, valueb, valuek);
            lblResultado.Show();


        }
    }
}
