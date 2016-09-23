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

namespace ejerciciosCapitulo_7
{
    public partial class Calificaciones : Form
    {
        //1 Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.

        ArrayList lista = new ArrayList();

        public Calificaciones()
        {
            InitializeComponent();
        }

        private void listaCal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(ingresoCal.Text);
            int maxx = 0;
            int min = 0;
            listaCal.Items.Add(nota);
            lista.Add(nota);

            foreach (int x in lista)
            {
                if (x > maxx)
                    maxx = x;
                else
                    min = x;
            }
            ImprimoMayor.Text = Convert.ToString(maxx);
            ImprimoMenor.Text = Convert.ToString(min);
            Calculo(lista);
        }

        public void Calculo(ArrayList arreglo)
        {
            float promedio = 0f;
            int cont = 0;

            foreach (int n in arreglo)
            {
                promedio += n;
                cont++;
            }
            promedio = promedio / cont;
            ImprimoPromedio.Text = Convert.ToString(promedio);
        }
    }
}
