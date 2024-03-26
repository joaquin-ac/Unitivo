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
            ComboBoxBuscarDni = new ComboBox();
            DateTimePicker2 = new DateTimePicker();
            Label2 = new Label();
            Label1 = new Label();
            BBuscarCategoria = new Button();
            DateTimePicker1 = new DateTimePicker();
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
            label3.Font = new Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(258, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(529, 54);
            label3.TabIndex = 76;
            label3.Text = "Ventas por Categoria";
            // 
            // GroupBoxBuscarCategoia
            // 
            GroupBoxBuscarCategoia.BackColor = Color.Cornsilk;
            GroupBoxBuscarCategoia.Controls.Add(ComboBoxBuscarDni);
            GroupBoxBuscarCategoia.Controls.Add(DateTimePicker2);
            GroupBoxBuscarCategoia.Controls.Add(Label2);
            GroupBoxBuscarCategoia.Controls.Add(Label1);
            GroupBoxBuscarCategoia.Controls.Add(BBuscarCategoria);
            GroupBoxBuscarCategoia.Controls.Add(DateTimePicker1);
            GroupBoxBuscarCategoia.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarCategoia.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarCategoia.Location = new Point(30, 154);
            GroupBoxBuscarCategoia.Margin = new Padding(4, 5, 4, 5);
            GroupBoxBuscarCategoia.Name = "GroupBoxBuscarCategoia";
            GroupBoxBuscarCategoia.Padding = new Padding(4, 5, 4, 5);
            GroupBoxBuscarCategoia.Size = new Size(984, 137);
            GroupBoxBuscarCategoia.TabIndex = 75;
            GroupBoxBuscarCategoia.TabStop = false;
            GroupBoxBuscarCategoia.Text = "Filtrar Busqueda";
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Location = new Point(443, 65);
            ComboBoxBuscarDni.Margin = new Padding(4, 5, 4, 5);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(160, 31);
            ComboBoxBuscarDni.TabIndex = 34;
            ComboBoxBuscarDni.Text = "Categoria";
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
            Label2.Location = new Point(271, 42);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 21);
            Label2.TabIndex = 32;
            Label2.Text = "Fecha Fin:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(101, 42);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(115, 21);
            Label1.TabIndex = 31;
            Label1.Text = "Fecha Inicio:";
            // 
            // BBuscarCategoria
            // 
            BBuscarCategoria.BackColor = Color.DarkOliveGreen;
            BBuscarCategoria.FlatAppearance.BorderColor = Color.White;
            BBuscarCategoria.FlatAppearance.BorderSize = 2;
            BBuscarCategoria.FlatStyle = FlatStyle.Flat;
            BBuscarCategoria.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarCategoria.ForeColor = Color.White;
            BBuscarCategoria.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarCategoria.Location = new Point(651, 51);
            BBuscarCategoria.Margin = new Padding(4, 5, 4, 5);
            BBuscarCategoria.Name = "BBuscarCategoria";
            BBuscarCategoria.Size = new Size(67, 58);
            BBuscarCategoria.TabIndex = 14;
            BBuscarCategoria.UseVisualStyleBackColor = false;
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
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(30, 321);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(984, 449);
            TabControlListaProductos.TabIndex = 74;
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
            DataGridViewListaVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DataGridViewListaVentas.Dock = DockStyle.Fill;
            DataGridViewListaVentas.EnableHeadersVisualStyles = false;
            DataGridViewListaVentas.Location = new Point(3, 3);
            DataGridViewListaVentas.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListaVentas.Name = "DataGridViewListaVentas";
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
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Categoria";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Porcentaje";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // VentasPorCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1044, 814);
            Controls.Add(label3);
            Controls.Add(GroupBoxBuscarCategoia);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}