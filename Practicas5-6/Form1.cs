using Practica5_6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void rbHanoi_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnHanoi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int numero = Convert.ToInt32(tbHanoi.Text.Trim());

            Hanoi hanoi = new Hanoi(numero, listBox1);
          
            hanoi.TorresDeHanoi(hanoi.numero, 'A', 'B', 'C', hanoi.lisBox);

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Monedas_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(tbPrecio.Text.Trim(), out decimal result) && 
                decimal.TryParse(tbPago.Text.Trim(), out decimal result2))
            {
               

                decimal precio = result;
                decimal pago = result2;
                if(pago<precio)
                {
                    MessageBox.Show("El pago es insuficiente","ADVERTENCIA",MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    listBox2.Items.Clear();
                    Monedas monedas = new Monedas();
                    decimal cambio = pago - precio;

                    monedas.GenerarMonedas(cambio,0, listBox2);

                }


            }
            else
            {
                MessageBox.Show("No se aceptan caraceters", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

        }
    }
}
