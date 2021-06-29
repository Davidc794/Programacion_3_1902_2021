using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3_1902_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //arreglos 
            int[] Arra1 = new int[5];

            Arra1[0] = 10;
            Arra1[1] = 20;
            Arra1[2] = 30;
            Arra1[3] = 40;
            Arra1[4] = 50;
            //----------------------------------------------
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            //---------------------------------------------
            int[] array3 = { 1, 2, 3, 4, 5 };

            string[] diasSemana = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };



            for (int i = 0; i < Arra1.Length; i++)
            {
                DiaslistBox.Items.Add(Arra1[i]);
            }

            foreach (var y in diasSemana)
            {
                SemanalistBox.Items.Add(y);
            }

        }

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 5, 1, 7, 8, 9, 6, 2 };
            //ordenar de menor a mayor
            // Array.Sort(valores);

            //ordenar de mayor a menor 
            //Array.Reverse(valores);


            //----------------------------------------------------------


            //valores = valores.OrderByDescending(x => x).ToArray();


            //=---------------------------------------------------------------



            foreach (var item in valores)
            {
                OrdenarlistBox.Items.Add(item);
            }
            OrdenarlistBox.Sorted = true;
        }

        private void MaxiMinbutton_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 5, 1, 7, 8, 9, 6, 2 };

            Array.Sort(valores);
            int minimo = valores[0];
            // int maximo = valores[7];
            int maximo = valores[valores.Length - 1];

            MessageBox.Show("Valor Maximo :" + maximo + "/ Valor Minimo : " + minimo);



           // int valorMaximo = valores[0];
           // int valorMinimo = valores[0];

            // for (int i = 1; i < valores.Length; i++)
            //{
            //  if (valores[i] > valorMaximo)
            //{
            //   valorMaximo = valores[i];
            //}

            //                if (valores[i] < valorMinimo)
            ///              {
            //               valorMinimo = valores[i];
            //         }
            //       MessageBox.Show("Valor Maximo :" + valorMaximo + "/ Valor Minimo : " + valorMinimo);
     //   }
        }  }

}
