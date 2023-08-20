namespace ProyectoCodeCraff
{
    partial class FrmRegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProducto));
            this.cbDesMarca = new System.Windows.Forms.ComboBox();
            this.CodigoEjemplar = new System.Windows.Forms.TextBox();
            this.txDesNroSerie = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txNroSerie = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.FechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.txNombreProducto = new System.Windows.Forms.TextBox();
            this.CodigoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BntCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorNombreProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcionProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNroSerie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcionNroSerie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecioProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNroSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionNroSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDesMarca
            // 
            this.cbDesMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesMarca.FormattingEnabled = true;
            this.cbDesMarca.Location = new System.Drawing.Point(291, 370);
            this.cbDesMarca.Name = "cbDesMarca";
            this.cbDesMarca.Size = new System.Drawing.Size(280, 30);
            this.cbDesMarca.TabIndex = 109;
            // 
            // CodigoEjemplar
            // 
            this.CodigoEjemplar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoEjemplar.Enabled = false;
            this.CodigoEjemplar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoEjemplar.Location = new System.Drawing.Point(865, 225);
            this.CodigoEjemplar.Multiline = true;
            this.CodigoEjemplar.Name = "CodigoEjemplar";
            this.CodigoEjemplar.Size = new System.Drawing.Size(93, 31);
            this.CodigoEjemplar.TabIndex = 108;
            // 
            // txDesNroSerie
            // 
            this.txDesNroSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDesNroSerie.Location = new System.Drawing.Point(865, 334);
            this.txDesNroSerie.Multiline = true;
            this.txDesNroSerie.Name = "txDesNroSerie";
            this.txDesNroSerie.Size = new System.Drawing.Size(279, 86);
            this.txDesNroSerie.TabIndex = 104;
            // 
            // cbMarca
            // 
            this.cbMarca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(291, 326);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(227, 30);
            this.cbMarca.TabIndex = 103;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(865, 174);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(205, 30);
            this.cbSubCategoria.TabIndex = 102;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(865, 122);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 30);
            this.cbCategoria.TabIndex = 101;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // txNroSerie
            // 
            this.txNroSerie.BackColor = System.Drawing.SystemColors.Window;
            this.txNroSerie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNroSerie.Location = new System.Drawing.Point(865, 284);
            this.txNroSerie.Multiline = true;
            this.txNroSerie.Name = "txNroSerie";
            this.txNroSerie.Size = new System.Drawing.Size(205, 30);
            this.txNroSerie.TabIndex = 100;
            // 
            // txPrecio
            // 
            this.txPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecio.Location = new System.Drawing.Point(629, 453);
            this.txPrecio.Multiline = true;
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(131, 30);
            this.txPrecio.TabIndex = 96;
            // 
            // FechaActualizacion
            // 
            this.FechaActualizacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaActualizacion.Location = new System.Drawing.Point(629, 501);
            this.FechaActualizacion.Name = "FechaActualizacion";
            this.FechaActualizacion.Size = new System.Drawing.Size(388, 29);
            this.FechaActualizacion.TabIndex = 95;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProducto.Location = new System.Drawing.Point(291, 178);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(231, 115);
            this.DescripcionProducto.TabIndex = 91;
            // 
            // txNombreProducto
            // 
            this.txNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txNombreProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombreProducto.Location = new System.Drawing.Point(291, 127);
            this.txNombreProducto.Multiline = true;
            this.txNombreProducto.Name = "txNombreProducto";
            this.txNombreProducto.Size = new System.Drawing.Size(201, 30);
            this.txNombreProducto.TabIndex = 87;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoProducto.Enabled = false;
            this.CodigoProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto.Location = new System.Drawing.Point(207, 12);
            this.CodigoProducto.Multiline = true;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(119, 30);
            this.CodigoProducto.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(381, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 28);
            this.label8.TabIndex = 110;
            this.label8.Text = "Registro de un nuevo producto";
            // 
            // BntCancelar
            // 
            this.BntCancelar.BackColor = System.Drawing.Color.White;
            this.BntCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BntCancelar.Image")));
            this.BntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BntCancelar.Location = new System.Drawing.Point(610, 567);
            this.BntCancelar.Name = "BntCancelar";
            this.BntCancelar.Size = new System.Drawing.Size(150, 49);
            this.BntCancelar.TabIndex = 111;
            this.BntCancelar.Text = "       Cancelar";
            this.BntCancelar.UseVisualStyleBackColor = false;
            this.BntCancelar.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(12, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 24);
            this.label13.TabIndex = 112;
            this.label13.Text = "Código producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(51, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "       Nombre producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(-4, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 24);
            this.label2.TabIndex = 114;
            this.label2.Text = "       Descripcion producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(155, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 115;
            this.label6.Text = "       Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(25, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 24);
            this.label7.TabIndex = 116;
            this.label7.Text = "       Descripcion marca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(486, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 117;
            this.label12.Text = "       Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(320, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 24);
            this.label3.TabIndex = 118;
            this.label3.Text = "       Fecha de actualización:";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.White;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(409, 567);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(150, 49);
            this.btnGuardarProducto.TabIndex = 119;
            this.btnGuardarProducto.Text = "       Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(687, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 120;
            this.label5.Text = "       Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(651, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 121;
            this.label4.Text = "       Subcategoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(622, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 24);
            this.label9.TabIndex = 122;
            this.label9.Text = "       Codigo ejemplar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(620, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(219, 24);
            this.label14.TabIndex = 123;
            this.label14.Text = "       Número de serie:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(590, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 48);
            this.label10.TabIndex = 124;
            this.label10.Text = "       Descripcion número\r\n       de serie:";
            // 
            // errorNombreProducto
            // 
            this.errorNombreProducto.ContainerControl = this;
            this.errorNombreProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNombreProducto.Icon")));
            // 
            // errorDescripcionProducto
            // 
            this.errorDescripcionProducto.ContainerControl = this;
            this.errorDescripcionProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDescripcionProducto.Icon")));
            // 
            // errorNroSerie
            // 
            this.errorNroSerie.ContainerControl = this;
            this.errorNroSerie.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNroSerie.Icon")));
            // 
            // errorDescripcionNroSerie
            // 
            this.errorDescripcionNroSerie.ContainerControl = this;
            this.errorDescripcionNroSerie.Icon = ((System.Drawing.Icon)(resources.GetObject("errorDescripcionNroSerie.Icon")));
            // 
            // errorPrecioProducto
            // 
            this.errorPrecioProducto.ContainerControl = this;
            this.errorPrecioProducto.Icon = ((System.Drawing.Icon)(resources.GetObject("errorPrecioProducto.Icon")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1081, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 109);
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(857, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 149;
            // 
            // FrmRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1195, 676);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BntCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDesMarca);
            this.Controls.Add(this.CodigoEjemplar);
            this.Controls.Add(this.txDesNroSerie);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txNroSerie);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.FechaActualizacion);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.txNombreProducto);
            this.Controls.Add(this.CodigoProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de producto";
            this.Load += new System.EventHandler(this.FrmRegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNroSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcionNroSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDesMarca;
        private System.Windows.Forms.TextBox CodigoEjemplar;
        private System.Windows.Forms.TextBox txDesNroSerie;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txNroSerie;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.DateTimePicker FechaActualizacion;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.TextBox txNombreProducto;
        private System.Windows.Forms.TextBox CodigoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BntCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorNombreProducto;
        private System.Windows.Forms.ErrorProvider errorDescripcionProducto;
        private System.Windows.Forms.ErrorProvider errorNroSerie;
        private System.Windows.Forms.ErrorProvider errorDescripcionNroSerie;
        private System.Windows.Forms.ErrorProvider errorPrecioProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}