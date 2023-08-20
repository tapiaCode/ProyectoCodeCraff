namespace ProyectoCodeCraff
{
    partial class FrmRegistrarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarPedido));
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.cbPrecio = new System.Windows.Forms.ComboBox();
            this.dtFechaGarantia = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbModoDePago = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbEjemplar = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbEstadoPedido = new System.Windows.Forms.ComboBox();
            this.dtFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.errorCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstadoPedido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorModoDePago = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBuscarCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.errorIdCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombreCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEjemplarNecesario = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModoDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEjemplarNecesario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(537, 165);
            this.txtIdPedido.Multiline = true;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(75, 24);
            this.txtIdPedido.TabIndex = 61;
            // 
            // cbPrecio
            // 
            this.cbPrecio.Enabled = false;
            this.cbPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrecio.FormattingEnabled = true;
            this.cbPrecio.Location = new System.Drawing.Point(537, 469);
            this.cbPrecio.Name = "cbPrecio";
            this.cbPrecio.Size = new System.Drawing.Size(130, 30);
            this.cbPrecio.TabIndex = 60;
            // 
            // dtFechaGarantia
            // 
            this.dtFechaGarantia.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtFechaGarantia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaGarantia.Location = new System.Drawing.Point(537, 570);
            this.dtFechaGarantia.Name = "dtFechaGarantia";
            this.dtFechaGarantia.Size = new System.Drawing.Size(382, 29);
            this.dtFechaGarantia.TabIndex = 58;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(537, 521);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(94, 29);
            this.txtCantidad.TabIndex = 56;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cbModoDePago
            // 
            this.cbModoDePago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModoDePago.FormattingEnabled = true;
            this.cbModoDePago.Items.AddRange(new object[] {
            "Credito",
            "Al contado"});
            this.cbModoDePago.Location = new System.Drawing.Point(1081, 336);
            this.cbModoDePago.Name = "cbModoDePago";
            this.cbModoDePago.Size = new System.Drawing.Size(218, 30);
            this.cbModoDePago.TabIndex = 54;
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(537, 318);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(299, 30);
            this.cbSubCategoria.TabIndex = 52;
            this.cbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cbSubCategoria_SelectedIndexChanged_1);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(537, 276);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(299, 30);
            this.cbCategoria.TabIndex = 50;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged_1);
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(537, 367);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(299, 30);
            this.cbProducto.TabIndex = 48;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged_1);
            // 
            // cbEjemplar
            // 
            this.cbEjemplar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEjemplar.FormattingEnabled = true;
            this.cbEjemplar.Location = new System.Drawing.Point(537, 415);
            this.cbEjemplar.Name = "cbEjemplar";
            this.cbEjemplar.Size = new System.Drawing.Size(299, 30);
            this.cbEjemplar.TabIndex = 45;
            this.cbEjemplar.SelectedIndexChanged += new System.EventHandler(this.cbEjemplar_SelectedIndexChanged_1);
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(1081, 387);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(245, 30);
            this.cbEmpleado.TabIndex = 44;
            // 
            // cbEstadoPedido
            // 
            this.cbEstadoPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoPedido.FormattingEnabled = true;
            this.cbEstadoPedido.Items.AddRange(new object[] {
            "Entregado",
            "Por entregar"});
            this.cbEstadoPedido.Location = new System.Drawing.Point(1081, 287);
            this.cbEstadoPedido.Name = "cbEstadoPedido";
            this.cbEstadoPedido.Size = new System.Drawing.Size(218, 30);
            this.cbEstadoPedido.TabIndex = 40;
            // 
            // dtFechaPedido
            // 
            this.dtFechaPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaPedido.Location = new System.Drawing.Point(537, 224);
            this.dtFechaPedido.Name = "dtFechaPedido";
            this.dtFechaPedido.Size = new System.Drawing.Size(382, 29);
            this.dtFechaPedido.TabIndex = 39;
            // 
            // errorCantidad
            // 
            this.errorCantidad.ContainerControl = this;
            this.errorCantidad.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCantidad.Icon")));
            // 
            // errorEstadoPedido
            // 
            this.errorEstadoPedido.ContainerControl = this;
            this.errorEstadoPedido.Icon = ((System.Drawing.Icon)(resources.GetObject("errorEstadoPedido.Icon")));
            // 
            // errorModoDePago
            // 
            this.errorModoDePago.ContainerControl = this;
            this.errorModoDePago.Icon = ((System.Drawing.Icon)(resources.GetObject("errorModoDePago.Icon")));
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(311, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 24);
            this.label14.TabIndex = 63;
            this.label14.Text = "       Código pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(293, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "       Fecha de pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(360, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 121;
            this.label4.Text = "       Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(324, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 24);
            this.label9.TabIndex = 122;
            this.label9.Text = "       Subcategoria:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(280, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 24);
            this.label10.TabIndex = 123;
            this.label10.Text = "       Nombre producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(369, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 124;
            this.label8.Text = "       Ejemplar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(394, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 125;
            this.label6.Text = "       Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(369, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 126;
            this.label7.Text = "       Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(284, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 24);
            this.label11.TabIndex = 127;
            this.label11.Text = "       Fecha de garantía:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(869, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 24);
            this.label12.TabIndex = 128;
            this.label12.Text = "       Estado pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(869, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 129;
            this.label2.Text = "       Modo de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(909, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 130;
            this.label3.Text = "       Empleado:";
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.White;
            this.BntCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancelar.ForeColor = System.Drawing.Color.Red;
            this.BntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BntCancelar.Image")));
            this.BntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntCancelar.Location = new System.Drawing.Point(789, 640);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(150, 49);
            this.BntCancelar.TabIndex = 132;
            this.BntCancelar.Text = "       Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            this.BntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.White;
            this.BtnContinuar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("BtnContinuar.Image")));
            this.BtnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContinuar.Location = new System.Drawing.Point(537, 640);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(153, 49);
            this.BtnContinuar.TabIndex = 131;
            this.BtnContinuar.Text = "       Guardar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(744, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 28);
            this.label5.TabIndex = 133;
            this.label5.Text = "Registro de pedido";
            // 
            // TextBuscarCliente
            // 
            this.TextBuscarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBuscarCliente.Location = new System.Drawing.Point(36, 51);
            this.TextBuscarCliente.Name = "TextBuscarCliente";
            this.TextBuscarCliente.Size = new System.Drawing.Size(237, 29);
            this.TextBuscarCliente.TabIndex = 134;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Green;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(36, 95);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(191, 33);
            this.BtnBuscar.TabIndex = 136;
            this.BtnBuscar.Text = "       Buscar cliente";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(36, 145);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.Size = new System.Drawing.Size(237, 548);
            this.dataGridViewClientes.TabIndex = 139;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(537, 94);
            this.txtIdCliente.Multiline = true;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(75, 24);
            this.txtIdCliente.TabIndex = 140;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(892, 95);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(225, 29);
            this.txtNombreCliente.TabIndex = 141;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(313, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 24);
            this.label13.TabIndex = 142;
            this.label13.Text = "       Código cliente:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(679, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 24);
            this.label15.TabIndex = 143;
            this.label15.Text = "       Nombre cliente:";
            // 
            // errorIdCliente
            // 
            this.errorIdCliente.ContainerControl = this;
            this.errorIdCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("errorIdCliente.Icon")));
            // 
            // errorNombreCliente
            // 
            this.errorNombreCliente.ContainerControl = this;
            this.errorNombreCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNombreCliente.Icon")));
            // 
            // errorEjemplarNecesario
            // 
            this.errorEjemplarNecesario.ContainerControl = this;
            this.errorEjemplarNecesario.Icon = ((System.Drawing.Icon)(resources.GetObject("errorEjemplarNecesario.Icon")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1432, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 95);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBuscarCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.cbPrecio);
            this.Controls.Add(this.dtFechaGarantia);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbModoDePago);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbEjemplar);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.cbEstadoPedido);
            this.Controls.Add(this.dtFechaPedido);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de pedidos";
            this.Load += new System.EventHandler(this.FrmRegistrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstadoPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModoDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEjemplarNecesario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.ComboBox cbPrecio;
        private System.Windows.Forms.DateTimePicker dtFechaGarantia;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbModoDePago;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbEjemplar;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbEstadoPedido;
        private System.Windows.Forms.DateTimePicker dtFechaPedido;
        private System.Windows.Forms.ErrorProvider errorCantidad;
        private System.Windows.Forms.ErrorProvider errorEstadoPedido;
        private System.Windows.Forms.ErrorProvider errorModoDePago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBuscarCliente;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.ErrorProvider errorIdCliente;
        private System.Windows.Forms.ErrorProvider errorNombreCliente;
        private System.Windows.Forms.ErrorProvider errorEjemplarNecesario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}