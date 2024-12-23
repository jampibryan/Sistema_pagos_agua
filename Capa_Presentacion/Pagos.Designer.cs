namespace Capa_Presentacion
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            panelPagos = new Panel();
            txtBuscarPago = new TextBox();
            label1 = new Label();
            dataGrid_DetallePago = new DataGridView();
            btn_VerDetallePago = new Button();
            btn_ListarPagos = new Button();
            label7 = new Label();
            btnBuscar = new PictureBox();
            dataGrid_Pagos = new DataGridView();
            panelPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DetallePago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Pagos).BeginInit();
            SuspendLayout();
            // 
            // panelPagos
            // 
            panelPagos.Controls.Add(txtBuscarPago);
            panelPagos.Controls.Add(label1);
            panelPagos.Controls.Add(dataGrid_DetallePago);
            panelPagos.Controls.Add(btn_VerDetallePago);
            panelPagos.Controls.Add(btn_ListarPagos);
            panelPagos.Controls.Add(label7);
            panelPagos.Controls.Add(btnBuscar);
            panelPagos.Controls.Add(dataGrid_Pagos);
            panelPagos.Location = new Point(0, 0);
            panelPagos.Name = "panelPagos";
            panelPagos.Size = new Size(823, 642);
            panelPagos.TabIndex = 1;
            panelPagos.Paint += panelPagos_Paint;
            // 
            // txtBuscarPago
            // 
            txtBuscarPago.Location = new Point(199, 78);
            txtBuscarPago.Name = "txtBuscarPago";
            txtBuscarPago.Size = new Size(166, 23);
            txtBuscarPago.TabIndex = 22;
            txtBuscarPago.TextChanged += txtBuscarPago_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 338);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 21;
            label1.Text = "DETALLE DEL PAGO";
            // 
            // dataGrid_DetallePago
            // 
            dataGrid_DetallePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_DetallePago.Location = new Point(32, 372);
            dataGrid_DetallePago.Name = "dataGrid_DetallePago";
            dataGrid_DetallePago.Size = new Size(603, 210);
            dataGrid_DetallePago.TabIndex = 18;
            // 
            // btn_VerDetallePago
            // 
            btn_VerDetallePago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerDetallePago.Location = new Point(654, 245);
            btn_VerDetallePago.Name = "btn_VerDetallePago";
            btn_VerDetallePago.Size = new Size(142, 33);
            btn_VerDetallePago.TabIndex = 17;
            btn_VerDetallePago.Text = "Ver Detalle";
            btn_VerDetallePago.UseVisualStyleBackColor = true;
            btn_VerDetallePago.Click += btn_VerDetallePago_Click;
            // 
            // btn_ListarPagos
            // 
            btn_ListarPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ListarPagos.Location = new Point(654, 160);
            btn_ListarPagos.Name = "btn_ListarPagos";
            btn_ListarPagos.Size = new Size(142, 33);
            btn_ListarPagos.TabIndex = 16;
            btn_ListarPagos.Text = "Listar Pagos";
            btn_ListarPagos.UseVisualStyleBackColor = true;
            btn_ListarPagos.Click += btn_ListarPagos_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 52);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 15;
            label7.Text = "REGISTRAR PAGOS";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(371, 64);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 37);
            btnBuscar.TabIndex = 14;
            btnBuscar.TabStop = false;
            // 
            // dataGrid_Pagos
            // 
            dataGrid_Pagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Pagos.Location = new Point(32, 107);
            dataGrid_Pagos.Name = "dataGrid_Pagos";
            dataGrid_Pagos.Size = new Size(603, 210);
            dataGrid_Pagos.TabIndex = 2;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 682);
            Controls.Add(panelPagos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagos";
            Text = "Pagos";
            Load += Pagos_Load;
            panelPagos.ResumeLayout(false);
            panelPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_DetallePago).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Pagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPagos;
        private DataGridView dataGrid_Pagos;
        private PictureBox btnBuscar;
        private Label label7;
        private Button btn_ListarPagos;
        private Button btn_VerDetallePago;
        private DataGridView dataGrid_DetallePago;
        private Label label1;
        private TextBox txtBuscarPago;
    }
}