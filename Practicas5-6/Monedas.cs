using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas5_6
{
    public class Monedas
    {
        public List<decimal> monedas;

        public Monedas()
        {
            monedas = new List<decimal>() { 100, 50, 20, 10, 5, 1, .50M,.20M, 0.01M };
        }

        public void GenerarMonedas( decimal cambio,int contador, ListBox listBox)
        {

            if (cambio == 0 || contador >= monedas.Count)
                return;
            else
            {
                int cantidadDeMonedas = (int)(cambio / monedas[contador]);
                listBox.Items.Add($"{cantidadDeMonedas} moneda(s) de {monedas[contador]}");
                cambio %= monedas[contador];
                if (cambio != 0)
                {
                    contador++;
                    GenerarMonedas(cambio, contador, listBox);
                }

               

            }
           

        }

    }
}

   

