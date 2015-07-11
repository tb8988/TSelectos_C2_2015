using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormService
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
            int opcion=0;
            int valuea=int.Parse(tbA.Text);
            int valueb=int.Parse(tbB.Text);
            int valuek=0;

            if (rbSimple.Checked == true) {
                opcion = 1;
            }else if (rbConstante.Checked == true){
                opcion = 2;
            }else if (rbPotencia.Checked == true){
                opcion = 3;
                valuek = int.Parse(tbK.Text);
            }else if (rbLogaritmo.Checked == true){
                opcion = 4;
            }else if (rbExponencial.Checked == true){
                opcion = 5;
            }else if (rbSeno.Checked == true){
                opcion = 6;
            }else if (rbCoseno.Checked == true){
                opcion = 7;
            }

            lbres.Show();
            //lblResultado.Text = metodo(opcion, valuea, valueb, valuek);
            lblResultado.Show();
            
            
        }
    }
}
