using ProyectoCodeCraft.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCodeCraff
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            TxtContraseña.PasswordChar = '*';
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }
        private void InicioSesion()
        {
            string cargo = "";
            string usuario = TxtNombreUsuario.Text;
            string contraseña = TxtContraseña.Text;
            using (var contexto = new DBSITEPEntities())
            {
                var usuarioBD = contexto.inicio_sesion.FirstOrDefault(u => u.usuario == usuario);
                if (usuarioBD != null && usuarioBD.clave_acceso == BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(contraseña))).Replace("-", ""))
                {
                    cargo = usuarioBD.cargo;
                    MessageBox.Show("Inicio de sesión exitoso, cargo: " + cargo);
                    this.Hide();
                    FrmRegistros frmRegistro = new FrmRegistros();
                    frmRegistro.CargoEntreVentanas = cargo;
                    frmRegistro.ShowDialog();
                    this.Close();

                }
                else
                {
                    TxtContraseña.Text = "";
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }
    }
}
