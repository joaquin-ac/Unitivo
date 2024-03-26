namespace Unitivo.Presentacion.Vendedor
{
    partial class AñadirCliente
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
            Panel1 = new Panel();
            BRegistrarCliente = new Button();
            TBCorreoCliente = new TextBox();
            Label7 = new Label();
            TBDireccionCliente = new TextBox();
            Label6 = new Label();
            TBTelCliente = new TextBox();
            Label5 = new Label();
            TBDniCliente = new TextBox();
            Label4 = new Label();
            TBApellidoCliente = new TextBox();
            Label3 = new Label();
            TBNombreCliente = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            TabControlListaClientes = new TabControl();
            TabPageListaCliente = new TabPage();
            DataGridViewListarClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Panel1.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BRegistrarCliente);
            Panel1.Controls.Add(TBCorreoCliente);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccionCliente);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelCliente);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniCliente);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoCliente);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreCliente);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(60, 120);
            Panel1.Margin = new Padding(4, 5, 4, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(431, 522);
            Panel1.TabIndex = 0;
            // 
            // BRegistrarCliente
            // 
            BRegistrarCliente.BackColor = Color.DarkOliveGreen;
            BRegistrarCliente.FlatAppearance.BorderSize = 2;
            BRegistrarCliente.FlatStyle = FlatStyle.Flat;
            BRegistrarCliente.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BRegistrarCliente.ForeColor = Color.Cornsilk;
            BRegistrarCliente.Location = new Point(123, 400);
            BRegistrarCliente.Margin = new Padding(4, 5, 4, 5);
            BRegistrarCliente.Name = "BRegistrarCliente";
            BRegistrarCliente.Size = new Size(163, 59);
            BRegistrarCliente.TabIndex = 17;
            BRegistrarCliente.Text = "Añadir";
            BRegistrarCliente.UseVisualStyleBackColor = false;
            BRegistrarCliente.Click += BRegistrarCliente_Click;
            // 
            // TBCorreoCliente
            // 
            TBCorreoCliente.Location = new Point(213, 321);
            TBCorreoCliente.Margin = new Padding(4, 5, 4, 5);
            TBCorreoCliente.Name = "TBCorreoCliente";
            TBCorreoCliente.Size = new Size(169, 27);
            TBCorreoCliente.TabIndex = 16;
            TBCorreoCliente.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(47, 318);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(102, 29);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionCliente
            // 
            TBDireccionCliente.Location = new Point(213, 265);
            TBDireccionCliente.Name = "TBDireccionCliente";
            TBDireccionCliente.Size = new Size(169, 27);
            TBDireccionCliente.TabIndex = 18;
            TBDireccionCliente.KeyPress += NumStr_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(47, 261);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(138, 29);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelCliente
            // 
            TBTelCliente.Location = new Point(213, 209);
            TBTelCliente.Margin = new Padding(4, 5, 4, 5);
            TBTelCliente.Name = "TBTelCliente";
            TBTelCliente.Size = new Size(169, 27);
            TBTelCliente.TabIndex = 12;
            TBTelCliente.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(47, 205);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(132, 29);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniCliente
            // 
            TBDniCliente.Location = new Point(213, 151);
            TBDniCliente.Margin = new Padding(4, 5, 4, 5);
            TBDniCliente.Name = "TBDniCliente";
            TBDniCliente.Size = new Size(169, 27);
            TBDniCliente.TabIndex = 10;
            TBDniCliente.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(47, 146);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(71, 29);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.Location = new Point(213, 91);
            TBApellidoCliente.Margin = new Padding(4, 5, 4, 5);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(169, 27);
            TBApellidoCliente.TabIndex = 8;
            TBApellidoCliente.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(47, 86);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(124, 29);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(213, 31);
            TBNombreCliente.Margin = new Padding(4, 5, 4, 5);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(169, 27);
            TBNombreCliente.TabIndex = 6;
            TBNombreCliente.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(47, 26);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(121, 29);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(70, 38);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(405, 50);
            Label1.TabIndex = 1;
            Label1.Text = "Registrar Cliente";
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(561, 120);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(481, 522);
            TabControlListaClientes.TabIndex = 70;
            // 
            // TabPageListaCliente
            // 
            TabPageListaCliente.Controls.Add(DataGridViewListarClientes);
            TabPageListaCliente.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCliente.ForeColor = Color.White;
            TabPageListaCliente.Location = new Point(4, 28);
            TabPageListaCliente.Name = "TabPageListaCliente";
            TabPageListaCliente.Padding = new Padding(3);
            TabPageListaCliente.Size = new Size(473, 490);
            TabPageListaCliente.TabIndex = 0;
            TabPageListaCliente.Text = "Lista de Clientes";
            TabPageListaCliente.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarClientes
            // 
            DataGridViewListarClientes.AllowUserToAddRows = false;
            DataGridViewListarClientes.AllowUserToDeleteRows = false;
            DataGridViewListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewListarClientes.BorderStyle = BorderStyle.None;
            DataGridViewListarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarClientes.ColumnHeadersHeight = 20;
            DataGridViewListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridViewListarClientes.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 3);
            DataGridViewListarClientes.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.Size = new Size(467, 484);
            DataGridViewListarClientes.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 52;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 93;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 95;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 62;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 99;
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 107;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 78;
            // 
            // AñadirCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 692);
            Controls.Add(TabControlListaClientes);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirCliente";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal Label Label1;
        internal TextBox TBCorreoCliente;
        internal Label Label7;
        internal TextBox TBDireccionCliente;
        internal Label Label6;
        internal TextBox TBTelCliente;
        internal Label Label5;
        internal TextBox TBDniCliente;
        internal Label Label4;
        internal TextBox TBApellidoCliente;
        internal Label Label3;
        internal TextBox TBNombreCliente;

        internal TextBox TBDireccion;
        internal Label Label2;
        internal Button BRegistrarCliente;

        #endregion

        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaCliente;
        internal DataGridView DataGridViewListarClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}