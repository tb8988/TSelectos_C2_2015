﻿using System;
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
        }

        private void rbSimple_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
        }

        private void rbConstante_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
        }

        private void rbLogaritmo_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
        }

        private void rbExponencial_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
        }

        private void rbSeno_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();

        }

        private void rbCoseno_CheckedChanged(object sender, EventArgs e)
        {
            tbK.Hide();
            lbk.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int opcion = 0;
            double valuea = int.Parse(tbA.Text);
            double valueb = int.Parse(tbB.Text);
            double valuek = 0;
            double constante = 0;


            Service1 lt = new Service1();

            if (rbSimple.Checked == true)
            {
                opcion = 1;
                lblResultado.Text = "Resultdo de la integral simple: "+lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbConstante.Checked == true)
            {
                opcion = 2;
                lblResultado.Text = "Resultdo de la integral con una constante: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbPotencia.Checked == true)
            {
                opcion = 3;
                valuek = int.Parse(tbK.Text);
                lblResultado.Text = "Resultdo de la integral con potencia: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbLogaritmo.Checked == true)
            {
                opcion = 4;
                lblResultado.Text = "Resultdo de la integral con logaritmo: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbExponencial.Checked == true)
            {
                opcion = 5;
                lblResultado.Text = "Resultdo de la integral exponencal: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbSeno.Checked == true)
            {
                opcion = 6;
                lblResultado.Text = "Resultdo de la integral con seno: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }
            else if (rbCoseno.Checked == true)
            {
                opcion = 7;
                lblResultado.Text = "Resultdo de la integral con coseno: " + lt.CalculaIntegrales(valuea, valueb, valuek, constante, opcion);
            }

            lbres.Show();
            //lblResultado.Text = metodo(opcion, valuea, valueb, valuek);
            lblResultado.Show();


        }
    }
}
