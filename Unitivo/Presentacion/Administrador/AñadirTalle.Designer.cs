namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirTalle
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
            TabControlRegTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            DataGridViewListarTalles = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            PanelRegTalles = new Panel();
            BRegistrarTalle = new Button();
            TBNombreTalle = new TextBox();
            LNombreTalle = new Label();
            TabControlRegTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarTalles).BeginInit();
            PanelRegTalles.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegTalles
            // 
            TabControlRegTalles.Controls.Add(TabPageListaTalles);
            TabControlRegTalles.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegTalles.Location = new Point(177, 254);
            TabControlRegTalles.Name = "TabControlRegTalles";
            TabControlRegTalles.SelectedIndex = 0;
            TabControlRegTalles.Size = new Size(713, 372);
            TabControlRegTalles.TabIndex = 40;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(DataGridViewListarTalles);
            TabPageListaTalles.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 28);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(3);
            TabPageListaTalles.Size = new Size(705, 340);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarTalles
            // 
            DataGridViewListarTalles.AllowUserToAddRows = false;
            DataGridViewListarTalles.AllowUserToDeleteRows = false;
            DataGridViewListarTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarTalles.BackgroundColor = Color.RosyBrown;
            DataGridViewListarTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarTalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarTalles.ColumnHeadersHeight = 20;
            DataGridViewListarTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarTalles.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            DataGridViewListarTalles.Dock = DockStyle.Fill;
            DataGridViewListarTalles.EnableHeadersVisualStyles = false;
            DataGridViewListarTalles.Location = new Point(3, 3);
            DataGridViewListarTalles.Name = "DataGridViewListarTalles";
            DataGridViewListarTalles.ReadOnly = true;
            DataGridViewListarTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListarTalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarTalles.RowHeadersWidth = 51;
            DataGridViewListarTalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarTalles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarTalles.RowTemplate.Height = 24;
            DataGridViewListarTalles.Size = new Size(699, 334);
            DataGridViewListarTalles.TabIndex = 0;
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
            // PanelRegTalles
            // 
            PanelRegTalles.BackColor = Color.Cornsilk;
            PanelRegTalles.BackgroundImageLayout = ImageLayout.None;
            PanelRegTalles.Controls.Add(BRegistrarTalle);
            PanelRegTalles.Controls.Add(TBNombreTalle);
            PanelRegTalles.Controls.Add(LNombreTalle);
            PanelRegTalles.Location = new Point(256, 37);
            PanelRegTalles.Margin = new Padding(4, 5, 4, 5);
            PanelRegTalles.Name = "PanelRegTalles";
            PanelRegTalles.Size = new Size(577, 172);
            PanelRegTalles.TabIndex = 39;
            // 
            // BRegistrarTalle
            // 
            BRegistrarTalle.BackColor = Color.DarkOliveGreen;
            BRegistrarTalle.FlatAppearance.BorderColor = Color.White;
            BRegistrarTalle.FlatAppearance.BorderSize = 2;
            BRegistrarTalle.FlatStyle = FlatStyle.Flat;
            BRegistrarTalle.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarTalle.ForeColor = Color.White;
            BRegistrarTalle.Location = new Point(424, 74);
            BRegistrarTalle.Margin = new Padding(4, 5, 4, 5);
            BRegistrarTalle.Name = "BRegistrarTalle";
            BRegistrarTalle.Size = new Size(131, 65);
            BRegistrarTalle.TabIndex = 13;
            BRegistrarTalle.Text = "Añadir";
            BRegistrarTalle.UseVisualStyleBackColor = false;
            BRegistrarTalle.Click += BRegistrarTalle_Click;
            // 
            // TBNombreTalle
            // 
            TBNombreTalle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreTalle.Location = new Point(27, 89);
            TBNombreTalle.Margin = new Padding(4, 5, 4, 5);
            TBNombreTalle.Name = "TBNombreTalle";
            TBNombreTalle.Size = new Size(371, 30);
            TBNombreTalle.TabIndex = 6;
            TBNombreTalle.KeyPress += Num_KeyPress;
            // 
            // LNombreTalle
            // 
            LNombreTalle.AutoSize = true;
            LNombreTalle.BackColor = Color.Cornsilk;
            LNombreTalle.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreTalle.ForeColor = Color.DarkOrange;
            LNombreTalle.Location = new Point(23, 15);
            LNombreTalle.Margin = new Padding(4, 0, 4, 0);
            LNombreTalle.Name = "LNombreTalle";
            LNombreTalle.Size = new Size(283, 35);
            LNombreTalle.TabIndex = 0;
            LNombreTalle.Text = "Nombre de Talle :";
            // 
            // AñadirTalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 769);
            Controls.Add(TabControlRegTalles);
            Controls.Add(PanelRegTalles);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirTalle";
            Text = "Form1";
            TabControlRegTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarTalles).EndInit();
            PanelRegTalles.ResumeLayout(false);
            PanelRegTalles.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegTalles;
        internal TabPage TabPageListaTalles;
        internal DataGridView DataGridViewListarTalles;
        internal Panel PanelRegTalles;
        internal Button BRegistrarTalle;
        internal TextBox TBNombreTalle;
        internal Label LNombreTalle;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}