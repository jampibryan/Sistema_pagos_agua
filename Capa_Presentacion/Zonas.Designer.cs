namespace Capa_Presentacion
{
    partial class Zonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zonas));
            btnListarZonas = new Button();
            label1 = new Label();
            txtDescripcionZ = new TextBox();
            dataGrid_Zonas = new DataGridView();
            label2 = new Label();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            txt_buscarZona = new TextBox();
            btnBuscarZona = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Zonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarZona).BeginInit();
            SuspendLayout();
            // 
            // btnListarZonas
            // 
            btnListarZonas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListarZonas.Location = new Point(443, 151);
            btnListarZonas.Name = "btnListarZonas";
            btnListarZonas.Size = new Size(140, 35);
            btnListarZonas.TabIndex = 0;
            btnListarZonas.Text = "Listar zonas";
            btnListarZonas.UseVisualStyleBackColor = true;
            btnListarZonas.Click += btnListarZonas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 73);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 1;
            label1.Text = "Ubicación de nueva zona:";
            label1.Click += label1_Click;
            // 
            // txtDescripcionZ
            // 
            txtDescripcionZ.Location = new Point(29, 91);
            txtDescripcionZ.Name = "txtDescripcionZ";
            txtDescripcionZ.Size = new Size(174, 23);
            txtDescripcionZ.TabIndex = 2;
            txtDescripcionZ.TextChanged += txtDescripcionZ_TextChanged;
            // 
            // dataGrid_Zonas
            // 
            dataGrid_Zonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Zonas.Location = new Point(146, 151);
            dataGrid_Zonas.Name = "dataGrid_Zonas";
            dataGrid_Zonas.Size = new Size(271, 150);
            dataGrid_Zonas.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 30);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 5;
            label2.Text = "REGISTRO DE ZONA";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(46, 166);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(84, 35);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(46, 210);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 35);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(46, 251);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 35);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(443, 204);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 35);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Visible = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(443, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 35);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txt_buscarZona
            // 
            txt_buscarZona.Location = new Point(268, 86);
            txt_buscarZona.Name = "txt_buscarZona";
            txt_buscarZona.Size = new Size(100, 23);
            txt_buscarZona.TabIndex = 13;
            txt_buscarZona.TextChanged += txt_buscarZona_TextChanged;
            // 
            // btnBuscarZona
            // 
            btnBuscarZona.Image = (Image)resources.GetObject("btnBuscarZona.Image");
            btnBuscarZona.Location = new Point(380, 77);
            btnBuscarZona.Name = "btnBuscarZona";
            btnBuscarZona.Size = new Size(37, 37);
            btnBuscarZona.TabIndex = 14;
            btnBuscarZona.TabStop = false;
            btnBuscarZona.Click += btnBuscarZona_Click;
            // 
            // Zonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 358);
            Controls.Add(btnBuscarZona);
            Controls.Add(txt_buscarZona);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(dataGrid_Zonas);
            Controls.Add(txtDescripcionZ);
            Controls.Add(label1);
            Controls.Add(btnListarZonas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Zonas";
            Text = "Zonas";
            Load += Zonas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Zonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscarZona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarZonas;
        private Label label1;
        private TextBox txtDescripcionZ;
        private DataGridView dataGrid_Zonas;
        private Label label2;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox txt_buscarZona;
        private PictureBox btnBuscarZona;
    }
}