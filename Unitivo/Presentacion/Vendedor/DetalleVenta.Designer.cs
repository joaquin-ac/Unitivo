namespace Unitivo.Presentacion.Vendedor
{
    partial class DetalleVenta
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TabDetalleVenta = new TabControl();
            TabPageDetalleVenta = new TabPage();
            dgvListaVentas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            BVolver = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
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
            TabDetalleVenta.Location = new Point(36, 38);
            TabDetalleVenta.Name = "TabDetalleVenta";
            TabDetalleVenta.SelectedIndex = 0;
            TabDetalleVenta.Size = new Size(1029, 420);
            TabDetalleVenta.TabIndex = 59;
            // 
            // TabPageDetalleVenta
            // 
            TabPageDetalleVenta.Controls.Add(dgvListaVentas);
            TabPageDetalleVenta.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageDetalleVenta.Location = new Point(4, 28);
            TabPageDetalleVenta.Name = "TabPageDetalleVenta";
            TabPageDetalleVenta.Padding = new Padding(3);
            TabPageDetalleVenta.Size = new Size(1021, 388);
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
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Cantidad, Talle });
            dgvListaVentas.Dock = DockStyle.Fill;
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(3, 3);
            dgvListaVentas.Margin = new Padding(4, 3, 4, 3);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(1015, 382);
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
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(463, 478);
            BVolver.Margin = new Padding(4, 5, 4, 5);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(181, 41);
            BVolver.TabIndex = 71;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            BVolver.Click += BVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(1094, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 534);
            panel1.TabIndex = 72;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 534);
            panel2.TabIndex = 73;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Location = new Point(0, 618);
            panel4.Name = "panel4";
            panel4.Size = new Size(1104, 10);
            panel4.TabIndex = 75;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1104, 10);
            panel3.TabIndex = 74;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(0, 537);
            panel5.Name = "panel5";
            panel5.Size = new Size(1104, 10);
            panel5.TabIndex = 75;
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1105, 547);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BVolver);
            Controls.Add(TabDetalleVenta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TabDetalleVenta.ResumeLayout(false);
            TabPageDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal TabControl TabDetalleVenta;
        internal TabPage TabPageDetalleVenta;
        internal DataGridView dgvListaVentas;
        internal DataGridViewTextBoxColumn Codigo;
        internal DataGridViewTextBoxColumn Descripcion;
        internal DataGridViewTextBoxColumn Precio;
        internal DataGridViewTextBoxColumn Cantidad;
        internal DataGridViewTextBoxColumn Talle;

        #endregion

        internal Button BVolver;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}