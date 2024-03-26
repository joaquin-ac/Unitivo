namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class ManejoBD
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
            panel3 = new Panel();
            panel2 = new Panel();
            Label1 = new Label();
            panel1 = new Panel();
            BRestaurar = new Button();
            BResguardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Location = new Point(182, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(29, 279);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Location = new Point(870, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(29, 279);
            panel2.TabIndex = 11;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkGoldenrod;
            Label1.Location = new Point(315, 288);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(444, 69);
            Label1.TabIndex = 9;
            Label1.Text = "Base de Datos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(BRestaurar);
            panel1.Controls.Add(BResguardar);
            panel1.Location = new Point(208, 341);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 279);
            panel1.TabIndex = 10;
            // 
            // BRestaurar
            // 
            BRestaurar.BackColor = Color.Cornsilk;
            BRestaurar.FlatAppearance.BorderSize = 2;
            BRestaurar.FlatStyle = FlatStyle.Flat;
            BRestaurar.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BRestaurar.ForeColor = Color.DarkOrange;
            BRestaurar.Location = new Point(361, 119);
            BRestaurar.Margin = new Padding(4, 5, 4, 5);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(196, 58);
            BRestaurar.TabIndex = 19;
            BRestaurar.Text = "Restaurar";
            BRestaurar.UseVisualStyleBackColor = false;
            // 
            // BResguardar
            // 
            BResguardar.BackColor = Color.Cornsilk;
            BResguardar.FlatAppearance.BorderSize = 2;
            BResguardar.FlatStyle = FlatStyle.Flat;
            BResguardar.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BResguardar.ForeColor = Color.DarkOrange;
            BResguardar.Location = new Point(107, 119);
            BResguardar.Margin = new Padding(4, 5, 4, 5);
            BResguardar.Name = "BResguardar";
            BResguardar.Size = new Size(196, 58);
            BResguardar.TabIndex = 18;
            BResguardar.Text = "Resguardar";
            BResguardar.UseVisualStyleBackColor = false;
            // 
            // ManejoBD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1080, 908);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManejoBD";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        internal Label Label1;
        private Panel panel1;
        internal Button BRestaurar;
        internal Button BResguardar;
    }
}