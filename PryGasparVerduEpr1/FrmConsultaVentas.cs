using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGasparVerduEpr1
{
    public partial class FrmConsultaVentas : Form
    {
        string[,] matConsultaVentas = new string[1000, 6];
        public FrmConsultaVentas()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int F = 0;

            StreamReader srCventas = new StreamReader("./Ventas.txt");
            while (!srCventas.EndOfStream)
            {
                string[] vecCventas = srCventas.ReadLine().Split(separador);
                matConsultaVentas[F, 0] = vecCventas[0];
                matConsultaVentas[F, 1] = vecCventas[1];
                matConsultaVentas[F, 2] = vecCventas[2];
                matConsultaVentas[F, 3] = vecCventas[3];
                matConsultaVentas[F, 4] = vecCventas[4];
                matConsultaVentas[F, 5] = vecCventas[5];

                dgvConsultaVentas.Rows.Add(matConsultaVentas[F, 0], matConsultaVentas[F, 1], matConsultaVentas[F, 2], matConsultaVentas[F, 3], matConsultaVentas[F, 4], matConsultaVentas[F, 5]);
                F++;
            }
            srCventas.Close();
        }
    }
}
