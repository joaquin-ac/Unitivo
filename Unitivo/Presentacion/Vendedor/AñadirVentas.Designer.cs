using Unitivo.Properties;

namespace Unitivo.Formularios.Vendedor
{
    partial class AñadirVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Label1 = new Label();
            TBVendedor = new TextBox();
            LVendedor = new Label();
            DateTimePicker1 = new DateTimePicker();
            LFecha = new Label();
            LNumeroFactura = new Label();
            TBNroFactura = new TextBox();
            GroupBoxClientes = new GroupBox();
            Label5 = new Label();
            TBTelCliVenta = new TextBox();
            Label4 = new Label();
            TBApellidoCliVenta = new TextBox();
            Label3 = new Label();
            TBNombreCliVenta = new TextBox();
            Label2 = new Label();
            BBuscarCliente = new Button();
            TBDniCliVenta = new TextBox();
            GroupBoxArticulos = new GroupBox();
            BAñadir = new Button();
            Label10 = new Label();
            TBCantidad = new TextBox();
            Label6 = new Label();
            TBTalle = new TextBox();
            Label7 = new Label();
            TBStock = new TextBox();
            Label8 = new Label();
            TBPrecio = new TextBox();
            Label9 = new Label();
            BBuscarProducto = new Button();
            TBProductoVenta = new TextBox();
            dgvListaVentas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            LTotalVenta = new Label();
            TBApellidoCliente = new TextBox();
            BConfirmar = new Button();
            BModificarProducto = new Button();
            BEliminarProducto = new Button();
            GroupBoxClientes.SuspendLayout();
            GroupBoxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.DarkOliveGreen;
            Label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.SeaShell;
            Label1.Location = new Point(364, 14);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(281, 46);
            Label1.TabIndex = 2;
            Label1.Text = "Nueva Venta";
            // 
            // TBVendedor
            // 
            TBVendedor.Enabled = false;
            TBVendedor.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TBVendedor.Location = new Point(800, 111);
            TBVendedor.Margin = new Padding(7, 8, 7, 8);
            TBVendedor.Name = "TBVendedor";
            TBVendedor.Size = new Size(173, 26);
            TBVendedor.TabIndex = 57;
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.BackColor = Color.SaddleBrown;
            LVendedor.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LVendedor.ForeColor = Color.White;
            LVendedor.Location = new Point(681, 114);
            LVendedor.Margin = new Padding(7, 0, 7, 0);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(100, 22);
            LVendedor.TabIndex = 60;
            LVendedor.Text = "Vendedor:";
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Enabled = false;
            DateTimePicker1.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(483, 109);
            DateTimePicker1.Margin = new Padding(5, 6, 5, 6);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(171, 26);
            DateTimePicker1.TabIndex = 59;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.SaddleBrown;
            LFecha.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LFecha.ForeColor = Color.White;
            LFecha.Location = new Point(397, 114);
            LFecha.Margin = new Padding(7, 0, 7, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(68, 22);
            LFecha.TabIndex = 58;
            LFecha.Text = "Fecha:";
            // 
            // LNumeroFactura
            // 
            LNumeroFactura.AutoSize = true;
            LNumeroFactura.BackColor = Color.SaddleBrown;
            LNumeroFactura.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNumeroFactura.ForeColor = Color.White;
            LNumeroFactura.Location = new Point(80, 112);
            LNumeroFactura.Margin = new Padding(7, 0, 7, 0);
            LNumeroFactura.Name = "LNumeroFactura";
            LNumeroFactura.Size = new Size(111, 22);
            LNumeroFactura.TabIndex = 55;
            LNumeroFactura.Text = "N° Factura:";
            // 
            // TBNroFactura
            // 
            TBNroFactura.CausesValidation = false;
            TBNroFactura.Enabled = false;
            TBNroFactura.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TBNroFactura.Location = new Point(208, 109);
            TBNroFactura.Margin = new Padding(7, 8, 7, 8);
            TBNroFactura.Name = "TBNroFactura";
            TBNroFactura.Size = new Size(163, 26);
            TBNroFactura.TabIndex = 56;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.Cornsilk;
            GroupBoxClientes.Controls.Add(Label5);
            GroupBoxClientes.Controls.Add(TBTelCliVenta);
            GroupBoxClientes.Controls.Add(Label4);
            GroupBoxClientes.Controls.Add(TBApellidoCliVenta);
            GroupBoxClientes.Controls.Add(Label3);
            GroupBoxClientes.Controls.Add(TBNombreCliVenta);
            GroupBoxClientes.Controls.Add(Label2);
            GroupBoxClientes.Controls.Add(BBuscarCliente);
            GroupBoxClientes.Controls.Add(TBDniCliVenta);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.SaddleBrown;
            GroupBoxClientes.Location = new Point(27, 186);
            GroupBoxClientes.Margin = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Size = new Size(1021, 163);
            GroupBoxClientes.TabIndex = 61;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(776, 52);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(109, 23);
            Label5.TabIndex = 9;
            Label5.Text = "Telefono :";
            // 
            // TBTelCliVenta
            // 
            TBTelCliVenta.Enabled = false;
            TBTelCliVenta.Location = new Point(781, 88);
            TBTelCliVenta.Margin = new Padding(4, 5, 4, 5);
            TBTelCliVenta.Name = "TBTelCliVenta";
            TBTelCliVenta.Size = new Size(156, 38);
            TBTelCliVenta.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(583, 52);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(108, 23);
            Label4.TabIndex = 7;
            Label4.Text = "Apellido :";
            // 
            // TBApellidoCliVenta
            // 
            TBApellidoCliVenta.Enabled = false;
            TBApellidoCliVenta.Location = new Point(588, 88);
            TBApellidoCliVenta.Margin = new Padding(4, 5, 4, 5);
            TBApellidoCliVenta.Name = "TBApellidoCliVenta";
            TBApellidoCliVenta.Size = new Size(156, 38);
            TBApellidoCliVenta.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(389, 52);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(104, 23);
            Label3.TabIndex = 5;
            Label3.Text = "Nombre :";
            // 
            // TBNombreCliVenta
            // 
            TBNombreCliVenta.Enabled = false;
            TBNombreCliVenta.Location = new Point(395, 88);
            TBNombreCliVenta.Margin = new Padding(4, 5, 4, 5);
            TBNombreCliVenta.Name = "TBNombreCliVenta";
            TBNombreCliVenta.Size = new Size(156, 38);
            TBNombreCliVenta.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(89, 52);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(62, 23);
            Label2.TabIndex = 3;
            Label2.Text = "DNI :";
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.BackColor = Color.DarkOliveGreen;
            BBuscarCliente.ForeColor = Color.White;
            BBuscarCliente.Image = Resources.icons8_búsqueda_26;
            BBuscarCliente.Location = new Point(291, 77);
            BBuscarCliente.Margin = new Padding(4, 5, 4, 5);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(60, 62);
            BBuscarCliente.TabIndex = 2;
            BBuscarCliente.UseVisualStyleBackColor = false;
            BBuscarCliente.Click += BBuscarCliente_Click;
            // 
            // TBDniCliVenta
            // 
            TBDniCliVenta.Location = new Point(95, 88);
            TBDniCliVenta.Margin = new Padding(4, 5, 4, 5);
            TBDniCliVenta.Name = "TBDniCliVenta";
            TBDniCliVenta.Size = new Size(156, 38);
            TBDniCliVenta.TabIndex = 1;
            TBDniCliVenta.KeyPress += Num_KeyPress;
            // 
            // GroupBoxArticulos
            // 
            GroupBoxArticulos.BackColor = Color.Cornsilk;
            GroupBoxArticulos.Controls.Add(BAñadir);
            GroupBoxArticulos.Controls.Add(Label10);
            GroupBoxArticulos.Controls.Add(TBCantidad);
            GroupBoxArticulos.Controls.Add(Label6);
            GroupBoxArticulos.Controls.Add(TBTalle);
            GroupBoxArticulos.Controls.Add(Label7);
            GroupBoxArticulos.Controls.Add(TBStock);
            GroupBoxArticulos.Controls.Add(Label8);
            GroupBoxArticulos.Controls.Add(TBPrecio);
            GroupBoxArticulos.Controls.Add(Label9);
            GroupBoxArticulos.Controls.Add(BBuscarProducto);
            GroupBoxArticulos.Controls.Add(TBProductoVenta);
            GroupBoxArticulos.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxArticulos.ForeColor = Color.SaddleBrown;
            GroupBoxArticulos.Location = new Point(27, 377);
            GroupBoxArticulos.Margin = new Padding(4, 5, 4, 5);
            GroupBoxArticulos.Name = "GroupBoxArticulos";
            GroupBoxArticulos.Padding = new Padding(4, 5, 4, 5);
            GroupBoxArticulos.Size = new Size(1021, 163);
            GroupBoxArticulos.TabIndex = 62;
            GroupBoxArticulos.TabStop = false;
            GroupBoxArticulos.Text = "Articulos";
            // 
            // BAñadir
            // 
            BAñadir.BackColor = Color.DarkOliveGreen;
            BAñadir.ForeColor = Color.White;
            BAñadir.Image = Resources.add_32;
            BAñadir.Location = new Point(877, 70);
            BAñadir.Margin = new Padding(4, 5, 4, 5);
            BAñadir.Name = "BAñadir";
            BAñadir.Size = new Size(60, 62);
            BAñadir.TabIndex = 12;
            BAñadir.UseVisualStyleBackColor = false;
            BAñadir.Click += BAñadir_Click;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label10.ForeColor = Color.SaddleBrown;
            Label10.Location = new Point(727, 54);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(112, 23);
            Label10.TabIndex = 11;
            Label10.Text = "Cantidad :";
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(727, 89);
            TBCantidad.Margin = new Padding(4, 5, 4, 5);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(106, 38);
            TBCantidad.TabIndex = 10;
            TBCantidad.KeyPress += Num_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(588, 54);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(71, 23);
            Label6.TabIndex = 9;
            Label6.Text = "Talle :";
            // 
            // TBTalle
            // 
            TBTalle.Enabled = false;
            TBTalle.Location = new Point(588, 89);
            TBTalle.Margin = new Padding(4, 5, 4, 5);
            TBTalle.Name = "TBTalle";
            TBTalle.Size = new Size(106, 38);
            TBTalle.TabIndex = 8;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.SaddleBrown;
            Label7.Location = new Point(445, 54);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(81, 23);
            Label7.TabIndex = 7;
            Label7.Text = "Stock :";
            // 
            // TBStock
            // 
            TBStock.Enabled = false;
            TBStock.Location = new Point(445, 89);
            TBStock.Margin = new Padding(4, 5, 4, 5);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(106, 38);
            TBStock.TabIndex = 6;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label8.ForeColor = Color.SaddleBrown;
            Label8.Location = new Point(304, 54);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(87, 23);
            Label8.TabIndex = 5;
            Label8.Text = "Precio :";
            // 
            // TBPrecio
            // 
            TBPrecio.Enabled = false;
            TBPrecio.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecio.Location = new Point(304, 89);
            TBPrecio.Margin = new Padding(4, 5, 4, 5);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(109, 30);
            TBPrecio.TabIndex = 4;
            TBPrecio.Text = "$";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label9.ForeColor = Color.SaddleBrown;
            Label9.Location = new Point(19, 52);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(91, 23);
            Label9.TabIndex = 3;
            Label9.Text = "Codigo :";
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(204, 70);
            BBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(60, 62);
            BBuscarProducto.TabIndex = 2;
            BBuscarProducto.UseVisualStyleBackColor = false;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TBProductoVenta
            // 
            TBProductoVenta.Location = new Point(19, 85);
            TBProductoVenta.Margin = new Padding(4, 5, 4, 5);
            TBProductoVenta.Name = "TBProductoVenta";
            TBProductoVenta.Size = new Size(156, 38);
            TBProductoVenta.TabIndex = 1;
            TBProductoVenta.KeyPress += Num_KeyPress;
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.AllowUserToAddRows = false;
            dgvListaVentas.AllowUserToDeleteRows = false;
            dgvListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaVentas.BackgroundColor = Color.Tan;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Cantidad, Talle });
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(27, 571);
            dgvListaVentas.Margin = new Padding(5, 3, 5, 3);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(881, 215);
            dgvListaVentas.TabIndex = 63;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // LTotalVenta
            // 
            LTotalVenta.AutoSize = true;
            LTotalVenta.BackColor = Color.Cornsilk;
            LTotalVenta.FlatStyle = FlatStyle.Flat;
            LTotalVenta.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LTotalVenta.ForeColor = Color.SaddleBrown;
            LTotalVenta.Location = new Point(67, 818);
            LTotalVenta.Margin = new Padding(7, 0, 7, 0);
            LTotalVenta.Name = "LTotalVenta";
            LTotalVenta.Size = new Size(80, 30);
            LTotalVenta.TabIndex = 64;
            LTotalVenta.Text = "Total:";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.BackColor = Color.Cornsilk;
            TBApellidoCliente.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBApellidoCliente.Location = new Point(167, 817);
            TBApellidoCliente.Margin = new Padding(7, 8, 7, 8);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(163, 30);
            TBApellidoCliente.TabIndex = 65;
            TBApellidoCliente.Text = "$";
            // 
            // BConfirmar
            // 
            BConfirmar.BackColor = Color.DarkOliveGreen;
            BConfirmar.FlatAppearance.BorderSize = 2;
            BConfirmar.FlatStyle = FlatStyle.Flat;
            BConfirmar.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BConfirmar.ForeColor = Color.Cornsilk;
            BConfirmar.Location = new Point(706, 818);
            BConfirmar.Margin = new Padding(4, 5, 4, 5);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(180, 58);
            BConfirmar.TabIndex = 66;
            BConfirmar.Text = "Confirmar";
            BConfirmar.UseVisualStyleBackColor = false;
            BConfirmar.Click += this.BConfirmar_Click;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.SteelBlue;
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(948, 605);
            BModificarProducto.Margin = new Padding(4, 5, 4, 5);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(67, 69);
            BModificarProducto.TabIndex = 69;
            BModificarProducto.UseVisualStyleBackColor = false;
            BModificarProducto.Click += BModificarProducto_Click;
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(948, 698);
            BEliminarProducto.Margin = new Padding(4, 5, 4, 5);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(67, 69);
            BEliminarProducto.TabIndex = 68;
            BEliminarProducto.UseVisualStyleBackColor = false;
            BEliminarProducto.Click += BEliminarProducto_Click;
            // 
            // AñadirVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1080, 908);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            Controls.Add(BConfirmar);
            Controls.Add(LTotalVenta);
            Controls.Add(TBApellidoCliente);
            Controls.Add(dgvListaVentas);
            Controls.Add(GroupBoxArticulos);
            Controls.Add(GroupBoxClientes);
            Controls.Add(TBVendedor);
            Controls.Add(LVendedor);
            Controls.Add(DateTimePicker1);
            Controls.Add(LFecha);
            Controls.Add(LNumeroFactura);
            Controls.Add(TBNroFactura);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirVentas";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            GroupBoxArticulos.ResumeLayout(false);
            GroupBoxArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal TextBox TBVendedor;
        internal Label LVendedor;
        internal DateTimePicker DateTimePicker1;
        internal Label LFecha;
        internal Label LNumeroFactura;
        internal TextBox TBNroFactura;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscarCliente;
        internal TextBox TBDniCliVenta;
        internal Label Label2;
        internal Label Label5;
        internal TextBox TBTelCliVenta;
        internal Label Label4;
        internal TextBox TBApellidoCliVenta;
        internal Label Label3;
        internal TextBox TBNombreCliVenta;
        internal GroupBox GroupBoxArticulos;
        internal Label Label10;
        internal TextBox TBCantidad;
        internal Label Label6;
        internal TextBox TBTalle;
        internal Label Label7;
        internal TextBox TBStock;
        internal Label Label8;
        internal TextBox TBPrecio;
        internal Label Label9;
        internal Button BBuscarProducto;
        internal TextBox TBProductoVenta;
        internal DataGridView dgvListaVentas;
        internal DataGridViewTextBoxColumn Codigo;
        internal DataGridViewTextBoxColumn Descripcion;
        internal DataGridViewTextBoxColumn Precio;
        internal DataGridViewTextBoxColumn Cantidad;
        internal DataGridViewTextBoxColumn Talle;
        internal Label LTotalVenta;
        internal TextBox TBApellidoCliente;
        internal Button BConfirmar;
        internal Button BModificarProducto;
        internal Button BEliminarProducto;
        internal Button BAñadir;
    }

    #endregion
}