namespace Unitivo.Presentacion.Vendedor
{
    partial class FacturaVenta
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
            TabDetalleVenta = new TabControl();
            TabPageDetalleVenta = new TabPage();
            dgvListaVentas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            BImprimir = new Button();
            DateTimePickerFecha = new DateTimePicker();
            label4 = new Label();
            TBVendedor = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            TBIDFactura = new TextBox();
            Label5 = new Label();
            TBTotalFactura = new TextBox();
            label1 = new Label();
            TabDetalleVenta.SuspendLayout();
            TabPageDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TabDetalleVenta
            // 
            TabDetalleVenta.Controls.Add(TabPageDetalleVenta);
            TabDetalleVenta.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabDetalleVenta.Location = new Point(11, 233);
            TabDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabDetalleVenta.Name = "TabDetalleVenta";
            TabDetalleVenta.SelectedIndex = 0;
            TabDetalleVenta.Size = new Size(578, 169);
            TabDetalleVenta.TabIndex = 60;
            // 
            // TabPageDetalleVenta
            // 
            TabPageDetalleVenta.Controls.Add(dgvListaVentas);
            TabPageDetalleVenta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageDetalleVenta.Location = new Point(4, 26);
            TabPageDetalleVenta.Margin = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Name = "TabPageDetalleVenta";
            TabPageDetalleVenta.Padding = new Padding(3, 2, 3, 2);
            TabPageDetalleVenta.Size = new Size(570, 139);
            TabPageDetalleVenta.TabIndex = 0;
            TabPageDetalleVenta.Text = "Detalle de Venta";
            TabPageDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.AllowUserToAddRows = false;
            dgvListaVentas.AllowUserToDeleteRows = false;
            dgvListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaVentas.BackgroundColor = Color.RosyBrown;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Cantidad, Talle, Subtotal });
            dgvListaVentas.Dock = DockStyle.Fill;
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(3, 2);
            dgvListaVentas.Margin = new Padding(4, 2, 4, 2);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(564, 135);
            dgvListaVentas.TabIndex = 56;
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
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(BImprimir);
            panel2.Controls.Add(DateTimePickerFecha);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TBVendedor);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TBIDFactura);
            panel2.Controls.Add(Label5);
            panel2.Controls.Add(TBTotalFactura);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TabDetalleVenta);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 492);
            panel2.TabIndex = 61;
            panel2.Paint += panel2_Paint;
            // 
            // BImprimir
            // 
            BImprimir.BackColor = Color.SteelBlue;
            BImprimir.ForeColor = Color.White;
            BImprimir.Image = Properties.Resources.icons8_imprimir_26;
            BImprimir.Location = new Point(18, 431);
            BImprimir.Margin = new Padding(4);
            BImprimir.Name = "BImprimir";
            BImprimir.Size = new Size(41, 37);
            BImprimir.TabIndex = 73;
            BImprimir.UseVisualStyleBackColor = false;
            BImprimir.Click += BImprimir_Click;
            // 
            // DateTimePickerFecha
            // 
            DateTimePickerFecha.Enabled = false;
            DateTimePickerFecha.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePickerFecha.Format = DateTimePickerFormat.Short;
            DateTimePickerFecha.Location = new Point(234, 175);
            DateTimePickerFecha.Margin = new Padding(4);
            DateTimePickerFecha.Name = "DateTimePickerFecha";
            DateTimePickerFecha.Size = new Size(148, 24);
            DateTimePickerFecha.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(419, 154);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 71;
            label4.Text = "Vendedor: ";
            // 
            // TBVendedor
            // 
            TBVendedor.Enabled = false;
            TBVendedor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBVendedor.Location = new Point(419, 172);
            TBVendedor.Margin = new Padding(4);
            TBVendedor.Name = "TBVendedor";
            TBVendedor.Size = new Size(113, 29);
            TBVendedor.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(234, 154);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 69;
            label3.Text = "Fecha: ";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logounitivo;
            panel1.Location = new Point(37, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 100);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 154);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 67;
            label2.Text = "N° Factura: ";
            // 
            // TBIDFactura
            // 
            TBIDFactura.Enabled = false;
            TBIDFactura.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBIDFactura.Location = new Point(80, 172);
            TBIDFactura.Margin = new Padding(4);
            TBIDFactura.Name = "TBIDFactura";
            TBIDFactura.Size = new Size(113, 29);
            TBIDFactura.TabIndex = 66;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(400, 437);
            Label5.Margin = new Padding(7, 0, 7, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(61, 24);
            Label5.TabIndex = 65;
            Label5.Text = "Total: ";
            // 
            // TBTotalFactura
            // 
            TBTotalFactura.Enabled = false;
            TBTotalFactura.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBTotalFactura.Location = new Point(471, 435);
            TBTotalFactura.Margin = new Padding(4);
            TBTotalFactura.Name = "TBTotalFactura";
            TBTotalFactura.Size = new Size(113, 29);
            TBTotalFactura.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(216, 59);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 61;
            label1.Text = "FACTURA";
            // 
            // FacturaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(625, 510);
            Controls.Add(panel2);
            ForeColor = Color.Chartreuse;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FacturaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TabDetalleVenta.ResumeLayout(false);
            TabPageDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        internal TabControl TabDetalleVenta;
        internal TabPage TabPageDetalleVenta;
        internal DataGridView dgvListaVentas;
        private Panel panel2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label1;
        internal Label Label5;
        internal TextBox TBTotalFactura;
        internal Label label2;
        internal TextBox TBIDFactura;
        internal Label label4;
        internal TextBox TBVendedor;
        internal Label label3;
        private Panel panel1;
        internal DateTimePicker DateTimePickerFecha;
        internal Button BImprimir;
    }
}