using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Diccionario
{
    public partial class Diccionario : Form
    {
        //2 Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.
        Hashtable diccionario = new Hashtable();

        public Diccionario()
        {
            InitializeComponent();
        }

        private void Traducir_Click(object sender, EventArgs e)
        {
            diccionario.Add("Relación de afecto, simpatía y confianza que se establece entre personas que no son familia.", "1.Amistad");
            diccionario.Add("Persona Que mantiene una relación de amistad con otra u otras personas. ", "2.Amigo");
            diccionario.Add("Manera de estar colocadas las cosas o las personas en el espacio o de sucederse los hechos en el tiempo, según un determinado criterio o una determinada norma.", "3.Orden");
            
            foreach (string name in diccionario.Keys)
            {
                listBox1.Items.Add(diccionario[name] + "\n" + name);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
