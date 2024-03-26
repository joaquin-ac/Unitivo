namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarUsuarios
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
            BModificarUsuario = new Button();
            BEliminarUsuario = new Button();
            GroupBoxGestionUsuarios = new GroupBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            TabControlRegUsuarios = new TabControl();
            TabPageListaUsuarios = new TabPage();
            dgvListaUsuarios = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            GroupBoxDatosCliente = new GroupBox();
            button1 = new Button();
            ComboBoxPerfil = new ComboBox();
            LDni = new Label();
            TBContraseñaUsuario = new TextBox();
            TBNombreUsuario = new TextBox();
            LNombreCliente = new Label();
            LApellidoCliente = new Label();
            GroupBoxGestionUsuarios.SuspendLayout();
            TabControlRegUsuarios.SuspendLayout();
            TabPageListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            GroupBoxDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // BModificarUsuario
            // 
            BModificarUsuario.BackColor = Color.SteelBlue;
            BModificarUsuario.ForeColor = Color.White;
            BModificarUsuario.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarUsuario.Location = new Point(959, 282);
            BModificarUsuario.Margin = new Padding(4, 5, 4, 5);
            BModificarUsuario.Name = "BModificarUsuario";
            BModificarUsuario.Size = new Size(67, 69);
            BModificarUsuario.TabIndex = 71;
            BModificarUsuario.UseVisualStyleBackColor = false;
            // 
            // BEliminarUsuario
            // 
            BEliminarUsuario.BackColor = Color.Brown;
            BEliminarUsuario.ForeColor = Color.White;
            BEliminarUsuario.Image = Properties.Resources.icons8_basura_26;
            BEliminarUsuario.Location = new Point(959, 376);
            BEliminarUsuario.Margin = new Padding(4, 5, 4, 5);
            BEliminarUsuario.Name = "BEliminarUsuario";
            BEliminarUsuario.Size = new Size(67, 69);
            BEliminarUsuario.TabIndex = 70;
            BEliminarUsuario.UseVisualStyleBackColor = false;
            BEliminarUsuario.Click += BEliminarUsuario_Click;
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(341, 24);
            GroupBoxGestionUsuarios.Margin = new Padding(4, 5, 4, 5);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Padding = new Padding(4, 5, 4, 5);
            GroupBoxGestionUsuarios.Size = new Size(348, 117);
            GroupBoxGestionUsuarios.TabIndex = 73;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Usuarios";
            // 
            // BBuscarUsuario
            // 
            BBuscarUsuario.BackColor = Color.DarkOliveGreen;
            BBuscarUsuario.FlatAppearance.BorderColor = Color.White;
            BBuscarUsuario.FlatAppearance.BorderSize = 2;
            BBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BBuscarUsuario.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarUsuario.ForeColor = Color.White;
            BBuscarUsuario.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarUsuario.Location = new Point(248, 40);
            BBuscarUsuario.Margin = new Padding(4, 5, 4, 5);
            BBuscarUsuario.Name = "BBuscarUsuario";
            BBuscarUsuario.Size = new Size(60, 63);
            BBuscarUsuario.TabIndex = 14;
            BBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TBGestionUsuario
            // 
            TBGestionUsuario.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionUsuario.Location = new Point(41, 54);
            TBGestionUsuario.Margin = new Padding(4, 5, 4, 5);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(173, 30);
            TBGestionUsuario.TabIndex = 6;
            TBGestionUsuario.KeyPress += String_KeyPress;
            // 
            // TabControlRegUsuarios
            // 
            TabControlRegUsuarios.Controls.Add(TabPageListaUsuarios);
            TabControlRegUsuarios.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegUsuarios.Location = new Point(64, 182);
            TabControlRegUsuarios.Name = "TabControlRegUsuarios";
            TabControlRegUsuarios.SelectedIndex = 0;
            TabControlRegUsuarios.Size = new Size(844, 323);
            TabControlRegUsuarios.TabIndex = 75;
            // 
            // TabPageListaUsuarios
            // 
            TabPageListaUsuarios.Controls.Add(dgvListaUsuarios);
            TabPageListaUsuarios.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaUsuarios.ForeColor = Color.White;
            TabPageListaUsuarios.Location = new Point(4, 28);
            TabPageListaUsuarios.Name = "TabPageListaUsuarios";
            TabPageListaUsuarios.Padding = new Padding(3);
            TabPageListaUsuarios.Size = new Size(836, 291);
            TabPageListaUsuarios.TabIndex = 0;
            TabPageListaUsuarios.Text = "Lista de Usuarios";
            TabPageListaUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.BackgroundColor = Color.RosyBrown;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaUsuarios.ColumnHeadersHeight = 20;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column11, Column12, Column13, Column14, Column15 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaUsuarios.Dock = DockStyle.Fill;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;
            dgvListaUsuarios.Location = new Point(3, 3);
            dgvListaUsuarios.Margin = new Padding(4, 5, 4, 5);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaUsuarios.RowHeadersWidth = 51;
            dgvListaUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaUsuarios.Size = new Size(830, 285);
            dgvListaUsuarios.TabIndex = 2;
            // 
            // Column8
            // 
            Column8.HeaderText = "ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Nombre";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Estado";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "FechaModificacion";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "FechaCreacion";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Perfil";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.HeaderText = "Empleado";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.BackColor = Color.RosyBrown;
            GroupBoxDatosCliente.Controls.Add(button1);
            GroupBoxDatosCliente.Controls.Add(ComboBoxPerfil);
            GroupBoxDatosCliente.Controls.Add(LDni);
            GroupBoxDatosCliente.Controls.Add(TBContraseñaUsuario);
            GroupBoxDatosCliente.Controls.Add(TBNombreUsuario);
            GroupBoxDatosCliente.Controls.Add(LNombreCliente);
            GroupBoxDatosCliente.Controls.Add(LApellidoCliente);
            GroupBoxDatosCliente.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(172, 575);
            GroupBoxDatosCliente.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Size = new Size(668, 291);
            GroupBoxDatosCliente.TabIndex = 76;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(408, 190);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(143, 52);
            button1.TabIndex = 21;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Items.AddRange(new object[] { "Vendedor", "Gerente" });
            ComboBoxPerfil.Location = new Point(366, 97);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(213, 45);
            ComboBoxPerfil.TabIndex = 20;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(363, 68);
            LDni.Margin = new Padding(5, 0, 5, 0);
            LDni.Name = "LDni";
            LDni.Size = new Size(58, 22);
            LDni.TabIndex = 19;
            LDni.Text = "Perfil";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(92, 197);
            TBContraseñaUsuario.Margin = new Padding(5, 6, 5, 6);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(213, 45);
            TBContraseñaUsuario.TabIndex = 8;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(92, 98);
            TBNombreUsuario.Margin = new Padding(5, 6, 5, 6);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(213, 45);
            TBNombreUsuario.TabIndex = 6;
            // 
            // LNombreCliente
            // 
            LNombreCliente.AutoSize = true;
            LNombreCliente.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCliente.ForeColor = Color.White;
            LNombreCliente.Location = new Point(89, 66);
            LNombreCliente.Margin = new Padding(5, 0, 5, 0);
            LNombreCliente.Name = "LNombreCliente";
            LNombreCliente.Size = new Size(85, 22);
            LNombreCliente.TabIndex = 0;
            LNombreCliente.Text = "Nombre:";
            // 
            // LApellidoCliente
            // 
            LApellidoCliente.AutoSize = true;
            LApellidoCliente.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellidoCliente.ForeColor = Color.White;
            LApellidoCliente.Location = new Point(89, 167);
            LApellidoCliente.Margin = new Padding(5, 0, 5, 0);
            LApellidoCliente.Name = "LApellidoCliente";
            LApellidoCliente.Size = new Size(118, 22);
            LApellidoCliente.TabIndex = 4;
            LApellidoCliente.Text = "Contraseña:";
            // 
            // GestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 908);
            Controls.Add(GroupBoxDatosCliente);
            Controls.Add(TabControlRegUsuarios);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(BModificarUsuario);
            Controls.Add(BEliminarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarUsuarios";
            Text = "Form1";
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabControlRegUsuarios.ResumeLayout(false);
            TabPageListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            GroupBoxDatosCliente.ResumeLayout(false);
            GroupBoxDatosCliente.PerformLayout();
            ResumeLayout(false);
        }

        internal Button BModificarUsuario;
        internal Button BEliminarUsuario;
        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;

        #endregion

        internal TabControl TabControlRegUsuarios;
        internal TabPage TabPageListaUsuarios;
        internal DataGridView dgvListaUsuarios;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        internal GroupBox GroupBoxDatosCliente;
        internal ComboBox ComboBoxPerfil;
        internal Label LDni;
        internal TextBox TBContraseñaUsuario;
        internal TextBox TBNombreUsuario;
        internal Label LNombreCliente;
        internal Label LApellidoCliente;
        internal Button button1;
    }
}