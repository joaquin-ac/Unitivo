namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarPuestos
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
            GroupBoxGestionPerfil = new GroupBox();
            BBuscarPerfil = new Button();
            TBGestionPerfil = new TextBox();
            BModificarPerfiles = new Button();
            BEliminarPerfiles = new Button();
            BAltaPerfil = new Button();
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            DataGridViewListarPerfiles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            DataGridViewListarPerfilesDesactivados = new DataGridView();
            GroupBoxDatosPerfil = new GroupBox();
            BModEmpleado = new Button();
            TBModPerfil = new TextBox();
            LModPerfil = new Label();
            DID = new DataGridViewTextBoxColumn();
            DDescripcion = new DataGridViewTextBoxColumn();
            DEstado = new DataGridViewTextBoxColumn();
            GroupBoxGestionPerfil.SuspendLayout();
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfilesDesactivados).BeginInit();
            GroupBoxDatosPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionPerfil
            // 
            GroupBoxGestionPerfil.BackColor = Color.Cornsilk;
            GroupBoxGestionPerfil.Controls.Add(BBuscarPerfil);
            GroupBoxGestionPerfil.Controls.Add(TBGestionPerfil);
            GroupBoxGestionPerfil.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionPerfil.ForeColor = Color.Sienna;
            GroupBoxGestionPerfil.Location = new Point(292, 26);
            GroupBoxGestionPerfil.Margin = new Padding(4);
            GroupBoxGestionPerfil.Name = "GroupBoxGestionPerfil";
            GroupBoxGestionPerfil.Padding = new Padding(4);
            GroupBoxGestionPerfil.Size = new Size(356, 95);
            GroupBoxGestionPerfil.TabIndex = 84;
            GroupBoxGestionPerfil.TabStop = false;
            GroupBoxGestionPerfil.Text = "Gestión de Puestos";
            // 
            // BBuscarPerfil
            // 
            BBuscarPerfil.BackColor = Color.DarkOliveGreen;
            BBuscarPerfil.FlatAppearance.BorderColor = Color.White;
            BBuscarPerfil.FlatAppearance.BorderSize = 2;
            BBuscarPerfil.FlatStyle = FlatStyle.Flat;
            BBuscarPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarPerfil.ForeColor = Color.White;
            BBuscarPerfil.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarPerfil.Location = new Point(253, 36);
            BBuscarPerfil.Margin = new Padding(4);
            BBuscarPerfil.Name = "BBuscarPerfil";
            BBuscarPerfil.Size = new Size(52, 42);
            BBuscarPerfil.TabIndex = 14;
            BBuscarPerfil.UseVisualStyleBackColor = false;
            BBuscarPerfil.Click += BBuscarPerfil_Click;
            // 
            // TBGestionPerfil
            // 
            TBGestionPerfil.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionPerfil.Location = new Point(66, 46);
            TBGestionPerfil.Margin = new Padding(4);
            TBGestionPerfil.Name = "TBGestionPerfil";
            TBGestionPerfil.Size = new Size(152, 26);
            TBGestionPerfil.TabIndex = 6;
            TBGestionPerfil.KeyPress += String_KeyPress;
            // 
            // BModificarPerfiles
            // 
            BModificarPerfiles.BackColor = Color.SteelBlue;
            BModificarPerfiles.ForeColor = Color.White;
            BModificarPerfiles.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarPerfiles.Location = new Point(835, 253);
            BModificarPerfiles.Margin = new Padding(4);
            BModificarPerfiles.Name = "BModificarPerfiles";
            BModificarPerfiles.Size = new Size(59, 52);
            BModificarPerfiles.TabIndex = 82;
            BModificarPerfiles.UseVisualStyleBackColor = false;
            BModificarPerfiles.Click += BModificarPerfiles_Click;
            // 
            // BEliminarPerfiles
            // 
            BEliminarPerfiles.BackColor = Color.Brown;
            BEliminarPerfiles.ForeColor = Color.White;
            BEliminarPerfiles.Image = Properties.Resources.icons8_basura_26;
            BEliminarPerfiles.Location = new Point(835, 323);
            BEliminarPerfiles.Margin = new Padding(4);
            BEliminarPerfiles.Name = "BEliminarPerfiles";
            BEliminarPerfiles.Size = new Size(59, 52);
            BEliminarPerfiles.TabIndex = 81;
            BEliminarPerfiles.UseVisualStyleBackColor = false;
            BEliminarPerfiles.Click += BEliminarPerfiles_Click;
            // 
            // BAltaPerfil
            // 
            BAltaPerfil.BackColor = Color.DarkOliveGreen;
            BAltaPerfil.ForeColor = Color.White;
            BAltaPerfil.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaPerfil.Location = new Point(835, 323);
            BAltaPerfil.Margin = new Padding(4);
            BAltaPerfil.Name = "BAltaPerfil";
            BAltaPerfil.Size = new Size(59, 52);
            BAltaPerfil.TabIndex = 86;
            BAltaPerfil.UseVisualStyleBackColor = false;
            // 
            // TabControlRegPerfil
            // 
            TabControlRegPerfil.Controls.Add(TabPageListaPerfil);
            TabControlRegPerfil.Controls.Add(tabPage1);
            TabControlRegPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegPerfil.Location = new Point(63, 176);
            TabControlRegPerfil.Margin = new Padding(3, 2, 3, 2);
            TabControlRegPerfil.Name = "TabControlRegPerfil";
            TabControlRegPerfil.SelectedIndex = 0;
            TabControlRegPerfil.Size = new Size(729, 238);
            TabControlRegPerfil.TabIndex = 87;
            TabControlRegPerfil.UseWaitCursor = true;
            // 
            // TabPageListaPerfil
            // 
            TabPageListaPerfil.Controls.Add(DataGridViewListarPerfiles);
            TabPageListaPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 26);
            TabPageListaPerfil.Margin = new Padding(3, 2, 3, 2);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(3, 2, 3, 2);
            TabPageListaPerfil.Size = new Size(721, 208);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Puestos";
            TabPageListaPerfil.UseVisualStyleBackColor = true;
            TabPageListaPerfil.UseWaitCursor = true;
            // 
            // DataGridViewListarPerfiles
            // 
            DataGridViewListarPerfiles.AllowUserToAddRows = false;
            DataGridViewListarPerfiles.AllowUserToDeleteRows = false;
            DataGridViewListarPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarPerfiles.BackgroundColor = Color.RosyBrown;
            DataGridViewListarPerfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarPerfiles.ColumnHeadersHeight = 20;
            DataGridViewListarPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarPerfiles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            DataGridViewListarPerfiles.Dock = DockStyle.Fill;
            DataGridViewListarPerfiles.EnableHeadersVisualStyles = false;
            DataGridViewListarPerfiles.Location = new Point(3, 2);
            DataGridViewListarPerfiles.Margin = new Padding(3, 2, 3, 2);
            DataGridViewListarPerfiles.Name = "DataGridViewListarPerfiles";
            DataGridViewListarPerfiles.ReadOnly = true;
            DataGridViewListarPerfiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarPerfiles.RowHeadersWidth = 51;
            DataGridViewListarPerfiles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarPerfiles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarPerfiles.RowTemplate.Height = 24;
            DataGridViewListarPerfiles.Size = new Size(715, 204);
            DataGridViewListarPerfiles.TabIndex = 0;
            DataGridViewListarPerfiles.UseWaitCursor = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DataGridViewListarPerfilesDesactivados);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(721, 208);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Puestos Desactivados";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.UseWaitCursor = true;
            // 
            // DataGridViewListarPerfilesDesactivados
            // 
            DataGridViewListarPerfilesDesactivados.AllowUserToAddRows = false;
            DataGridViewListarPerfilesDesactivados.AllowUserToDeleteRows = false;
            DataGridViewListarPerfilesDesactivados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarPerfilesDesactivados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarPerfilesDesactivados.BackgroundColor = Color.RosyBrown;
            DataGridViewListarPerfilesDesactivados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfilesDesactivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarPerfilesDesactivados.ColumnHeadersHeight = 20;
            DataGridViewListarPerfilesDesactivados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarPerfilesDesactivados.Columns.AddRange(new DataGridViewColumn[] { DID, DDescripcion, DEstado });
            DataGridViewListarPerfilesDesactivados.Dock = DockStyle.Fill;
            DataGridViewListarPerfilesDesactivados.EnableHeadersVisualStyles = false;
            DataGridViewListarPerfilesDesactivados.Location = new Point(3, 3);
            DataGridViewListarPerfilesDesactivados.Margin = new Padding(3, 2, 3, 2);
            DataGridViewListarPerfilesDesactivados.Name = "DataGridViewListarPerfilesDesactivados";
            DataGridViewListarPerfilesDesactivados.ReadOnly = true;
            DataGridViewListarPerfilesDesactivados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfilesDesactivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewListarPerfilesDesactivados.RowHeadersWidth = 51;
            DataGridViewListarPerfilesDesactivados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarPerfilesDesactivados.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarPerfilesDesactivados.RowTemplate.Height = 24;
            DataGridViewListarPerfilesDesactivados.Size = new Size(715, 202);
            DataGridViewListarPerfilesDesactivados.TabIndex = 1;
            DataGridViewListarPerfilesDesactivados.UseWaitCursor = true;
            DataGridViewListarPerfilesDesactivados.CellContentClick += DataGridViewListarPerfilesDesactivados_CellContentClick;
            // 
            // GroupBoxDatosPerfil
            // 
            GroupBoxDatosPerfil.BackColor = Color.RosyBrown;
            GroupBoxDatosPerfil.Controls.Add(BModEmpleado);
            GroupBoxDatosPerfil.Controls.Add(TBModPerfil);
            GroupBoxDatosPerfil.Controls.Add(LModPerfil);
            GroupBoxDatosPerfil.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosPerfil.ForeColor = Color.White;
            GroupBoxDatosPerfil.Location = new Point(225, 477);
            GroupBoxDatosPerfil.Margin = new Padding(4);
            GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil";
            GroupBoxDatosPerfil.Padding = new Padding(4);
            GroupBoxDatosPerfil.Size = new Size(457, 155);
            GroupBoxDatosPerfil.TabIndex = 88;
            GroupBoxDatosPerfil.TabStop = false;
            GroupBoxDatosPerfil.Text = "Modificar Puesto";
            // 
            // BModEmpleado
            // 
            BModEmpleado.BackColor = Color.DarkOliveGreen;
            BModEmpleado.FlatAppearance.BorderSize = 2;
            BModEmpleado.FlatStyle = FlatStyle.Flat;
            BModEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BModEmpleado.ForeColor = Color.White;
            BModEmpleado.Location = new Point(281, 76);
            BModEmpleado.Margin = new Padding(4);
            BModEmpleado.Name = "BModEmpleado";
            BModEmpleado.Size = new Size(145, 44);
            BModEmpleado.TabIndex = 18;
            BModEmpleado.Text = "Modificar";
            BModEmpleado.UseVisualStyleBackColor = false;
            BModEmpleado.Click += BModEmpleado_Click;
            // 
            // TBModPerfil
            // 
            TBModPerfil.Location = new Point(56, 82);
            TBModPerfil.Margin = new Padding(4);
            TBModPerfil.Name = "TBModPerfil";
            TBModPerfil.Size = new Size(194, 35);
            TBModPerfil.TabIndex = 16;
            // 
            // LModPerfil
            // 
            LModPerfil.AutoSize = true;
            LModPerfil.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModPerfil.ForeColor = Color.White;
            LModPerfil.Location = new Point(53, 50);
            LModPerfil.Margin = new Padding(7, 0, 7, 0);
            LModPerfil.Name = "LModPerfil";
            LModPerfil.Size = new Size(78, 24);
            LModPerfil.TabIndex = 15;
            LModPerfil.Text = "Puesto: ";
            // 
            // DID
            // 
            DID.HeaderText = "ID";
            DID.MinimumWidth = 6;
            DID.Name = "DID";
            DID.ReadOnly = true;
            // 
            // DDescripcion
            // 
            DDescripcion.HeaderText = "Descripcion";
            DDescripcion.MinimumWidth = 6;
            DDescripcion.Name = "DDescripcion";
            DDescripcion.ReadOnly = true;
            // 
            // DEstado
            // 
            DEstado.HeaderText = "Estado";
            DEstado.MinimumWidth = 6;
            DEstado.Name = "DEstado";
            DEstado.ReadOnly = true;
            // 
            // GestionarPuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 681);
            Controls.Add(GroupBoxDatosPerfil);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(GroupBoxGestionPerfil);
            Controls.Add(BModificarPerfiles);
            Controls.Add(BEliminarPerfiles);
            Controls.Add(BAltaPerfil);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GestionarPuestos";
            Text = "Form1";
            Load += GestionarPuestos_Load;
            GroupBoxGestionPerfil.ResumeLayout(false);
            GroupBoxGestionPerfil.PerformLayout();
            TabControlRegPerfil.ResumeLayout(false);
            TabPageListaPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfilesDesactivados).EndInit();
            GroupBoxDatosPerfil.ResumeLayout(false);
            GroupBoxDatosPerfil.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionPerfil;
        internal Button BBuscarPerfil;
        internal TextBox TBGestionPerfil;
        internal Button BModificarPerfiles;
        internal Button BEliminarPerfiles;
        internal Button BAltaPerfil;

        #endregion

        internal TabControl TabControlRegPerfil;
        internal TabPage TabPageListaPerfil;
        internal DataGridView DataGridViewListarPerfiles;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        internal GroupBox GroupBoxDatosPerfil;
        internal TextBox TBModPerfil;
        internal Label LModPerfil;
        internal Button BModEmpleado;
        private TabPage tabPage1;
        internal DataGridView DataGridViewListarPerfilesDesactivados;
        private DataGridViewTextBoxColumn DID;
        private DataGridViewTextBoxColumn DDescripcion;
        private DataGridViewTextBoxColumn DEstado;
    }
}