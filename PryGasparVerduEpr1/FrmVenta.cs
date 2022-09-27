using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryGasparVerduEpr1
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            //este procedimiento es para cargar los cbo con los datos que estan guardados anteriormente 
            char separador = Convert.ToChar(",");

            StreamWriter swVentas = new StreamWriter("./Ventas.txt", true);
            swVentas.Close();

            //preguntar si los archivos existen
            if (File.Exists("./Ventas.txt") && File.Exists("./Vendedores.txt"))
            {
                StreamReader srClientes = new StreamReader("./Clientes.txt");
                //StreamReader srVendedores = new StreamReader("./Vendedores.txt");

                while (!srClientes.EndOfStream)
                {
                    string[] vecClientes = srClientes.ReadLine().Split(separador);
                    cboCliente.Items.Add (vecClientes[0]);
                }
                srClientes.Close();

                StreamReader srVendedores = new StreamReader("./Vendedores.txt");
                while (!srVendedores.EndOfStream)
                {
                    string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                    CboVendedor.Items.Add (vecVendedores[0]);
                }
                srVendedores.Close();
            }
            else
            {
                MessageBox.Show("No existen estos archivos");
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            StreamWriter swVenta = new StreamWriter("./Ventas.txt", true);
            swVenta.WriteLine(cboCliente.Text + "," + CboVendedor.Text + "," + dtpFecha.Text + "," + cboTipoFactura.Text + "," + nudNumeroFactura.Value + "," + nudMonto.Value);
            swVenta.Close();

            MessageBox.Show("Datos cargados");
            nudMonto.Value = 0;
            nudNumeroFactura.Value = 0;
            cboCliente.Text = "";
            cboTipoFactura.Text = "";
            CboVendedor.Text = "";
            
        }
    }
}
