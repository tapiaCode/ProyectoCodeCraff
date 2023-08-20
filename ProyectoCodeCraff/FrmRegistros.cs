using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCodeCraff
{
    public partial class FrmRegistros : Form
    {
        public string CargoEntreVentanas { get; set; }
        public FrmRegistros()
        {
            InitializeComponent();
        }
        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            if (CargoEntreVentanas == "Administrador")
            {
                //MessageBox.Show("Bienvenido Administrador");
            }
            else if (CargoEntreVentanas == "Empleado")
            {
                BtnRegistroEmpleados.Visible = false;
                BtnRegistroProductos.Visible = false;
            }
        }
        private void RegistroDeClientes_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente frmRegistroCliente = new FrmRegistroCliente();
            frmRegistroCliente.CargoEntreVentanas = CargoEntreVentanas;
            this.Hide();
            frmRegistroCliente.ShowDialog();
            this.Close();
        }

        private void RegistroDePedido_Click(object sender, EventArgs e)
        {
            FrmRegistrarPedido frmFrmRegistrarPedido = new FrmRegistrarPedido();
            frmFrmRegistrarPedido.CargoEntreVentanas = CargoEntreVentanas;
            this.Hide();
            frmFrmRegistrarPedido.ShowDialog();
            this.Close();
        }
        private void BtnRegistroProductos_Click_1(object sender, EventArgs e)
        {
            FrmRegistroProducto frmRegistroProducto = new FrmRegistroProducto();
            this.Hide();
            frmRegistroProducto.ShowDialog();
            this.Close();
        }

        private void BtnRegistroEmpleados_Click_1(object sender, EventArgs e)
        {
            FrmRegistroEmpleados frmRegistroEmpleado = new FrmRegistroEmpleados();
            this.Hide();
            frmRegistroEmpleado.ShowDialog();
            this.Close();
        }
        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            this.Hide();
            frmInicioSesion.ShowDialog();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.ShowDialog();
            this.Close();
        }
    }
}
