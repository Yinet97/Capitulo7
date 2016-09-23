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

namespace AgendaTelefonica
{
    //5 Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.

    public partial class Agenda : Form
    {
        ArrayList agenda = new ArrayList();

        public Agenda()
        {
            InitializeComponent();
            AgendaTel.Items.Add("NOMBRE \t" + "\t TELEFONO");
        }
        
        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = IngresoNombre.Text;
            string numero = IngresoNumero.Text;

            agenda.Add(nombre);
            agenda.Add(numero);
            AgendaTel.Items.Add(nombre + "\t \t " + numero);
            IngresoNombre.Clear();
            IngresoNumero.Clear();
        }

        private void AgendaTel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
