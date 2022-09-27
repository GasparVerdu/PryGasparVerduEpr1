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
    public partial class FrmConsultaClientes : Form
    {
        string[,] MatrizConsultaClientes = new string[1000,2];
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int F= 0;

            StreamReader srCcliente = new StreamReader("./Clientes.txt");
            while (!srCcliente.EndOfStream)
            {
                string[] vecConsulta = srCcliente.ReadLine().Split(separador);
                MatrizConsultaClientes[F,0] = vecConsulta[0];
                MatrizConsultaClientes[F,1] = vecConsulta[1];
                dgvConsultaClientes.Rows.Add(MatrizConsultaClientes[F, 0], MatrizConsultaClientes[F, 1]);
                F++;
            }
            srCcliente.Close();
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsultaClientes.Rows.Clear();
        }
    }
}
