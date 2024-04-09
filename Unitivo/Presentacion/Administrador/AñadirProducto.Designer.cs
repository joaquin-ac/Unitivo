namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirProducto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            DataGridViewRegistroCategorias = new DataGridView();
            Label1 = new Label();
            Panel2 = new Panel();
            BAgregarImagen = new Button();
            pictureBoxProducto = new PictureBox();
            BAñadirProducto = new Button();
            CBCategoria = new ComboBox();
            LImagen = new Label();
            CBTalle = new ComboBox();
            Label6 = new Label();
            Label3 = new Label();
            TBNombreProducto = new TextBox();
            Label2 = new Label();
            Label5 = new Label();
            TBPrecio = new TextBox();
            Label4 = new Label();
            TBStock = new TextBox();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(30, 286);
            TabControlListaProductos.Margin = new Padding(2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(892, 220);
            TabControlListaProductos.TabIndex = 17;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Controls.Add(DataGridViewRegistroCategorias);
            TabPageListaProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 26);
            TabPageListaProducto.Margin = new Padding(2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(2);
            TabPageListaProducto.Size = new Size(884, 190);
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
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Categoria, Stock, Precio, Talle });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(2, 2);
            DataGridViewListaProductos.Margin = new Padding(4, 3, 4, 3);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(880, 186);
            DataGridViewListaProductos.TabIndex = 7;
            DataGridViewListaProductos.CellContentClick += DataGridViewListaProductos_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // DataGridViewRegistroCategorias
            // 
            DataGridViewRegistroCategorias.AllowUserToAddRows = false;
            DataGridViewRegistroCategorias.AllowUserToDeleteRows = false;
            DataGridViewRegistroCategorias.BackgroundColor = Color.FromArgb(31, 31, 69);
            DataGridViewRegistroCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridViewRegistroCategorias.DefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewRegistroCategorias.Dock = DockStyle.Fill;
            DataGridViewRegistroCategorias.EnableHeadersVisualStyles = false;
            DataGridViewRegistroCategorias.Location = new Point(2, 2);
            DataGridViewRegistroCategorias.Margin = new Padding(4, 3, 4, 3);
            DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias";
            DataGridViewRegistroCategorias.ReadOnly = true;
            DataGridViewRegistroCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewRegistroCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            DataGridViewRegistroCategorias.RowsDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewRegistroCategorias.Size = new Size(880, 186);
            DataGridViewRegistroCategorias.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(278, 23);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(284, 39);
            Label1.TabIndex = 15;
            Label1.Text = "Añadir Producto :";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Cornsilk;
            Panel2.Controls.Add(BAgregarImagen);
            Panel2.Controls.Add(pictureBoxProducto);
            Panel2.Controls.Add(BAñadirProducto);
            Panel2.Controls.Add(CBCategoria);
            Panel2.Controls.Add(LImagen);
            Panel2.Controls.Add(CBTalle);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(TBNombreProducto);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(TBPrecio);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(TBStock);
            Panel2.Location = new Point(30, 92);
            Panel2.Margin = new Padding(2);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(892, 158);
            Panel2.TabIndex = 16;
            // 
            // BAgregarImagen
            // 
            BAgregarImagen.Location = new Point(400, 115);
            BAgregarImagen.Margin = new Padding(3, 2, 3, 2);
            BAgregarImagen.Name = "BAgregarImagen";
            BAgregarImagen.Size = new Size(158, 22);
            BAgregarImagen.TabIndex = 20;
            BAgregarImagen.Text = "Agregar";
            BAgregarImagen.UseVisualStyleBackColor = true;
            BAgregarImagen.Click += btnCargarImagen_Click;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.BackColor = Color.RosyBrown;
            pictureBoxProducto.Location = new Point(612, 34);
            pictureBoxProducto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(124, 92);
            pictureBoxProducto.TabIndex = 19;
            pictureBoxProducto.TabStop = false;
            // 
            // BAñadirProducto
            // 
            BAñadirProducto.BackColor = Color.DarkOliveGreen;
            BAñadirProducto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirProducto.ForeColor = Color.White;
            BAñadirProducto.Location = new Point(773, 55);
            BAñadirProducto.Margin = new Padding(2);
            BAñadirProducto.Name = "BAñadirProducto";
            BAñadirProducto.Size = new Size(105, 47);
            BAñadirProducto.TabIndex = 2;
            BAñadirProducto.Text = "Añadir";
            BAñadirProducto.UseVisualStyleBackColor = false;
            BAñadirProducto.Click += BAñadirProducto_Click;
            // 
            // CBCategoria
            // 
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(122, 66);
            CBCategoria.Margin = new Padding(2);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(153, 23);
            CBCategoria.TabIndex = 15;
            // 
            // LImagen
            // 
            LImagen.AutoSize = true;
            LImagen.BackColor = Color.Cornsilk;
            LImagen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LImagen.ForeColor = Color.SaddleBrown;
            LImagen.Location = new Point(300, 112);
            LImagen.Margin = new Padding(5, 0, 5, 0);
            LImagen.Name = "LImagen";
            LImagen.Size = new Size(83, 24);
            LImagen.TabIndex = 13;
            LImagen.Text = "Imagen: ";
            // 
            // CBTalle
            // 
            CBTalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalle.FormattingEnabled = true;
            CBTalle.Location = new Point(405, 68);
            CBTalle.Margin = new Padding(2);
            CBTalle.Name = "CBTalle";
            CBTalle.Size = new Size(153, 23);
            CBTalle.TabIndex = 11;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Cornsilk;
            Label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(298, 67);
            Label6.Margin = new Padding(5, 0, 5, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(61, 24);
            Label6.TabIndex = 10;
            Label6.Text = "Talle: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Cornsilk;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(15, 64);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 24);
            Label3.TabIndex = 1;
            Label3.Text = "Categoría: ";
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Location = new Point(122, 21);
            TBNombreProducto.Margin = new Padding(5);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(153, 23);
            TBNombreProducto.TabIndex = 5;
            TBNombreProducto.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Cornsilk;
            Label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(15, 19);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(84, 24);
            Label2.TabIndex = 0;
            Label2.Text = "Nombre:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Cornsilk;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(300, 21);
            Label5.Margin = new Padding(5, 0, 5, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(74, 24);
            Label5.TabIndex = 3;
            Label5.Text = "Precio: ";
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(405, 21);
            TBPrecio.Margin = new Padding(5);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(153, 23);
            TBPrecio.TabIndex = 8;
            TBPrecio.KeyPress += Num_DecimalKeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Cornsilk;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(15, 112);
            Label4.Margin = new Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 24);
            Label4.TabIndex = 2;
            Label4.Text = "Stock:";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(122, 115);
            TBStock.Margin = new Padding(5);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(153, 23);
            TBStock.TabIndex = 7;
            TBStock.KeyPress += Num_KeyPress;
            // 
            // AñadirProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 570);
            Controls.Add(TabControlListaProductos);
            Controls.Add(Label1);
            Controls.Add(Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirProducto";
            Text = "     ";
            Load += AñadirProducto_Load;
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;
        internal DataGridView DataGridViewRegistroCategorias;
        internal Label Label1;
        internal Panel Panel2;
        internal ComboBox CBCategoria;
        internal Button BAñadirProducto;
        internal Label LImagen;
        internal ComboBox CBTalle;
        internal Label Label6;
        internal Label Label3;
        internal TextBox TBNombreProducto;
        internal Label Label2;
        internal Label Label5;
        internal TextBox TBPrecio;
        internal Label Label4;
        internal TextBox TBStock;

        #endregion

        private PictureBox pictureBoxProducto;
        private Button BAgregarImagen;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Talle;
    }


}