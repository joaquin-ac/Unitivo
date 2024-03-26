namespace Unitivo.Presentacion.Administrador
{
    partial class ListarVendedores
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
            BImprimirVendedor = new Button();
            GroupBoxVendedor = new GroupBox();
            BBuscarVendedor = new Button();
            TBBuscarVendedor = new TextBox();
            TabControlListaVendedores = new TabControl();
            TabPageListaVendedores = new TabPage();
            dgvEmpleados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            GroupBoxVendedor.SuspendLayout();
            TabControlListaVendedores.SuspendLayout();
            TabPageListaVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // BImprimirVendedor
            // 
            BImprimirVendedor.BackColor = Color.SteelBlue;
            BImprimirVendedor.ForeColor = Color.White;
            BImprimirVendedor.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirVendedor.Location = new Point(987, 424);
            BImprimirVendedor.Margin = new Padding(4, 5, 4, 5);
            BImprimirVendedor.Name = "BImprimirVendedor";
            BImprimirVendedor.Size = new Size(67, 69);
            BImprimirVendedor.TabIndex = 22;
            BImprimirVendedor.UseVisualStyleBackColor = false;
            // 
            // GroupBoxVendedor
            // 
            GroupBoxVendedor.BackColor = Color.FloralWhite;
            GroupBoxVendedor.Controls.Add(BBuscarVendedor);
            GroupBoxVendedor.Controls.Add(TBBuscarVendedor);
            GroupBoxVendedor.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxVendedor.ForeColor = Color.DarkOrange;
            GroupBoxVendedor.Location = new Point(235, 45);
            GroupBoxVendedor.Margin = new Padding(4, 5, 4, 5);
            GroupBoxVendedor.Name = "GroupBoxVendedor";
            GroupBoxVendedor.Padding = new Padding(4, 5, 4, 5);
            GroupBoxVendedor.Size = new Size(533, 154);
            GroupBoxVendedor.TabIndex = 20;
            GroupBoxVendedor.TabStop = false;
            GroupBoxVendedor.Text = "Vendedores";
            // 
            // BBuscarVendedor
            // 
            BBuscarVendedor.BackColor = Color.DarkOliveGreen;
            BBuscarVendedor.ForeColor = Color.White;
            BBuscarVendedor.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarVendedor.Location = new Point(365, 66);
            BBuscarVendedor.Margin = new Padding(4, 5, 4, 5);
            BBuscarVendedor.Name = "BBuscarVendedor";
            BBuscarVendedor.Size = new Size(60, 62);
            BBuscarVendedor.TabIndex = 2;
            BBuscarVendedor.UseVisualStyleBackColor = false;
            // 
            // TBBuscarVendedor
            // 
            TBBuscarVendedor.Location = new Point(108, 72);
            TBBuscarVendedor.Margin = new Padding(4, 5, 4, 5);
            TBBuscarVendedor.Name = "TBBuscarVendedor";
            TBBuscarVendedor.Size = new Size(220, 38);
            TBBuscarVendedor.TabIndex = 1;
            TBBuscarVendedor.KeyPress += StrNum_KeyPress;
            // 
            // TabControlListaVendedores
            // 
            TabControlListaVendedores.Controls.Add(TabPageListaVendedores);
            TabControlListaVendedores.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaVendedores.Location = new Point(27, 239);
            TabControlListaVendedores.Margin = new Padding(4, 3, 4, 3);
            TabControlListaVendedores.Name = "TabControlListaVendedores";
            TabControlListaVendedores.SelectedIndex = 0;
            TabControlListaVendedores.Size = new Size(944, 412);
            TabControlListaVendedores.TabIndex = 82;
            // 
            // TabPageListaVendedores
            // 
            TabPageListaVendedores.Controls.Add(dgvEmpleados);
            TabPageListaVendedores.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaVendedores.ForeColor = Color.White;
            TabPageListaVendedores.Location = new Point(4, 28);
            TabPageListaVendedores.Margin = new Padding(4, 3, 4, 3);
            TabPageListaVendedores.Name = "TabPageListaVendedores";
            TabPageListaVendedores.Padding = new Padding(4, 3, 4, 3);
            TabPageListaVendedores.Size = new Size(936, 380);
            TabPageListaVendedores.TabIndex = 0;
            TabPageListaVendedores.Text = "Lista de Vendedores";
            TabPageListaVendedores.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.BackgroundColor = Color.RosyBrown;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 20;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(4, 3);
            dgvEmpleados.Margin = new Padding(5, 6, 5, 6);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.Size = new Size(928, 374);
            dgvEmpleados.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // ListarVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 692);
            Controls.Add(TabControlListaVendedores);
            Controls.Add(BImprimirVendedor);
            Controls.Add(GroupBoxVendedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListarVendedores";
            Text = "Form1";
            GroupBoxVendedor.ResumeLayout(false);
            GroupBoxVendedor.PerformLayout();
            TabControlListaVendedores.ResumeLayout(false);
            TabPageListaVendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        internal Button BImprimirVendedor;
        internal GroupBox GroupBoxVendedor;
        internal Button BBuscarVendedor;
        internal TextBox TBBuscarVendedor;

        #endregion

        internal TabControl TabControlListaVendedores;
        internal TabPage TabPageListaVendedores;
        internal DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}