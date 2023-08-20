using ProyectoCodeCraft.Datos;
using ProyectoCodeCraft.RN;
using RNUtilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoCodeCraff
{
    public partial class FrmRegistroEmpleados : Form
    {
        public string CargoEntreVentanas { get; set; }
        public FrmRegistroEmpleados()
        {
            InitializeComponent();
        }

        private void FrmRegistroEmpleados_Load(object sender, EventArgs e)
        {
            this.CargarComboCargo();
        }
        private void CargarComboCargo()
        {
            RNCargo ObjRnCargo = new RNCargo();
            cbCargo.DataSource = ObjRnCargo.TraerCargo(0);
            cbCargo.DisplayMember = "Nombre_Cargo";
            cbCargo.ValueMember = "Id_Cargo";
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            BorrarErroProvider();
            if (ValidarCampo())
            {
                RNCtrlEmpleado ObjRNCtrlEmpleado = new RNCtrlEmpleado();
                Empleado ObjEmpleado = new Empleado();
                ObjEmpleado.Id_Empleado = ObjRNCtrlEmpleado.GenerarId();
                ObjEmpleado.Nombre_Empleado = this.txtNombreEmpleado.Text;
                ObjEmpleado.Apellido_Paterno = this.txtApellidoPaterno.Text;
                ObjEmpleado.Apellido_Materno = this.txtApellidoMaterno.Text;
                ObjEmpleado.Carnet_Identidad = this.txtCI.Text;
                ObjEmpleado.IdCargo = long.Parse(this.cbCargo.SelectedValue.ToString());
                ObjEmpleado.Fecha_Nacimiento = DateTime.Parse(this.dpFechaNacimiento.Value.ToShortDateString());

                RNUtilitarios.Utilitarios.id = ObjEmpleado.Id_Empleado;
                 LimpiarCuadrosTexto();
                if (ObjRNCtrlEmpleado.InsertarEmpleado(ObjEmpleado))
                {
                    MessageBox.Show("Empleado Registrado con exito");
                    RNUtilitarios.Utilitarios.id = ObjEmpleado.Id_Empleado;

                }
                else
                {
                    MessageBox.Show("No se pudo registrar al Empleado");
                }
             }
           
        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            FrmRegistros frmRegistro = new FrmRegistros();
            frmRegistro.CargoEntreVentanas = CargoEntreVentanas;
            this.Hide();
            frmRegistro.ShowDialog();
            this.Close();
        }
        private void LimpiarCuadrosTexto()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty; // Establece el texto del cuadro a una cadena vacía
                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false; // Establece la propiedad Checked en false para el control CheckBox
                }
            }
        }
        //Validar campos
        private bool ValidarCampo()
        {
            bool validar = true;
            if (txtNombreEmpleado.Text == "")
            {
                validar = false;
                errorNombreEmpleado.SetError(txtNombreEmpleado, "Ingrese el nombre del empleado");
            }
            if (txtApellidoPaterno.Text == "")
            {
                validar = false;
                errorApellidoPaterno.SetError(txtApellidoPaterno, "Ingrese el apellido paterno del empleado");
            }
            if (txtApellidoMaterno.Text == "")
            {
                validar = false;
                errorApellidoMaterno.SetError(txtApellidoMaterno, "Ingrese el apellido materno v");
            }
            if (txtCI.Text == "")
            {
                validar = false;
                errorCarnetIdenditad.SetError(txtCI, "Ingrese su carnet de identidad");
            }
            return validar;
        }
        //BorrarMensajesDeErro
        private void BorrarErroProvider()
        {
            errorNombreEmpleado.SetError(txtNombreEmpleado, "");
            errorApellidoPaterno.SetError(txtApellidoPaterno, "");
            errorApellidoMaterno.SetError(txtApellidoMaterno, "");
            errorCarnetIdenditad.SetError(txtCI, "");
   
        }

        private void BtnInformeEmpleado_Click(object sender, EventArgs e)
        {
            RNUtilitarios.Utilitarios.TipodeReporte = 1;
            Reportes.FrmReportes frmReporteEmpleado = new Reportes.FrmReportes();
            frmReporteEmpleado.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            RNEmpleado objRNRubro = new RNEmpleado();
            if (this.txtBuscar.Text == "")
            {
                this.dataGridView1.DataSource = (objRNRubro.TrearEmpleado(0));
                Utilitarios.id = 0;

                //Esconde columnas innecesarias
                dataGridView1.Columns["Cargo"].Visible = false;
            }
            else
            {
                if (objRNRubro.TraerEmpleadoPorNombre(this.txtBuscar.Text).Count > 0)
                {
                    this.dataGridView1.DataSource = (objRNRubro.TraerEmpleadoPorNombre(this.txtBuscar.Text));

                }

                //Esconde columnas innecesarias
                dataGridView1.Columns["Cargo"].Visible = false;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Int64 id = Convert.ToInt64(selectedRow.Cells["Id_Empleado"].Value);

                Utilitarios.id = id;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Int64 id = Convert.ToInt64(selectedRow.Cells["Id_Empleado"].Value);

                RNCtrlEmpleado ObjCtrlEmpleado = new RNCtrlEmpleado();
                VistaEmpleadoCargo empleado = ObjCtrlEmpleado.TraerEmpleadoCargo(id).FirstOrDefault();

                if (empleado != null)
                {
                    FrmEditarEmpleado editarClienteForm = new FrmEditarEmpleado(empleado);
                    DialogResult result = editarClienteForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Update the rubro in the database
                        bool editSuccessful = ObjCtrlEmpleado.EditarEmpleado(empleado);

                        if (editSuccessful)
                        {
                            // Refresh the DataGridView to reflect the changes
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ObjCtrlEmpleado.TraerEmpleadoCargo(0);

                            MessageBox.Show("Empleado editado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar editar el Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una columna por favor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Int64 id = Convert.ToInt64(selectedRow.Cells["Id_Empleado"].Value);

                RNCtrlEmpleado ObjCtrlEmpleado = new RNCtrlEmpleado();
                VistaEmpleadoCargo empleado = ObjCtrlEmpleado.TraerEmpleadoCargo(id).FirstOrDefault();

                if (empleado != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar este Empleado?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool deletionSuccessful = ObjCtrlEmpleado.Eliminar(empleado);

                        if (deletionSuccessful)
                        {
                            dataGridView1.DataSource = null;
                            MessageBox.Show("Empleado eliminado excitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al intentar Eliminar el Empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una columna por favor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
