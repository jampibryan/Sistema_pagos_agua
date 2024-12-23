namespace Capa_Presentacion
{
    partial class Deudas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deudas));
            panel1 = new Panel();
            cantidadSemanas = new NumericUpDown();
            label2 = new Label();
            btnRegistrarPago = new Button();
            btn_VerDetaleDeuda = new Button();
            btn_ListarDeudas = new Button();
            dataGrid_DetalleDeuda = new DataGridView();
            label1 = new Label();
            btnBuscar = new PictureBox();
            txtBuscarDeuda = new TextBox();
            dataGrid_Deudas = new DataGridView();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadSemanas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DetalleDeuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Deudas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cantidadSemanas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRegistrarPago);
            panel1.Controls.Add(btn_VerDetaleDeuda);
            panel1.Controls.Add(btn_ListarDeudas);
            panel1.Controls.Add(dataGrid_DetalleDeuda);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarDeuda);
            panel1.Controls.Add(dataGrid_Deudas);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 702);
            panel1.TabIndex = 0;
            // 
            // cantidadSemanas
            // 
            cantidadSemanas.Location = new Point(336, 630);
            cantidadSemanas.Name = "cantidadSemanas";
            cantidadSemanas.Size = new Size(120, 23);
            cantidadSemanas.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 596);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 28;
            label2.Text = "Cantidad de semanas a pagar:";
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPago.Location = new Point(527, 622);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(142, 33);
            btnRegistrarPago.TabIndex = 25;
            btnRegistrarPago.Text = "Registrar Pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // btn_VerDetaleDeuda
            // 
            btn_VerDetaleDeuda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerDetaleDeuda.Location = new Point(709, 223);
            btn_VerDetaleDeuda.Name = "btn_VerDetaleDeuda";
            btn_VerDetaleDeuda.Size = new Size(142, 33);
            btn_VerDetaleDeuda.TabIndex = 24;
            btn_VerDetaleDeuda.Text = "Ver Detalle";
            btn_VerDetaleDeuda.UseVisualStyleBackColor = true;
            btn_VerDetaleDeuda.Visible = false;
            btn_VerDetaleDeuda.Click += btn_VerDetaleDeuda_Click;
            // 
            // btn_ListarDeudas
            // 
            btn_ListarDeudas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ListarDeudas.Location = new Point(709, 145);
            btn_ListarDeudas.Name = "btn_ListarDeudas";
            btn_ListarDeudas.Size = new Size(142, 33);
            btn_ListarDeudas.TabIndex = 23;
            btn_ListarDeudas.Text = "Listar Deudas";
            btn_ListarDeudas.UseVisualStyleBackColor = true;
            btn_ListarDeudas.Click += btn_ListarDeudas_Click;
            // 
            // dataGrid_DetalleDeuda
            // 
            dataGrid_DetalleDeuda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_DetalleDeuda.Location = new Point(22, 356);
            dataGrid_DetalleDeuda.Name = "dataGrid_DetalleDeuda";
            dataGrid_DetalleDeuda.Size = new Size(759, 212);
            dataGrid_DetalleDeuda.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 315);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 20;
            label1.Text = "DETALLE DE DEUDA";
            label1.Click += label1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(562, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 37);
            btnBuscar.TabIndex = 19;
            btnBuscar.TabStop = false;
            // 
            // txtBuscarDeuda
            // 
            txtBuscarDeuda.Location = new Point(390, 48);
            txtBuscarDeuda.Name = "txtBuscarDeuda";
            txtBuscarDeuda.Size = new Size(166, 23);
            txtBuscarDeuda.TabIndex = 18;
            txtBuscarDeuda.TextChanged += txtBuscarDeuda_TextChanged;
            // 
            // dataGrid_Deudas
            // 
            dataGrid_Deudas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Deudas.Location = new Point(22, 77);
            dataGrid_Deudas.Name = "dataGrid_Deudas";
            dataGrid_Deudas.Size = new Size(671, 221);
            dataGrid_Deudas.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 34);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 16;
            label7.Text = "DEUDAS";
            // 
            // Deudas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(890, 726);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deudas";
            Text = "Deudas";
            Load += Deudas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadSemanas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DetalleDeuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Deudas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGrid_Deudas;
        private Label label7;
        private PictureBox btnBuscar;
        private TextBox txtBuscarDeuda;
        private Label label1;
        private DataGridView dataGrid_DetalleDeuda;
        private Button btn_ListarDeudas;
        private Button btn_VerDetaleDeuda;
        private Button btnRegistrarPago;
        private Label label2;
        private NumericUpDown cantidadSemanas;
    }
}