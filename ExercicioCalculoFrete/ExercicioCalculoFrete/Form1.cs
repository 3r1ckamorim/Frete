using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCalculoFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularFrete_Click(object sender, EventArgs e)
        {
            var frete = 0.0;
            var total = 0.0;
            var valor = 0.0;
            string uf = cbxUf.Text;

            valor = double.Parse(txtValor.Text);

            if(valor > 1000.0)
            {
                frete = 0;
            }

            else if (uf == "AM")
            {
                frete = 20.0;
            }

            else if (uf == "SP")
            {
                frete = 5.0;
            }
            else if (uf == "RJ")
            {
                frete = 10.0;
            }

            else if( uf!= "SP" && uf != "RJ" && uf != "AM")
            {
                frete = 15.0;
            }

            total = valor + frete;

            lblValorCompra.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = total.ToString("C");

        }

        private void LimparCampos_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtValor.Text = String.Empty;
            cbxUf.Text = String.Empty;
        }


    }
}
