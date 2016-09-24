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

namespace GastosDelMes
{
    public partial class Gastos : Form
    {
        //4 Hacer un programa que muestre la suma de los gastos 
        //ocurridos durante el mes, y que los muestre en orden cronológico descendente

        Stack pila = new Stack();

        public Gastos()
        {
            InitializeComponent();
        }

        private void EntrarGasto_Click(object sender, EventArgs e)
        {
            int total = 0;
            int gasto = Convert.ToInt32(ingresoGasto.Text);
            pila.Push(gasto);
            ingresoGasto.Clear();

            foreach(int n in pila)
            {
                total += n;
                
            }
            ImprimoTotal.Text = Convert.ToString("$"+total);

        }

        private void VerGasto_Click(object sender, EventArgs e)
        {
            listaGasto.Items.Clear();

            int count = pila.Count +1;
            foreach (int n in pila)
            {
                count--;
                listaGasto.Items.Add("Dia "+ count +" ->> " + n);
            }
            
        }
    }
}
