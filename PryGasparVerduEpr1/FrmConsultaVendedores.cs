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
    public partial class FrmConsultaVendedores : Form
    {
        string[,] matConsultaVendedores = new string[1000, 4];
        public FrmConsultaVendedores()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultaVendedores.Rows.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int F = 0;

            StreamReader srCvendedores = new StreamReader("./Vendedores.txt");

            while (!srCvendedores.EndOfStream)
            {
                string[] vecCvendedores = srCvendedores.ReadLine().Split(separador);
                matConsultaVendedores[F, 0] = vecCvendedores[0];
                matConsultaVendedores[F, 1] = vecCvendedores[1];
                matConsultaVendedores[F, 2] = vecCvendedores[2];
                matConsultaVendedores[F, 3] = vecCvendedores[3];
                
                dgvConsultaVendedores.Rows.Add(matConsultaVendedores[F, 0], matConsultaVendedores[F, 1], matConsultaVendedores[F, 2], matConsultaVendedores[F, 3]);

                F++;
            }
            srCvendedores.Close();
        }
    }
}
