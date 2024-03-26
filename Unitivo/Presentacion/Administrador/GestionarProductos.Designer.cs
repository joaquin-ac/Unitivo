namespace Unitivo.Presentacion.Administrador
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            BEliminarProducto = new Button();
            BModificarProducto = new Button();
            GroupBoxBuscarProducto = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            Label2 = new Label();
            comboBox3 = new ComboBox();
            ComboBox2 = new ComboBox();
            ComboBox1 = new ComboBox();
            BBuscarProducto = new Button();
            TBBuscar = new TextBox();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            GroupBoxDatosCliente = new GroupBox();
            TBStockAdic = new TextBox();
            label9 = new Label();
            TBStockProducto = new TextBox();
            Label4 = new Label();
            CBTalleProducto = new ComboBox();
            Label5 = new Label();
            Label6 = new Label();
            TBPrecioProducto = new TextBox();
            TBNombreProducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            CBCategoriaProducto = new ComboBox();
            groupBox1 = new GroupBox();
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
            BEliminarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Properties.Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(977, 386);
            BEliminarProducto.Margin = new Padding(4, 5, 4, 5);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(67, 69);
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
            BModificarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(977, 269);
            BModificarProducto.Margin = new Padding(4, 5, 4, 5);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(67, 69);
            BModificarProducto.TabIndex = 13;
            BModificarProducto.UseVisualStyleBackColor = false;
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(label3);
            GroupBoxBuscarProducto.Controls.Add(label1);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(comboBox3);
            GroupBoxBuscarProducto.Controls.Add(ComboBox2);
            GroupBoxBuscarProducto.Controls.Add(ComboBox1);
            GroupBoxBuscarProducto.Controls.Add(BBuscarProducto);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(78, 39);
            GroupBoxBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Size = new Size(880, 125);
            GroupBoxBuscarProducto.TabIndex = 82;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(682, 27);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 45;
            label3.Text = "Talle :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(498, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 44;
            label1.Text = "Marcas :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(316, 27);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(118, 25);
            Label2.TabIndex = 43;
            Label2.Text = "Categorias :";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(685, 55);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(160, 30);
            comboBox3.TabIndex = 42;
            // 
            // ComboBox2
            // 
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Location = new Point(500, 55);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(160, 30);
            ComboBox2.TabIndex = 41;
            // 
            // ComboBox1
            // 
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(319, 55);
            ComboBox1.Margin = new Padding(5, 3, 3, 3);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(160, 30);
            ComboBox1.TabIndex = 40;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.FlatAppearance.BorderColor = Color.White;
            BBuscarProducto.FlatAppearance.BorderSize = 2;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(225, 42);
            BBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(53, 54);
            BBuscarProducto.TabIndex = 14;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(23, 54);
            TBBuscar.Margin = new Padding(4, 5, 4, 5);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(173, 30);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += NumStr_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(89, 198);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(847, 301);
            TabControlListaProductos.TabIndex = 81;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 28);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3);
            TabPageListaProducto.Size = new Size(839, 269);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Producto";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaProductos
            // 
            DataGridViewListaProductos.AllowUserToAddRows = false;
            DataGridViewListaProductos.AllowUserToDeleteRows = false;
            DataGridViewListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaProductos.BackgroundColor = Color.RosyBrown;
            DataGridViewListaProductos.BorderStyle = BorderStyle.None;
            DataGridViewListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column1, Column4 });
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(3, 3);
            DataGridViewListaProductos.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(833, 263);
            DataGridViewListaProductos.TabIndex = 6;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Producto";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Talle";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(834, 149);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(131, 49);
            button1.TabIndex = 15;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
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
            GroupBoxDatosCliente.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(40, 546);
            GroupBoxDatosCliente.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Size = new Size(990, 286);
            GroupBoxDatosCliente.TabIndex = 19;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Producto";
            // 
            // TBStockAdic
            // 
            TBStockAdic.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBStockAdic.Location = new Point(587, 210);
            TBStockAdic.Margin = new Padding(5, 6, 5, 6);
            TBStockAdic.Name = "TBStockAdic";
            TBStockAdic.Size = new Size(188, 34);
            TBStockAdic.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 134);
            label9.Margin = new Padding(8, 0, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 27);
            label9.TabIndex = 21;
            label9.Text = "Entrante:";
            // 
            // TBStockProducto
            // 
            TBStockProducto.Enabled = false;
            TBStockProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBStockProducto.Location = new Point(587, 114);
            TBStockProducto.Margin = new Padding(5, 6, 5, 6);
            TBStockProducto.Name = "TBStockProducto";
            TBStockProducto.Size = new Size(188, 34);
            TBStockProducto.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(25, 38);
            Label4.Margin = new Padding(8, 0, 8, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(86, 27);
            Label4.TabIndex = 16;
            Label4.Text = "Actual:";
            // 
            // CBTalleProducto
            // 
            CBTalleProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalleProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBTalleProducto.FormattingEnabled = true;
            CBTalleProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBTalleProducto.Location = new Point(317, 208);
            CBTalleProducto.Margin = new Padding(4, 5, 4, 5);
            CBTalleProducto.Name = "CBTalleProducto";
            CBTalleProducto.Size = new Size(213, 35);
            CBTalleProducto.TabIndex = 19;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(45, 171);
            Label5.Margin = new Padding(8, 0, 8, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(94, 27);
            Label5.TabIndex = 17;
            Label5.Text = "Precio: ";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(313, 171);
            Label6.Margin = new Padding(8, 0, 8, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(77, 27);
            Label6.TabIndex = 18;
            Label6.Text = "Talle: ";
            // 
            // TBPrecioProducto
            // 
            TBPrecioProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecioProducto.Location = new Point(49, 209);
            TBPrecioProducto.Margin = new Padding(5, 6, 5, 6);
            TBPrecioProducto.Name = "TBPrecioProducto";
            TBPrecioProducto.Size = new Size(213, 34);
            TBPrecioProducto.TabIndex = 15;
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreProducto.Location = new Point(49, 114);
            TBNombreProducto.Margin = new Padding(5, 6, 5, 6);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(213, 34);
            TBNombreProducto.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(313, 75);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 27);
            label7.TabIndex = 15;
            label7.Text = "Categoría: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(49, 75);
            label8.Margin = new Padding(8, 0, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 27);
            label8.TabIndex = 14;
            label8.Text = "Nombre:";
            // 
            // CBCategoriaProducto
            // 
            CBCategoriaProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoriaProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBCategoriaProducto.FormattingEnabled = true;
            CBCategoriaProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBCategoriaProducto.Location = new Point(316, 112);
            CBCategoriaProducto.Margin = new Padding(4, 5, 4, 5);
            CBCategoriaProducto.Name = "CBCategoriaProducto";
            CBCategoriaProducto.Size = new Size(213, 35);
            CBCategoriaProducto.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(561, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 221);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stock";
            // 
            // GestionarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 846);
            Controls.Add(GroupBoxDatosCliente);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarProductos";
            Text = "Form1";
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
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Categoria;
        internal DataGridViewTextBoxColumn Stock;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
        internal Label label3;
        internal Label label1;
        internal Label Label2;
        internal ComboBox comboBox3;
        internal ComboBox ComboBox2;
        internal ComboBox ComboBox1;
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
    }
}