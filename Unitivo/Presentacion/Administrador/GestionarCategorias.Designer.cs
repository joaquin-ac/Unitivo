namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            GroupBoxGestionCategorias = new GroupBox();
            BBuscarCategoria = new Button();
            TBGestionCategoria = new TextBox();
            BModificarCategoria = new Button();
            BEliminarCategoria = new Button();
            BAltaCategoria = new Button();
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            dgvRegistroCategoria = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            GroupBoxDatosCategoria = new GroupBox();
            TBNombreCategoria = new TextBox();
            LModCategoria = new Label();
            button1 = new Button();
            GroupBoxGestionCategorias.SuspendLayout();
            TabControlRegCategoria.SuspendLayout();
            TabPageListaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).BeginInit();
            GroupBoxDatosCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionCategorias
            // 
            GroupBoxGestionCategorias.BackColor = Color.Cornsilk;
            GroupBoxGestionCategorias.Controls.Add(BBuscarCategoria);
            GroupBoxGestionCategorias.Controls.Add(TBGestionCategoria);
            GroupBoxGestionCategorias.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionCategorias.ForeColor = Color.SaddleBrown;
            GroupBoxGestionCategorias.Location = new Point(309, 30);
            GroupBoxGestionCategorias.Margin = new Padding(4, 5, 4, 5);
            GroupBoxGestionCategorias.Name = "GroupBoxGestionCategorias";
            GroupBoxGestionCategorias.Padding = new Padding(4, 5, 4, 5);
            GroupBoxGestionCategorias.Size = new Size(425, 152);
            GroupBoxGestionCategorias.TabIndex = 27;
            GroupBoxGestionCategorias.TabStop = false;
            GroupBoxGestionCategorias.Text = "Gestión de Categorias";
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
            BBuscarCategoria.Location = new Point(285, 60);
            BBuscarCategoria.Margin = new Padding(4, 5, 4, 5);
            BBuscarCategoria.Name = "BBuscarCategoria";
            BBuscarCategoria.Size = new Size(65, 63);
            BBuscarCategoria.TabIndex = 14;
            BBuscarCategoria.UseVisualStyleBackColor = false;
            // 
            // TBGestionCategoria
            // 
            TBGestionCategoria.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionCategoria.Location = new Point(65, 75);
            TBGestionCategoria.Margin = new Padding(4, 5, 4, 5);
            TBGestionCategoria.Name = "TBGestionCategoria";
            TBGestionCategoria.Size = new Size(196, 30);
            TBGestionCategoria.TabIndex = 6;
            TBGestionCategoria.KeyPress += String_KeyPress;
            // 
            // BModificarCategoria
            // 
            BModificarCategoria.BackColor = Color.SteelBlue;
            BModificarCategoria.FlatAppearance.BorderColor = Color.White;
            BModificarCategoria.FlatAppearance.BorderSize = 2;
            BModificarCategoria.FlatStyle = FlatStyle.Flat;
            BModificarCategoria.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarCategoria.ForeColor = Color.White;
            BModificarCategoria.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarCategoria.Location = new Point(955, 280);
            BModificarCategoria.Margin = new Padding(4, 5, 4, 5);
            BModificarCategoria.Name = "BModificarCategoria";
            BModificarCategoria.Size = new Size(67, 69);
            BModificarCategoria.TabIndex = 25;
            BModificarCategoria.UseVisualStyleBackColor = false;
            // BEliminarCategoria
            // 
            BEliminarCategoria.BackColor = Color.Brown;
            BEliminarCategoria.FlatAppearance.BorderSize = 2;
            BEliminarCategoria.FlatStyle = FlatStyle.Flat;
            BEliminarCategoria.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarCategoria.ForeColor = Color.White;
            BEliminarCategoria.Image = Properties.Resources.icons8_basura_26;
            BEliminarCategoria.Location = new Point(955, 397);
            BEliminarCategoria.Margin = new Padding(4, 5, 4, 5);
            BEliminarCategoria.Name = "BEliminarCategoria";
            BEliminarCategoria.Size = new Size(67, 69);
            BEliminarCategoria.TabIndex = 24;
            BEliminarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarCategoria.UseVisualStyleBackColor = false;
            BEliminarCategoria.Click += BEliminarCategoria_Click;
            // 
            // BAltaCategoria
            // 
            BAltaCategoria.BackColor = Color.DarkOliveGreen;
            BAltaCategoria.ForeColor = Color.White;
            BAltaCategoria.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaCategoria.Location = new Point(955, 397);
            BAltaCategoria.Margin = new Padding(4, 5, 4, 5);
            BAltaCategoria.Name = "BAltaCategoria";
            BAltaCategoria.Size = new Size(67, 69);
            BAltaCategoria.TabIndex = 87;
            BAltaCategoria.UseVisualStyleBackColor = false;
            // 
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegCategoria.Location = new Point(63, 218);
            TabControlRegCategoria.Margin = new Padding(2, 3, 2, 3);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(838, 288);
            TabControlRegCategoria.TabIndex = 88;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(dgvRegistroCategoria);
            TabPageListaCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 29);
            TabPageListaCategoria.Margin = new Padding(2, 3, 2, 3);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2, 3, 2, 3);
            TabPageListaCategoria.Size = new Size(830, 255);
            TabPageListaCategoria.TabIndex = 0;
            TabPageListaCategoria.Text = "Lista de Categorias";
            TabPageListaCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroCategoria
            // 
            dgvRegistroCategoria.AllowUserToAddRows = false;
            dgvRegistroCategoria.AllowUserToDeleteRows = false;
            dgvRegistroCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroCategoria.BackgroundColor = Color.RosyBrown;
            dgvRegistroCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistroCategoria.ColumnHeadersHeight = 20;
            dgvRegistroCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroCategoria.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvRegistroCategoria.Dock = DockStyle.Fill;
            dgvRegistroCategoria.EnableHeadersVisualStyles = false;
            dgvRegistroCategoria.Location = new Point(2, 3);
            dgvRegistroCategoria.Margin = new Padding(2, 3, 2, 3);
            dgvRegistroCategoria.Name = "dgvRegistroCategoria";
            dgvRegistroCategoria.ReadOnly = true;
            dgvRegistroCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRegistroCategoria.RowHeadersWidth = 51;
            dgvRegistroCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroCategoria.RowTemplate.Height = 24;
            dgvRegistroCategoria.Size = new Size(826, 249);
            dgvRegistroCategoria.TabIndex = 0;
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
            Column2.HeaderText = "Descripcion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // GroupBoxDatosCategoria
            // 
            GroupBoxDatosCategoria.BackColor = Color.RosyBrown;
            GroupBoxDatosCategoria.Controls.Add(TBNombreCategoria);
            GroupBoxDatosCategoria.Controls.Add(button1);
            GroupBoxDatosCategoria.Controls.Add(LModCategoria);
            GroupBoxDatosCategoria.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCategoria.ForeColor = Color.White;
            GroupBoxDatosCategoria.Location = new Point(173, 585);
            GroupBoxDatosCategoria.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCategoria.Name = "GroupBoxDatosCategoria";
            GroupBoxDatosCategoria.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCategoria.Size = new Size(656, 203);
            GroupBoxDatosCategoria.TabIndex = 19;
            GroupBoxDatosCategoria.TabStop = false;
            GroupBoxDatosCategoria.Text = "Modificar Categoria";
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Location = new Point(136, 116);
            TBNombreCategoria.Margin = new Padding(4, 5, 4, 5);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(221, 38);
            TBNombreCategoria.TabIndex = 16;
            // 
            // LModCategoria
            // 
            LModCategoria.AutoSize = true;
            LModCategoria.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModCategoria.ForeColor = Color.White;
            LModCategoria.Location = new Point(133, 73);
            LModCategoria.Margin = new Padding(8, 0, 8, 0);
            LModCategoria.Name = "LModCategoria";
            LModCategoria.Size = new Size(160, 27);
            LModCategoria.TabIndex = 15;
            LModCategoria.Text = "Descripción : ";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(452, 111);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 13;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // GestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 846);
            Controls.Add(GroupBoxDatosCategoria);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(GroupBoxGestionCategorias);
            Controls.Add(BModificarCategoria);
            Controls.Add(BEliminarCategoria);
            Controls.Add(BAltaCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarCategorias";
            Text = "Form1";
            GroupBoxGestionCategorias.ResumeLayout(false);
            GroupBoxGestionCategorias.PerformLayout();
            TabControlRegCategoria.ResumeLayout(false);
            TabPageListaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).EndInit();
            GroupBoxDatosCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionCategorias;
        internal Button BBuscarCategoria;
        internal TextBox TBGestionCategoria;
        internal Button BModificarCategoria;
        internal Button BEliminarCategoria;
        internal Button BAltaCategoria;

        #endregion

        internal TabControl TabControlRegCategoria;
        internal TabPage TabPageListaCategoria;
        internal DataGridView dgvRegistroCategoria;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        internal GroupBox GroupBoxDatosCategoria;
        internal TextBox TBNombreCategoria;
        internal Button button1;
        internal Label LModCategoria;
    }
}