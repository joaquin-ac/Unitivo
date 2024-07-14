namespace Unitivo.Presentacion.Vendedor
{
    partial class ListarProductos
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            GroupBoxBuscarProducto = new GroupBox();
            label3 = new Label();
            Label2 = new Label();
            CBTalle = new ComboBox();
            CBCategoria = new ComboBox();
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
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(label3);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(CBTalle);
            GroupBoxBuscarProducto.Controls.Add(CBCategoria);
            GroupBoxBuscarProducto.Controls.Add(BBuscarProducto);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(135, 28);
            GroupBoxBuscarProducto.Margin = new Padding(4, 4, 4, 4);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4, 4, 4, 4);
            GroupBoxBuscarProducto.Size = new Size(674, 94);
            GroupBoxBuscarProducto.TabIndex = 19;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(482, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 39;
            label3.Text = "Talle :";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(284, 22);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 20);
            Label2.TabIndex = 37;
            Label2.Text = "Categorias :";
            // 
            // CBTalle
            // 
            CBTalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBTalle.FormattingEnabled = true;
            CBTalle.Items.AddRange(new object[] { "Todos" });
            CBTalle.Location = new Point(485, 43);
            CBTalle.Margin = new Padding(3, 2, 3, 2);
            CBTalle.Name = "CBTalle";
            CBTalle.Size = new Size(140, 28);
            CBTalle.TabIndex = 36;
            // 
            // CBCategoria
            // 
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Items.AddRange(new object[] { "Todos" });
            CBCategoria.Location = new Point(287, 43);
            CBCategoria.Margin = new Padding(4, 2, 3, 2);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(140, 28);
            CBCategoria.TabIndex = 34;
            CBCategoria.SelectedIndexChanged += CBCategoria_SelectedIndexChanged;
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
            BBuscarProducto.Location = new Point(197, 35);
            BBuscarProducto.Margin = new Padding(4, 4, 4, 4);
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
            TBBuscar.Location = new Point(20, 43);
            TBBuscar.Margin = new Padding(4, 4, 4, 4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(152, 26);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += NumStr_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(55, 142);
            TabControlListaProductos.Margin = new Padding(3, 2, 3, 2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(839, 339);
            TabControlListaProductos.TabIndex = 18;
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
            TabPageListaProducto.Size = new Size(831, 309);
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
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column1, Column4 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(3, 2);
            DataGridViewListaProductos.Margin = new Padding(4, 4, 4, 4);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListaProductos.Size = new Size(825, 305);
            DataGridViewListaProductos.TabIndex = 6;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Producto";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
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
            // Column1
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle6;
            Column1.HeaderText = "Talle";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Column4.DefaultCellStyle = dataGridViewCellStyle7;
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ListarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(934, 554);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "ListarProductos";
            Text = "Form1";
            Load += ListarProductos_Load;
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxBuscarProducto;
        internal Button BBuscarProducto;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;

        #endregion

        internal Label label3;
        internal Label Label2;
        internal ComboBox CBTalle;
        internal ComboBox CBCategoria;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
    }
}