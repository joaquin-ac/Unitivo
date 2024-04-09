namespace Unitivo.Presentacion.Administrador
{
    partial class VentasPorCategoria
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
            label3 = new Label();
            GroupBoxBuscarCategoia = new GroupBox();
            CBCategoria = new ComboBox();
            DateTimeHasta = new DateTimePicker();
            Label2 = new Label();
            Label1 = new Label();
            BBuscarCategoria = new Button();
            DateTimeDesde = new DateTimePicker();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaVentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            GroupBoxBuscarCategoia.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cornsilk;
            label3.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(226, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(377, 44);
            label3.TabIndex = 76;
            label3.Text = "Ventas por Categoria";
            // 
            // GroupBoxBuscarCategoia
            // 
            GroupBoxBuscarCategoia.BackColor = Color.Cornsilk;
            GroupBoxBuscarCategoia.Controls.Add(CBCategoria);
            GroupBoxBuscarCategoia.Controls.Add(DateTimeHasta);
            GroupBoxBuscarCategoia.Controls.Add(Label2);
            GroupBoxBuscarCategoia.Controls.Add(Label1);
            GroupBoxBuscarCategoia.Controls.Add(BBuscarCategoria);
            GroupBoxBuscarCategoia.Controls.Add(DateTimeDesde);
            GroupBoxBuscarCategoia.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarCategoia.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarCategoia.Location = new Point(26, 116);
            GroupBoxBuscarCategoia.Margin = new Padding(4);
            GroupBoxBuscarCategoia.Name = "GroupBoxBuscarCategoia";
            GroupBoxBuscarCategoia.Padding = new Padding(4);
            GroupBoxBuscarCategoia.Size = new Size(861, 103);
            GroupBoxBuscarCategoia.TabIndex = 75;
            GroupBoxBuscarCategoia.TabStop = false;
            GroupBoxBuscarCategoia.Text = "Filtrar Busqueda";
            // 
            // CBCategoria
            // 
            CBCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBCategoria.ForeColor = Color.SaddleBrown;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(388, 49);
            CBCategoria.Margin = new Padding(4);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(140, 28);
            CBCategoria.TabIndex = 34;
            CBCategoria.Text = "Categoria";
            // 
            // DateTimeHasta
            // 
            DateTimeHasta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeHasta.Format = DateTimePickerFormat.Short;
            DateTimeHasta.Location = new Point(239, 51);
            DateTimeHasta.Margin = new Padding(4);
            DateTimeHasta.Name = "DateTimeHasta";
            DateTimeHasta.Size = new Size(123, 24);
            DateTimeHasta.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.Location = new Point(237, 32);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 18);
            Label2.TabIndex = 32;
            Label2.Text = "Fecha Fin:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(88, 32);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(91, 18);
            Label1.TabIndex = 31;
            Label1.Text = "Fecha Inicio:";
            // 
            // BBuscarCategoria
            // 
            BBuscarCategoria.BackColor = Color.DarkOliveGreen;
            BBuscarCategoria.FlatAppearance.BorderColor = Color.White;
            BBuscarCategoria.FlatAppearance.BorderSize = 2;
            BBuscarCategoria.FlatStyle = FlatStyle.Flat;
            BBuscarCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarCategoria.ForeColor = Color.White;
            BBuscarCategoria.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarCategoria.Location = new Point(570, 38);
            BBuscarCategoria.Margin = new Padding(4);
            BBuscarCategoria.Name = "BBuscarCategoria";
            BBuscarCategoria.Size = new Size(59, 44);
            BBuscarCategoria.TabIndex = 14;
            BBuscarCategoria.UseVisualStyleBackColor = false;
            BBuscarCategoria.Click += BBuscarCategoria_Click;
            // 
            // DateTimeDesde
            // 
            DateTimeDesde.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeDesde.Format = DateTimePickerFormat.Short;
            DateTimeDesde.Location = new Point(90, 51);
            DateTimeDesde.Margin = new Padding(4);
            DateTimeDesde.Name = "DateTimeDesde";
            DateTimeDesde.Size = new Size(120, 24);
            DateTimeDesde.TabIndex = 30;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(26, 241);
            TabControlListaProductos.Margin = new Padding(3, 2, 3, 2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(861, 337);
            TabControlListaProductos.TabIndex = 74;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaVentas);
            TabPageListaProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 26);
            TabPageListaProducto.Margin = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3, 2, 3, 2);
            TabPageListaProducto.Size = new Size(853, 307);
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListaVentas.ColumnHeadersHeight = 20;
            DataGridViewListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DataGridViewListaVentas.Dock = DockStyle.Fill;
            DataGridViewListaVentas.EnableHeadersVisualStyles = false;
            DataGridViewListaVentas.Location = new Point(3, 2);
            DataGridViewListaVentas.Margin = new Padding(4);
            DataGridViewListaVentas.Name = "DataGridViewListaVentas";
            DataGridViewListaVentas.ReadOnly = true;
            DataGridViewListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListaVentas.RowHeadersWidth = 51;
            DataGridViewListaVentas.Size = new Size(847, 303);
            DataGridViewListaVentas.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Categoria";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Porcentaje";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // VentasPorCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(914, 610);
            Controls.Add(label3);
            Controls.Add(GroupBoxBuscarCategoia);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentasPorCategoria";
            Text = "Form1";
            GroupBoxBuscarCategoia.ResumeLayout(false);
            GroupBoxBuscarCategoia.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label3;
        internal GroupBox GroupBoxBuscarCategoia;
        internal ComboBox ComboBoxBuscarDni;
        internal DateTimePicker DateTimePicker2;
        internal Label Label2;
        internal Label Label1;
        internal Button BBuscarCategoria;
        internal DateTimePicker DateTimePicker1;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaVentas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        internal ComboBox CBCategoria;
        internal DateTimePicker DateTimeHasta;
        internal DateTimePicker DateTimeDesde;
    }
}