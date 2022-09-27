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
    public partial class FrmVendedores : Form
    {
        public FrmVendedores()
        {
            InitializeComponent();
        }

        private void btnCargarVendedor_Click(object sender, EventArgs e)
        {
            string vNombreVendedor = txtNombreVendedor.Text;
            int vIdentificadorVendedor = Convert.ToInt32(mskNumeroVendedor.Text);
            
            string vActivo = "Activo no";
            string vComision = "Comision no";

            char separador = Convert.ToChar(",");
            bool bandera = false;

            StreamWriter swVendedores = new StreamWriter("./Vendedores.txt", true);
            swVendedores.Close();

            if (chkActivo.Checked == true)
            {
                vActivo = "Activo si";
            }

            if (chkComision.Checked == true)
            {
                vComision = "Comision si";
            }

            //bool bandera = false;
            StreamReader srVendedores = new StreamReader("./Vendedores.txt");
            
            while (!srVendedores.EndOfStream && bandera == false)
            {
                string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                int idVendedoresRepetidos = Convert.ToInt32(vecVendedores[0]);
                //la posicion que se eliga va a depender de la forma que estemos cargando los datos

                if (idVendedoresRepetidos == vIdentificadorVendedor)
                {
                    MessageBox.Show("Intente con otro id, este ya se encuentra cargado");
                    bandera = true;
                }
            }
            srVendedores.Close();
            if (bandera == false)
            {
                if (vIdentificadorVendedor !=0 && vNombreVendedor != "")
                {
                    StreamWriter swVendedor= new StreamWriter("./Vendedores.txt");
                    swVendedor.WriteLine(vIdentificadorVendedor + "," + vNombreVendedor + "," + vActivo + "," + vComision);
                    swVendedor.Close();

                    MessageBox.Show("Datos cargados con exito");

                }
                else
                {
                    MessageBox.Show("Ingrese datos");
                }
            }
            chkActivo.Checked = false;
            chkComision.Checked = false;
            txtNombreVendedor.Text = "";
            mskNumeroVendedor.Mask = "";
            



        }

        private void FrmVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
