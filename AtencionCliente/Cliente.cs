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

namespace AtencionCliente
{
    public partial class Cliente : Form
    {
        //3 Hacer un programa que simule un sistema de atención a clientes, 
        //donde el cliente que llega primero es atendido primero.
        Queue fila = new Queue();

        public Cliente()
        {
            InitializeComponent();
            listadoCliente.Items.Add("\t\t\t\t Listado De Personas");
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string persona = IngresoNombre.Text;
            fila.Enqueue(persona);
            listadoCliente.Items.Add(persona);
            IngresoNombre.Clear();
        }

     

        private void VerTurno_Click(object sender, EventArgs e)
        {
            ImprimoCliente.Text = (" " + fila.Dequeue()) ;
            listadoCliente.Items.Clear();
            foreach (string n in fila)
            {
                listadoCliente.Items.Add(n);
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            ImprimoCliente.Text = (" " + fila.Dequeue());
            listadoCliente.Items.Clear();
            int num = fila.Count;

            foreach (string n in fila)
            { 
                listadoCliente.Items.Add(n);
            }
            if (num == 0)
                MessageBox.Show("No hay mas clientes, por favor ingrese mas");
        }
    }
}
