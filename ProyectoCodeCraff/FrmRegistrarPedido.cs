using ProyectoCodeCraft.Datos;
using ProyectoCodeCraft.RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCodeCraff
{
    public partial class FrmRegistrarPedido : Form
    {
        private const string connectionString = "Data Source=DESKTOP-FU136CF;Initial Catalog=DBSITEP;Integrated Security=True";
        private Timer timerBusqueda;
        public string CargoEntreVentanas { get; set; }
        public FrmRegistrarPedido()
        {
            InitializeComponent();
            dataGridViewClientes.CellFormatting += dataGridViewClientes_CellFormatting;
            dataGridViewClientes.CellClick += DataGridViewClientes_CellClick;
            timerBusqueda = new Timer() { Interval = 500 };
            timerBusqueda.Tick += TimerBusqueda_Tick;
            TextBuscarCliente.TextChanged += TextBuscarCliente_TextChanged;
 

        }
        private int cantidadEjemplares = 0;
        public FrmRegistrarPedido(float monto, long idPedido)
        {
            InitializeComponent();
        }
        private void FrmRegistrarPedido_Load(object sender, EventArgs e)
        {
            this.CargarIdPedido();
            this.CargarEmpleado();
            this.CargarCategoria();
            this.CargarSubCategoria();
            this.CargarProducto();
            //this.CargarEjemplar();
            this.CargarClientesDataGridView();
            this.EstablecerTamañosDataGridView();
        }
        private void CargarIdPedido()
        {
            RNPedido ObjetoPedido = new RNPedido();
            txtIdPedido.Text = ObjetoPedido.GenerarID().ToString();
        }
        private void CargarEmpleado()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("Id_Empleado"));
            dta.Columns.Add(new DataColumn("Nombre_Empleado"));
            RNEmpleado ObjRNEmpleado = new RNEmpleado();
            var objEmpleado = ObjRNEmpleado.TrearEmpleado(0);
            foreach (Empleado Fila in objEmpleado)
            {
                DataRow drColumn = dta.NewRow();
                drColumn["Id_Empleado"] = Fila.Id_Empleado.ToString();
                drColumn["Nombre_Empleado"] = Fila.Nombre_Empleado + ' ' + Fila.Apellido_Paterno + ' ' + Fila.Apellido_Materno.ToString();
                dta.Rows.Add(drColumn);
            }
            this.cbEmpleado.DataSource = dta;
            this.cbEmpleado.DisplayMember = "Nombre_Empleado";
            this.cbEmpleado.ValueMember = "Id_Empleado";

        }
        private void CargarCategoria()
        {
            RNCategoria ObjRnCategoria = new RNCategoria();
            cbCategoria.DataSource = ObjRnCategoria.TraerCategoria(0);
            cbCategoria.DisplayMember = "Nombre_Categoria";
            cbCategoria.ValueMember = "Id_Categoria";
        }
        private void cbCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;
            RNSubcategoria ObjRnSubCategoria = new RNSubcategoria();
            List<Sub_Categoria> subcategoriasFiltradas = ObjRnSubCategoria.TraerSubCategoria(0).Where(s => s.IdCategoria == categoriaSeleccionada.Id_Categoria).ToList();
            cbSubCategoria.DataSource = subcategoriasFiltradas;
            cbSubCategoria.DisplayMember = "Nombre_SubCategoria";
            cbSubCategoria.ValueMember = "Id_SubCategoria";
        }
        private void CargarSubCategoria()
        {
            RNSubcategoria ObjRnSubCategoria = new RNSubcategoria();
            cbSubCategoria.DataSource = ObjRnSubCategoria.TraerSubCategoria(0);
            cbSubCategoria.DisplayMember = "Nombre_SubCategoria";
            cbSubCategoria.ValueMember = "Id_SubCategoria";
        }
        private void cbSubCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Sub_Categoria SubcategoriaSeleccionada = (Sub_Categoria)cbSubCategoria.SelectedItem;
            RNProducto ObjRnProducto = new RNProducto();
            List<Producto> ProductosFiltrados = ObjRnProducto.TraerProducto(0).Where(s => s.IdSubCategoria == SubcategoriaSeleccionada.Id_SubCategoria).ToList();
            cbProducto.DataSource = ProductosFiltrados;
            cbProducto.DisplayMember = "Nombre_Producto";
            cbProducto.ValueMember = "Id_Producto";
        }
        private void CargarProducto()
        {
            RNProducto ObjRnProducto = new RNProducto();
            cbProducto.DataSource = ObjRnProducto.TraerProducto(0);
            cbProducto.DisplayMember = "Nombre_Producto";
            cbProducto.ValueMember = "Id_Producto";
        }
        private void cbProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Producto ProductoSelecionado = (Producto)cbProducto.SelectedItem;
            RNEjemplar ObjRnEjemplar = new RNEjemplar();
            List<Ejemplar> EjemplarFiltrados = ObjRnEjemplar.TraerEjemplarDisponible(0).Where(s => s.IdProducto == ProductoSelecionado.Id_Producto).ToList();
            cantidadEjemplares = EjemplarFiltrados.Count();
            cbEjemplar.DataSource = EjemplarFiltrados;
            cbEjemplar.DisplayMember = "Nro_Serie";
            cbEjemplar.ValueMember = "Id_Ejemplar";
        }
        private void CargarEjemplar()
        {
            RNEjemplar ObjRnEjemplar = new RNEjemplar();
            List<Ejemplar> Ejemplares = ObjRnEjemplar.TraerEjemplarDisponible(0);
            cbEjemplar.DataSource = Ejemplares;
            cbEjemplar.DisplayMember = "Nro_Serie";
            cbEjemplar.ValueMember = "Id_Ejemplar";
        }
        private void cbEjemplar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Ejemplar EjemplarSelecionado = (Ejemplar)cbEjemplar.SelectedItem;
            RNPrecio ObjRnPrecio = new RNPrecio();
            List<Precio> PrecioFiltrados = ObjRnPrecio.TraerPrecio(0).Where(s => s.IdEjemplar == EjemplarSelecionado.Id_Ejemplar).ToList();
            cbPrecio.DataSource = PrecioFiltrados;
            cbPrecio.DisplayMember = "Precio_Unitario";
            cbPrecio.ValueMember = "Id_Precio";
        }
        private void BtnContinuar_Click_1(object sender, EventArgs e)
        {
            BorrarErroProvider();
            if (ValidarCampo())
            {
                //Insertar pedido
                RNCtrlPedido ObjRNCtrlPedido = new RNCtrlPedido();
                Pedido ObjetoPedido = new Pedido();
                ObjetoPedido.Id_Pedido = ObjRNCtrlPedido.GenerarId();
                ObjetoPedido.Fecha_Pedido = DateTime.Parse(this.dtFechaPedido.Text);
                ObjetoPedido.Estado_Pedido = this.cbEstadoPedido.Text;
                ObjetoPedido.ModoDePago = this.cbModoDePago.Text;
                ObjetoPedido.IdCliente = long.Parse(this.txtIdCliente.Text);
                ObjetoPedido.IdEmpleado = long.Parse(this.cbEmpleado.SelectedValue.ToString());

                //Insertar detalle pedido
                RNCtrlDetallePedido ObjCtrlDetallePedido = new RNCtrlDetallePedido();
                Detalle_Pedido ObjetoDetallePedido = new Detalle_Pedido();
                ObjetoDetallePedido.IdPedido = ObjRNCtrlPedido.GenerarId();
                ObjetoDetallePedido.IdPrecio = long.Parse(this.cbPrecio.SelectedValue.ToString());
                ObjetoDetallePedido.Cantidad = int.Parse(txtCantidad.Text);
                ObjetoDetallePedido.Precio_compra = float.Parse(cbPrecio.Text);
                ObjetoDetallePedido.Fecha_Garantia = DateTime.Parse(this.dtFechaGarantia.Text);
                AlterarEjemplar();
                
                if (ObjRNCtrlPedido.InsertarPedido(ObjetoPedido)
                    && ObjCtrlDetallePedido.InsertarDetallePedido(ObjetoDetallePedido))
                {
                    MessageBox.Show("Pedido y detalle ingresado con exito");
                    /*if (ObjetoPedido.ModoDePago == "Al contado")
                    {
                        this.BtnReporteFactura.Visible = true;
                        FrmRegistroFactura frmFactura = new FrmRegistroFactura();
                        frmFactura.MontoEntreVentanas = float.Parse(cbPrecio.Text);
                        frmFactura.IdPedidoEntreVentanas = ObjetoPedido.Id_Pedido;
                        this.Hide();
                        //BtnTerminar.Visible = true;
                        //btnContinuar1.Visible = false;
                        frmFactura.ShowDialog();
                        this.Show();
                    }
                    else if (ObjetoPedido.ModoDePago == "Credito")
                    {
                        this.BtnInformePedidoCredito.Visible = true;
                        FrmRegistroCredito frmCredito = new FrmRegistroCredito();
                        frmCredito.MontoEntreVentanas = float.Parse(cbPrecio.Text);
                        frmCredito.IdPedidoEntreVentanas = ObjetoPedido.Id_Pedido;                   
                        this.Hide();
                       // BtnTerminar.Visible = true;
                        //btnContinuar1.Visible = false;
                        frmCredito.ShowDialog();
                        this.Show();
                    }*/
                }
                else
                {
                    MessageBox.Show("Ups, hubo un problema");
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
        //Validar campos
        private bool ValidarCampo()
        {
            bool validar = true;
            int valor;
            if (!int.TryParse(txtCantidad.Text, out valor) || valor <= 0 || valor > cantidadEjemplares)
            {
                validar = false;
                errorCantidad.SetError(txtCantidad, "El cuadro está vacío o la cantidad no existe en la base de datos");
            }
            if (cbEstadoPedido.SelectedIndex == -1)
            {
                validar = false;
                errorEstadoPedido.SetError(cbEstadoPedido, "Selecciona un estado de pedido.");
            }
            if (cbModoDePago.SelectedIndex == -1)
            {
                validar = false;
                errorModoDePago.SetError(cbModoDePago, "Selecciona una forma de pago.");
            }
            if (txtIdCliente.Text == "")
            {
                validar = false;
                errorIdCliente.SetError(txtIdCliente, "El número de cliente no pude estar vacio");
            }
            if (txtNombreCliente.Text == "")
            {
                validar = false;
                errorNombreCliente.SetError(txtNombreCliente, "Ingrese el número de Nit");
            }
            if (cbEjemplar.SelectedIndex == -1)
            {
                validar = false;
                errorEjemplarNecesario.SetError(cbEjemplar, "Seleccione un ejemplar.");
            }
            return validar;
        }
        //BorrarMensajesDeErro
        private void BorrarErroProvider()
        {
            errorCantidad.SetError(txtCantidad, "");
            errorEstadoPedido.SetError(cbEstadoPedido, "");
            errorModoDePago.SetError(cbModoDePago, "");
            errorIdCliente.SetError(txtIdCliente, "");
            errorNombreCliente.SetError(txtNombreCliente, "");
            errorEjemplarNecesario.SetError(cbEjemplar, "");
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        private void CargarClientesDataGridView()
        {
            using (var contexto = new DBSITEPEntities())
            {
                var clientes = contexto.Natural
                    .Select(c => new {
                        c.Cliente.Id_Cliente,
                        NombreCliente = c.Nombre + " " + c.Apellido_Paterno + " " + c.Apellido_Materno,
                        c.Genero,
                        c.Carnet_Identidad,          
                    })
                    .ToList();

                dataGridViewClientes.DataSource = clientes;
            }
        }
        private void BuscarClientes()
        {
            string busqueda = TextBuscarCliente.Text;
            using (var contexto = new DBSITEPEntities())
            {
                var clientes = contexto.Natural
                    .Where(c => c.Nombre.Contains(busqueda) || c.Carnet_Identidad.Contains(busqueda))
                    .Select(c => new ClienteViewModel
                    {
                        Id_Cliente = c.Cliente.Id_Cliente,
                        NombreCliente = c.Nombre + " " + c.Apellido_Paterno + " " + c.Apellido_Materno,
                        Carnet_Identidad = c.Carnet_Identidad,
                        Genero = c.Genero
                    })
                    .ToList();

                dataGridViewClientes.DataSource = clientes;
            }
        }
        private void dataGridViewClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridViewClientes.Columns[e.ColumnIndex].Name == "NombreCliente")
            {
                var cliente = dataGridViewClientes.Rows[e.RowIndex].DataBoundItem as ClienteViewModel;
                if (cliente != null)
                {
                    e.Value = cliente.NombreCliente;
                }
            }
        }
        private void EstablecerTamañosDataGridView()
        {
            dataGridViewClientes.Columns[0].Width = 40;
            dataGridViewClientes.Columns[1].Width = 130;
            dataGridViewClientes.Columns[2].Width = 65;
            dataGridViewClientes.Columns[3].Width = 100;
            dataGridViewClientes.Columns[0].HeaderText = "ID";
            dataGridViewClientes.Columns[1].HeaderText = "Nombre Completo";
            dataGridViewClientes.Columns[2].HeaderText = "Genero";
            dataGridViewClientes.Columns[3].HeaderText = "C.I";
        }
        private void TextBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            timerBusqueda.Start();
        }
        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            timerBusqueda.Stop();
            BuscarClientes();
        }
        private void DataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewClientes.Rows.Count)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];
                txtIdCliente.Text = row.Cells["Id_Cliente"].Value.ToString();
                txtNombreCliente.Text = row.Cells["NombreCliente"].Value.ToString();
            }
        }
        private void AlterarEjemplar()
        {

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string actualizarEjemplarSql = "UPDATE Ejemplar SET Disponible = 0 WHERE Id_Ejemplar = @idEjemplar";

                using (var cmdActualizarEjemplar = new SqlCommand(actualizarEjemplarSql, connection))
                {
                    cmdActualizarEjemplar.Parameters.AddWithValue("@idEjemplar", cbEjemplar.SelectedValue);
                    cmdActualizarEjemplar.ExecuteNonQuery();
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
