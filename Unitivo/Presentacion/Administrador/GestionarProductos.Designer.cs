﻿namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarProductos
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            BEliminarProducto = new Button();
            BModificarProducto = new Button();
            GroupBoxBuscarProducto = new GroupBox();
            label3 = new Label();
            Label2 = new Label();
            CBTalleBuscar = new ComboBox();
            CBCatBuscar = new ComboBox();
            BBuscarProducto = new Button();
            TBBuscar = new TextBox();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            button1 = new Button();
            GroupBoxDatosCliente = new GroupBox();
            TBStockAdic = new TextBox();
            CBTalleProducto = new ComboBox();
            Label5 = new Label();
            TBStockProducto = new TextBox();
            Label6 = new Label();
            TBPrecioProducto = new TextBox();
            TBNombreProducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            CBCategoriaProducto = new ComboBox();
            groupBox1 = new GroupBox();
            Label4 = new Label();
            label9 = new Label();
            BReactivar = new Button();
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            GroupBoxDatosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.FlatAppearance.BorderSize = 2;
            BEliminarProducto.FlatStyle = FlatStyle.Flat;
            BEliminarProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Properties.Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(855, 286);
            BEliminarProducto.Margin = new Padding(4);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(59, 52);
            BEliminarProducto.TabIndex = 12;
            BEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarProducto.UseVisualStyleBackColor = false;
            BEliminarProducto.Click += BEliminarProducto_Click;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.SteelBlue;
            BModificarProducto.FlatAppearance.BorderColor = Color.White;
            BModificarProducto.FlatAppearance.BorderSize = 2;
            BModificarProducto.FlatStyle = FlatStyle.Flat;
            BModificarProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(855, 202);
            BModificarProducto.Margin = new Padding(4);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(59, 52);
            BModificarProducto.TabIndex = 13;
            BModificarProducto.UseVisualStyleBackColor = false;
            BModificarProducto.Click += BModificarProducto_Click;
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(label3);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(CBTalleBuscar);
            GroupBoxBuscarProducto.Controls.Add(CBCatBuscar);
            GroupBoxBuscarProducto.Controls.Add(BBuscarProducto);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(118, 29);
            GroupBoxBuscarProducto.Margin = new Padding(4);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4);
            GroupBoxBuscarProducto.Size = new Size(657, 94);
            GroupBoxBuscarProducto.TabIndex = 82;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(466, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 45;
            label3.Text = "Talle :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(276, 20);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 20);
            Label2.TabIndex = 43;
            Label2.Text = "Categorias :";
            // 
            // CBTalleBuscar
            // 
            CBTalleBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalleBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBTalleBuscar.FormattingEnabled = true;
            CBTalleBuscar.Items.AddRange(new object[] { "Todos" });
            CBTalleBuscar.Location = new Point(469, 41);
            CBTalleBuscar.Margin = new Padding(3, 2, 3, 2);
            CBTalleBuscar.Name = "CBTalleBuscar";
            CBTalleBuscar.Size = new Size(140, 28);
            CBTalleBuscar.TabIndex = 42;
            // 
            // CBCatBuscar
            // 
            CBCatBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCatBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBCatBuscar.FormattingEnabled = true;
            CBCatBuscar.Items.AddRange(new object[] { "Todos" });
            CBCatBuscar.Location = new Point(279, 41);
            CBCatBuscar.Margin = new Padding(4, 2, 3, 2);
            CBCatBuscar.Name = "CBCatBuscar";
            CBCatBuscar.Size = new Size(140, 28);
            CBCatBuscar.TabIndex = 40;
            CBCatBuscar.SelectedIndexChanged += CBCatBuscar_SelectedIndexChanged;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.FlatAppearance.BorderColor = Color.White;
            BBuscarProducto.FlatAppearance.BorderSize = 2;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(197, 32);
            BBuscarProducto.Margin = new Padding(4);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(46, 40);
            BBuscarProducto.TabIndex = 14;
            BBuscarProducto.UseVisualStyleBackColor = false;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(20, 40);
            TBBuscar.Margin = new Padding(4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(152, 26);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += TBBuscar_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(78, 148);
            TabControlListaProductos.Margin = new Padding(3, 2, 3, 2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(741, 226);
            TabControlListaProductos.TabIndex = 81;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 26);
            TabPageListaProducto.Margin = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Size = new Size(733, 196);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Producto";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaProductos
            // 
            DataGridViewListaProductos.AllowUserToAddRows = false;
            DataGridViewListaProductos.AllowUserToDeleteRows = false;
            DataGridViewListaProductos.AllowUserToResizeColumns = false;
            DataGridViewListaProductos.AllowUserToResizeRows = false;
            DataGridViewListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaProductos.BackgroundColor = Color.RosyBrown;
            DataGridViewListaProductos.BorderStyle = BorderStyle.None;
            DataGridViewListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Categoria, Stock, Talle, Precio, Estado });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(3, 2);
            DataGridViewListaProductos.Margin = new Padding(4);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListaProductos.Size = new Size(727, 192);
            DataGridViewListaProductos.TabIndex = 6;
            DataGridViewListaProductos.RowHeaderMouseClick += DataGridViewListaProductos_RowHeaderMouseClick;
            DataGridViewListaProductos.RowHeaderMouseDoubleClick += DataGridViewListaProductos_RowHeaderMouseDoubleClick;
            // 
            // ID
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Producto
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Producto.DefaultCellStyle = dataGridViewCellStyle3;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Categoria
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Categoria.DefaultCellStyle = dataGridViewCellStyle4;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Stock.DefaultCellStyle = dataGridViewCellStyle5;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Talle
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Talle.DefaultCellStyle = dataGridViewCellStyle6;
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Precio.DefaultCellStyle = dataGridViewCellStyle7;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Estado
            // 
            dataGridViewCellStyle8.ForeColor = Color.Black;
            Estado.DefaultCellStyle = dataGridViewCellStyle8;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(730, 112);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 15;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.BackColor = Color.RosyBrown;
            GroupBoxDatosCliente.Controls.Add(TBStockAdic);
            GroupBoxDatosCliente.Controls.Add(button1);
            GroupBoxDatosCliente.Controls.Add(CBTalleProducto);
            GroupBoxDatosCliente.Controls.Add(Label5);
            GroupBoxDatosCliente.Controls.Add(TBStockProducto);
            GroupBoxDatosCliente.Controls.Add(Label6);
            GroupBoxDatosCliente.Controls.Add(TBPrecioProducto);
            GroupBoxDatosCliente.Controls.Add(TBNombreProducto);
            GroupBoxDatosCliente.Controls.Add(label7);
            GroupBoxDatosCliente.Controls.Add(label8);
            GroupBoxDatosCliente.Controls.Add(CBCategoriaProducto);
            GroupBoxDatosCliente.Controls.Add(groupBox1);
            GroupBoxDatosCliente.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(35, 410);
            GroupBoxDatosCliente.Margin = new Padding(4);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4);
            GroupBoxDatosCliente.Size = new Size(866, 214);
            GroupBoxDatosCliente.TabIndex = 19;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Producto";
            // 
            // TBStockAdic
            // 
            TBStockAdic.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBStockAdic.Location = new Point(514, 158);
            TBStockAdic.Margin = new Padding(4);
            TBStockAdic.Name = "TBStockAdic";
            TBStockAdic.Size = new Size(165, 29);
            TBStockAdic.TabIndex = 20;
            TBStockAdic.KeyPress += TBStockAdic_KeyPress;
            // 
            // CBTalleProducto
            // 
            CBTalleProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalleProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBTalleProducto.FormattingEnabled = true;
            CBTalleProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBTalleProducto.Location = new Point(277, 156);
            CBTalleProducto.Margin = new Padding(4);
            CBTalleProducto.Name = "CBTalleProducto";
            CBTalleProducto.Size = new Size(187, 32);
            CBTalleProducto.TabIndex = 19;
            CBTalleProducto.SelectedIndexChanged += CBTalleProducto_SelectedIndexChanged;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(39, 128);
            Label5.Margin = new Padding(7, 0, 7, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(74, 24);
            Label5.TabIndex = 17;
            Label5.Text = "Precio: ";
            // 
            // TBStockProducto
            // 
            TBStockProducto.Enabled = false;
            TBStockProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBStockProducto.Location = new Point(514, 86);
            TBStockProducto.Margin = new Padding(4);
            TBStockProducto.Name = "TBStockProducto";
            TBStockProducto.Size = new Size(165, 29);
            TBStockProducto.TabIndex = 10;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(274, 128);
            Label6.Margin = new Padding(7, 0, 7, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(61, 24);
            Label6.TabIndex = 18;
            Label6.Text = "Talle: ";
            // 
            // TBPrecioProducto
            // 
            TBPrecioProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecioProducto.Location = new Point(43, 157);
            TBPrecioProducto.Margin = new Padding(4);
            TBPrecioProducto.Name = "TBPrecioProducto";
            TBPrecioProducto.Size = new Size(187, 29);
            TBPrecioProducto.TabIndex = 15;
            TBPrecioProducto.KeyPress += TBPrecioProducto_KeyPress;
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreProducto.Location = new Point(43, 86);
            TBNombreProducto.Margin = new Padding(4);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(187, 29);
            TBNombreProducto.TabIndex = 8;
            TBNombreProducto.KeyPress += TBNombreProducto_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(274, 56);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 24);
            label7.TabIndex = 15;
            label7.Text = "Categoría: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(43, 56);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 24);
            label8.TabIndex = 14;
            label8.Text = "Nombre:";
            // 
            // CBCategoriaProducto
            // 
            CBCategoriaProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoriaProducto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBCategoriaProducto.FormattingEnabled = true;
            CBCategoriaProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBCategoriaProducto.Location = new Point(276, 84);
            CBCategoriaProducto.Margin = new Padding(4);
            CBCategoriaProducto.Name = "CBCategoriaProducto";
            CBCategoriaProducto.Size = new Size(187, 32);
            CBCategoriaProducto.TabIndex = 18;
            CBCategoriaProducto.SelectedIndexChanged += CBCategoriaProducto_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(491, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(210, 166);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stock";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(22, 28);
            Label4.Margin = new Padding(7, 0, 7, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(67, 24);
            Label4.TabIndex = 16;
            Label4.Text = "Actual:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 100);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 24);
            label9.TabIndex = 21;
            label9.Text = "Entrante:";
            // 
            // BReactivar
            // 
            BReactivar.BackColor = Color.DarkKhaki;
            BReactivar.FlatAppearance.BorderSize = 2;
            BReactivar.FlatStyle = FlatStyle.Flat;
            BReactivar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BReactivar.ForeColor = Color.White;
            BReactivar.Image = Properties.Resources.icons8_restaurar_24;
            BReactivar.Location = new Point(855, 286);
            BReactivar.Margin = new Padding(4);
            BReactivar.Name = "BReactivar";
            BReactivar.Size = new Size(59, 52);
            BReactivar.TabIndex = 91;
            BReactivar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReactivar.UseVisualStyleBackColor = false;
            BReactivar.Click += BReactivar_Click;
            // 
            // GestionarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 634);
            Controls.Add(BReactivar);
            Controls.Add(GroupBoxDatosCliente);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarProductos";
            Text = "Form1";
            Load += GestionarProductos_Load;
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            GroupBoxDatosCliente.ResumeLayout(false);
            GroupBoxDatosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        internal Button BEliminarProducto;
        internal Button BModificarProducto;

        #endregion

        internal GroupBox GroupBoxBuscarProducto;
        internal Button BBuscarProducto;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;
        internal Label label3;
        internal Label Label2;
        internal ComboBox CBTalleBuscar;
        internal ComboBox CBCatBuscar;
        internal Button button1;
        internal GroupBox GroupBoxDatosCliente;
        internal TextBox TBStockProducto;
        internal Label Label4;
        internal ComboBox CBTalleProducto;
        internal Label Label5;
        internal Label Label6;
        internal TextBox TBPrecioProducto;
        internal TextBox TBNombreProducto;
        internal Label label7;
        internal Label label8;
        internal ComboBox CBCategoriaProducto;
        internal TextBox TBStockAdic;
        internal Label label9;
        private GroupBox groupBox1;
        internal Button BReactivar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
    }
}