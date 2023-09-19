using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5_6
{
    public class Hanoi
    {
        public int numero { get; set; }
        public ListBox lisBox { get; set; }

        public Hanoi(int numero, ListBox listBox)
        {
            this.numero = numero;
            this.lisBox = listBox;
        }

        public void TorresDeHanoi(int numero, char torreOrigen, char torreAuxiliar, char torreDestino, ListBox listBox)
        {

  
            if (numero == 1)
            {
                listBox.Items.Add($"Mover disco 1 de torre {torreOrigen} a torre {torreDestino}");
                return;
            }
            TorresDeHanoi(numero - 1, torreOrigen, torreDestino, torreAuxiliar,listBox);
            listBox.Items.Add($"Mover disco {numero} de torre {torreOrigen} a torre {torreDestino}");
            TorresDeHanoi(numero - 1, torreAuxiliar, torreOrigen, torreDestino, listBox);





        }
    }
}