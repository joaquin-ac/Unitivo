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
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            TabDetalleVenta = new TabControl();
            TabPageDetalleVenta = new TabPage();
            dgvListaVentas = new DataGridView();
            panel2 = new Panel();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Label5 = new Label();
            TBTotalFactura = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            DateTimePickerFechaNacimiento = new DateTimePicker();
            BImprimir = new Button();
            TabDetalleVenta.SuspendLayout();
            TabPageDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TabDetalleVenta
            // 
            TabDetalleVenta.Controls.Add(TabPageDetalleVenta);
            TabDetalleVenta.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabDetalleVenta.Location = new Point(13, 311);
            TabDetalleVenta.Name = "TabDetalleVenta";
            TabDetalleVenta.SelectedIndex = 0;
            TabDetalleVenta.Size = new Size(661, 225);
            TabDetalleVenta.TabIndex = 60;
            // 
            // TabPageDetalleVenta
            // 
            TabPageDetalleVenta.Controls.Add(dgvListaVentas);
            TabPageDetalleVenta.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageDetalleVenta.Location = new Point(4, 28);
            TabPageDetalleVenta.Name = "TabPageDetalleVenta";
            TabPageDetalleVenta.Padding = new Padding(3);
            TabPageDetalleVenta.Size = new Size(653, 193);
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
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle21.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.White;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Cantidad, Talle, Subtotal });
            dgvListaVentas.Dock = DockStyle.Fill;
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(3, 3);
            dgvListaVentas.Margin = new Padding(4, 3, 4, 3);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle22.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(647, 187);
            dgvListaVentas.TabIndex = 56;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(BImprimir);
            panel2.Controls.Add(DateTimePickerFechaNacimiento);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Label5);
            panel2.Controls.Add(TBTotalFactura);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TabDetalleVenta);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 656);
            panel2.TabIndex = 61;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 79);
            label1.Name = "label1";
            label1.Size = new Size(216, 42);
            label1.TabIndex = 61;
            label1.Text = "FACTURA";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(457, 583);
            Label5.Margin = new Padding(8, 0, 8, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(79, 27);
            Label5.TabIndex = 65;
            Label5.Text = "Total: ";
            // 
            // TBTotalFactura
            // 
            TBTotalFactura.Enabled = false;
            TBTotalFactura.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBTotalFactura.Location = new Point(538, 580);
            TBTotalFactura.Margin = new Padding(5, 6, 5, 6);
            TBTotalFactura.Name = "TBTotalFactura";
            TBTotalFactura.Size = new Size(129, 34);
            TBTotalFactura.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 206);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 22);
            label2.TabIndex = 67;
            label2.Text = "N° Factura: ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(92, 230);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 34);
            textBox1.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logounitivo;
            panel1.Location = new Point(42, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(107, 133);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(268, 206);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 69;
            label3.Text = "Fecha: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(479, 206);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 71;
            label4.Text = "Vendedor: ";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(479, 230);
            textBox3.Margin = new Padding(5, 6, 5, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 34);
            textBox3.TabIndex = 70;
            // 
            // DateTimePickerFechaNacimiento
            // 
            DateTimePickerFechaNacimiento.Enabled = false;
            DateTimePickerFechaNacimiento.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            DateTimePickerFechaNacimiento.Location = new Point(268, 233);
            DateTimePickerFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento";
            DateTimePickerFechaNacimiento.Size = new Size(169, 28);
            DateTimePickerFechaNacimiento.TabIndex = 72;
            // 
            // BImprimir
            // 
            BImprimir.BackColor = Color.SteelBlue;
            BImprimir.ForeColor = Color.White;
            BImprimir.Image = Properties.Resources.icons8_imprimir_26;
            BImprimir.Location = new Point(20, 575);
            BImprimir.Margin = new Padding(4, 5, 4, 5);
            BImprimir.Name = "BImprimir";
            BImprimir.Size = new Size(47, 49);
            BImprimir.TabIndex = 73;
            BImprimir.UseVisualStyleBackColor = false;
            // 
            // FacturaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(714, 680);
            Controls.Add(panel2);
            ForeColor = Color.Chartreuse;
            FormBorderStyle = FormBorderStyle.None;
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
        internal TextBox textBox1;
        internal Label label4;
        internal TextBox textBox3;
        internal Label label3;
        private Panel panel1;
        internal DateTimePicker DateTimePickerFechaNacimiento;
        internal Button BImprimir;
    }
}