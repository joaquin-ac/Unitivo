namespace Unitivo.Presentacion.Administrador
{
    partial class ListarVentasAdmin
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
            GroupBoxBuscarProducto = new GroupBox();
            DateTimePicker2 = new DateTimePicker();
            Label2 = new Label();
            BVerDetalle = new Button();
            Label1 = new Label();
            BBuscarVenta = new Button();
            DateTimePicker1 = new DateTimePicker();
            TBBuscar = new TextBox();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaVentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(DateTimePicker2);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(BVerDetalle);
            GroupBoxBuscarProducto.Controls.Add(Label1);
            GroupBoxBuscarProducto.Controls.Add(BBuscarVenta);
            GroupBoxBuscarProducto.Controls.Add(DateTimePicker1);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(48, 28);
            GroupBoxBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Size = new Size(984, 137);
            GroupBoxBuscarProducto.TabIndex = 70;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Ventas";
            // 
            // DateTimePicker2
            // 
            DateTimePicker2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker2.Format = DateTimePickerFormat.Short;
            DateTimePicker2.Location = new Point(273, 68);
            DateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            DateTimePicker2.Name = "DateTimePicker2";
            DateTimePicker2.Size = new Size(140, 28);
            DateTimePicker2.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(269, 38);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 21);
            Label2.TabIndex = 32;
            Label2.Text = "Fecha Fin:";
            // 
            // BVerDetalle
            // 
            BVerDetalle.BackColor = Color.Sienna;
            BVerDetalle.FlatAppearance.BorderSize = 2;
            BVerDetalle.FlatStyle = FlatStyle.Flat;
            BVerDetalle.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BVerDetalle.ForeColor = Color.White;
            BVerDetalle.Location = new Point(783, 49);
            BVerDetalle.Margin = new Padding(4, 5, 4, 5);
            BVerDetalle.Name = "BVerDetalle";
            BVerDetalle.Size = new Size(148, 65);
            BVerDetalle.TabIndex = 27;
            BVerDetalle.Text = "Ver Detalle";
            BVerDetalle.TextImageRelation = TextImageRelation.TextBeforeImage;
            BVerDetalle.UseVisualStyleBackColor = false;
            BVerDetalle.Click += BVerDetalle_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(99, 38);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(115, 21);
            Label1.TabIndex = 31;
            Label1.Text = "Fecha Inicio:";
            // 
            // BBuscarVenta
            // 
            BBuscarVenta.BackColor = Color.DarkOliveGreen;
            BBuscarVenta.FlatAppearance.BorderColor = Color.White;
            BBuscarVenta.FlatAppearance.BorderSize = 2;
            BBuscarVenta.FlatStyle = FlatStyle.Flat;
            BBuscarVenta.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarVenta.ForeColor = Color.White;
            BBuscarVenta.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarVenta.Location = new Point(665, 54);
            BBuscarVenta.Margin = new Padding(4, 5, 4, 5);
            BBuscarVenta.Name = "BBuscarVenta";
            BBuscarVenta.Size = new Size(67, 58);
            BBuscarVenta.TabIndex = 14;
            BBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(103, 68);
            DateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(137, 28);
            DateTimePicker1.TabIndex = 30;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(467, 63);
            TBBuscar.Margin = new Padding(4, 5, 4, 5);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(173, 32);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += NumStr_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(48, 195);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(984, 449);
            TabControlListaProductos.TabIndex = 69;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaVentas);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 28);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3);
            TabPageListaProducto.Size = new Size(976, 417);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Ventas";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaVentas
            // 
            DataGridViewListaVentas.AllowUserToAddRows = false;
            DataGridViewListaVentas.AllowUserToDeleteRows = false;
            DataGridViewListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaVentas.BackgroundColor = Color.RosyBrown;
            DataGridViewListaVentas.BorderStyle = BorderStyle.None;
            DataGridViewListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListaVentas.ColumnHeadersHeight = 20;
            DataGridViewListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column6 });
            DataGridViewListaVentas.Dock = DockStyle.Fill;
            DataGridViewListaVentas.EnableHeadersVisualStyles = false;
            DataGridViewListaVentas.Location = new Point(3, 3);
            DataGridViewListaVentas.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListaVentas.Name = "DataGridViewListaVentas";
            DataGridViewListaVentas.ReadOnly = true;
            DataGridViewListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListaVentas.RowHeadersWidth = 51;
            DataGridViewListaVentas.Size = new Size(970, 411);
            DataGridViewListaVentas.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "N° Factura";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cliente";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Total";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // ListarVentasAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 769);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListarVentasAdmin";
            Text = "Form1";
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxBuscarProducto;
        internal DateTimePicker DateTimePicker2;
        internal Label Label2;
        internal Button BVerDetalle;
        internal Label Label1;
        internal Button BBuscarVenta;
        internal DateTimePicker DateTimePicker1;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaVentas;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column6;

        #endregion
    }
}