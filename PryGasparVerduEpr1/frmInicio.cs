using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGasparVerduEpr1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedores frmvendedores = new FrmVendedores();
            frmvendedores.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVendedores frmCvendedores = new FrmConsultaVendedores();
            frmCvendedores.ShowDialog();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmCclientes = new FrmConsultaClientes();
            frmCclientes.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaVentas frmCventas = new FrmConsultaVentas();
            frmCventas.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
