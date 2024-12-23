namespace Capa_Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelCabecera = new Panel();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            panelMenu = new Panel();
            submenuReportes = new Panel();
            panel9 = new Panel();
            btnReporteDeudas = new Button();
            panel8 = new Panel();
            btnReportePagos = new Button();
            panel6 = new Panel();
            btnReportes = new Button();
            panel5 = new Panel();
            btnRecibos = new Button();
            panel4 = new Panel();
            btnZonas = new Button();
            panel3 = new Panel();
            btnCiudadanos = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnPagos = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            btnDeudas = new Button();
            panelCabecera.SuspendLayout();
            panelMenu.SuspendLayout();
            submenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCabecera
            // 
            panelCabecera.BackColor = Color.SteelBlue;
            panelCabecera.Controls.Add(btnMaximizar);
            panelCabecera.Controls.Add(btnMinimizar);
            panelCabecera.Controls.Add(btnRestaurar);
            panelCabecera.Controls.Add(btnCerrar);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(1070, 40);
            panelCabecera.TabIndex = 0;
            panelCabecera.MouseDown += panelCabecera_MouseDown;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.White;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1008, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(31, 40);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.White;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(971, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 40);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.White;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1008, 0);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(31, 40);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1039, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkSlateGray;
            panelMenu.Controls.Add(btnDeudas);
            panelMenu.Controls.Add(submenuReportes);
            panelMenu.Controls.Add(panel6);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(btnRecibos);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(btnZonas);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(btnCiudadanos);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnPagos);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 454);
            panelMenu.TabIndex = 1;


            // 
            // submenuReportes
            // 
            submenuReportes.Controls.Add(panel9);
            submenuReportes.Controls.Add(btnReporteDeudas);
            submenuReportes.Controls.Add(panel8);
            submenuReportes.Controls.Add(btnReportePagos);
            submenuReportes.Location = new Point(46, 321);
            submenuReportes.Name = "submenuReportes";
            submenuReportes.Size = new Size(154, 77);
            submenuReportes.TabIndex = 12;
            submenuReportes.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SteelBlue;
            panel9.Location = new Point(3, 37);
            panel9.Name = "panel9";
            panel9.Size = new Size(5, 28);
            panel9.TabIndex = 15;
            // 
            // btnReporteDeudas
            // 
            btnReporteDeudas.BackColor = Color.Transparent;
            btnReporteDeudas.FlatAppearance.BorderSize = 0;
            btnReporteDeudas.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnReporteDeudas.FlatStyle = FlatStyle.Flat;
            btnReporteDeudas.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteDeudas.ForeColor = Color.White;
            btnReporteDeudas.ImageAlign = ContentAlignment.MiddleRight;
            btnReporteDeudas.Location = new Point(14, 37);
            btnReporteDeudas.Name = "btnReporteDeudas";
            btnReporteDeudas.Size = new Size(124, 28);
            btnReporteDeudas.TabIndex = 16;
            btnReporteDeudas.Text = "Reporte Deudas";
            btnReporteDeudas.UseVisualStyleBackColor = false;
            btnReporteDeudas.Click += btnReporteDeudas_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SteelBlue;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 28);
            panel8.TabIndex = 13;
            // 
            // btnReportePagos
            // 
            btnReportePagos.BackColor = Color.Transparent;
            btnReportePagos.FlatAppearance.BorderSize = 0;
            btnReportePagos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnReportePagos.FlatStyle = FlatStyle.Flat;
            btnReportePagos.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportePagos.ForeColor = Color.White;
            btnReportePagos.ImageAlign = ContentAlignment.MiddleRight;
            btnReportePagos.Location = new Point(14, 3);
            btnReportePagos.Name = "btnReportePagos";
            btnReportePagos.Size = new Size(124, 28);
            btnReportePagos.TabIndex = 14;
            btnReportePagos.Text = "Reporte Pagos";
            btnReportePagos.UseVisualStyleBackColor = false;
            btnReportePagos.Click += btnReportePagos_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Location = new Point(0, 285);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 30);
            panel6.TabIndex = 10;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleRight;
            btnReportes.Location = new Point(12, 285);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(185, 30);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(0, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 30);
            panel5.TabIndex = 8;
            // 
            // btnRecibos
            // 
            btnRecibos.BackColor = Color.Transparent;
            btnRecibos.FlatAppearance.BorderSize = 0;
            btnRecibos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnRecibos.FlatStyle = FlatStyle.Flat;
            btnRecibos.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecibos.ForeColor = Color.White;
            btnRecibos.Image = (Image)resources.GetObject("btnRecibos.Image");
            btnRecibos.ImageAlign = ContentAlignment.MiddleRight;
            btnRecibos.Location = new Point(12, 249);
            btnRecibos.Name = "btnRecibos";
            btnRecibos.Size = new Size(185, 30);
            btnRecibos.TabIndex = 9;
            btnRecibos.Text = "Recibos";
            btnRecibos.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Location = new Point(0, 213);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 30);
            panel4.TabIndex = 6;
            // 
            // btnZonas
            // 
            btnZonas.BackColor = Color.Transparent;
            btnZonas.FlatAppearance.BorderSize = 0;
            btnZonas.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnZonas.FlatStyle = FlatStyle.Flat;
            btnZonas.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZonas.ForeColor = Color.White;
            btnZonas.Image = (Image)resources.GetObject("btnZonas.Image");
            btnZonas.ImageAlign = ContentAlignment.MiddleRight;
            btnZonas.Location = new Point(12, 213);
            btnZonas.Name = "btnZonas";
            btnZonas.Size = new Size(185, 30);
            btnZonas.TabIndex = 7;
            btnZonas.Text = "Zonas";
            btnZonas.UseVisualStyleBackColor = false;
            btnZonas.Click += btnZonas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 30);
            panel3.TabIndex = 4;
            // 
            // btnCiudadanos
            // 
            btnCiudadanos.BackColor = Color.Transparent;
            btnCiudadanos.FlatAppearance.BorderSize = 0;
            btnCiudadanos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCiudadanos.FlatStyle = FlatStyle.Flat;
            btnCiudadanos.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCiudadanos.ForeColor = Color.White;
            btnCiudadanos.Image = (Image)resources.GetObject("btnCiudadanos.Image");
            btnCiudadanos.ImageAlign = ContentAlignment.MiddleRight;
            btnCiudadanos.Location = new Point(12, 177);
            btnCiudadanos.Name = "btnCiudadanos";
            btnCiudadanos.Size = new Size(185, 30);
            btnCiudadanos.TabIndex = 5;
            btnCiudadanos.Text = "Ciudadanos";
            btnCiudadanos.UseVisualStyleBackColor = false;
            btnCiudadanos.Click += btnCiudadanos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 30);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(0, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 30);
            panel1.TabIndex = 0;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.Transparent;
            btnPagos.Cursor = Cursors.Hand;
            btnPagos.FlatAppearance.BorderSize = 0;
            btnPagos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagos.ForeColor = Color.White;
            btnPagos.Image = (Image)resources.GetObject("btnPagos.Image");
            btnPagos.ImageAlign = ContentAlignment.MiddleRight;
            btnPagos.Location = new Point(12, 105);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(185, 30);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 40);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.RightToLeft = RightToLeft.No;
            panelContenedor.Size = new Size(870, 454);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelFormularios_Paint;
            // 
            // btnDeudas
            // 
            btnDeudas.BackColor = Color.Transparent;
            btnDeudas.FlatAppearance.BorderSize = 0;
            btnDeudas.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnDeudas.FlatStyle = FlatStyle.Flat;
            btnDeudas.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeudas.ForeColor = Color.White;
            btnDeudas.Image = (Image)resources.GetObject("btnDeudas.Image");
            btnDeudas.ImageAlign = ContentAlignment.MiddleRight;
            btnDeudas.Location = new Point(11, 141);
            btnDeudas.Name = "btnDeudas";
            btnDeudas.Size = new Size(185, 30);
            btnDeudas.TabIndex = 14;
            btnDeudas.Text = "Deudas";
            btnDeudas.UseVisualStyleBackColor = false;
            btnDeudas.Click += btnDeudas_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1070, 494);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            RightToLeft = RightToLeft.Yes;
            Text = "Principal";
            Load += Principal_Load;
            panelCabecera.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            submenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCabecera;
        private Panel panelMenu;
        private Button btnCerrar;
        private Panel panelContenedor;
        private Button btnRestaurar;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private PictureBox pictureBox1;
        private Button btnPagos;
        private Panel panel1;
        private Panel panel3;
        private Button btnCiudadanos;
        private Panel panel2;
        private Panel panel4;
        private Button btnZonas;
        private Panel panel5;
        private Button btnRecibos;
        private Panel panel6;
        private Button btnReportes;
        private Panel submenuReportes;
        private Panel panel8;
        private Button btnReportePagos;
        private Panel panel9;
        private Button btnReporteDeudas;
        private Button btnDeudas;
    }
}