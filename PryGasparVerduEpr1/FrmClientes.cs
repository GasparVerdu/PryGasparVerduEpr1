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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string vNombreCliente = txtNombre.Text;
            decimal vIdentificador = nudIdentificador.Value;

            char separador = Convert.ToChar(",");
            bool bandera = false;

            StreamWriter swClientes = new StreamWriter("./Clientes.txt", true);
            swClientes.Close();

            StreamReader srClientes = new StreamReader("./Clientes.txt");

            //mientras para fijarse si el id ingresado ya esta registrado
            while (!srClientes.EndOfStream && bandera == false)
            {
                string[] vecClientes = srClientes.ReadLine().Split(separador);

                int idCliente = Convert.ToInt32(vecClientes[0]);

                if (idCliente == vIdentificador)
                {
                    MessageBox.Show("Intente con otro Id");
                    //bandera en true para que no entre de nuevo al while 
                    bandera = true;
                }
            }
            srClientes.Close();
            //preguntar si los campos estan con algun dato, si lo estan entramos para escribir los datos 
            if (vIdentificador != 0 && vNombreCliente != "")
            {
                if (bandera == false)
                {
                    //escribir en el archivo los datos 

                    StreamWriter swclienteEscribir = new StreamWriter("./Clientes.txt", true);
                    //using (StreamWriter swclienteescribir = new StreamWriter("./Clientes.txt", true)) ;
                    {
                       
                        swclienteEscribir.WriteLine(vIdentificador + "," + vNombreCliente);
                        //acordarse de cerrar el archivo
                        swclienteEscribir.Close();

                        MessageBox.Show("Cargado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese datos");
            }
            txtNombre.Text = "";
            nudIdentificador.Value = 0;
            txtNombre.Focus();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
