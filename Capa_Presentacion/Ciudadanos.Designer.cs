
namespace Capa_Presentacion
{
    partial class Ciudadanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudadanos));
            dataGrid_Ciudadanos = new DataGridView();
            btn_ListarCiudadanos = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbGenero = new ComboBox();
            cmbZona = new ComboBox();
            cmbSituacion = new ComboBox();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnBuscar = new PictureBox();
            panelCiudadano = new Panel();
            label9 = new Label();
            cmbTipoTarifa = new ComboBox();
            txt_buscarCiudadano = new TextBox();
            label8 = new Label();
            txtDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Ciudadanos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            panelCiudadano.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_Ciudadanos
            // 
            dataGrid_Ciudadanos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_Ciudadanos.Location = new Point(33, 268);
            dataGrid_Ciudadanos.Name = "dataGrid_Ciudadanos";
            dataGrid_Ciudadanos.Size = new Size(639, 156);
            dataGrid_Ciudadanos.TabIndex = 0;
            dataGrid_Ciudadanos.CellContentClick += dataGrid_Ciudadanos_CellContentClick;
            // 
            // btn_ListarCiudadanos
            // 
            btn_ListarCiudadanos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ListarCiudadanos.Location = new Point(678, 268);
            btn_ListarCiudadanos.Name = "btn_ListarCiudadanos";
            btn_ListarCiudadanos.Size = new Size(142, 33);
            btn_ListarCiudadanos.TabIndex = 1;
            btn_ListarCiudadanos.Text = "Listar Ciudadanos";
            btn_ListarCiudadanos.UseVisualStyleBackColor = true;
            btn_ListarCiudadanos.Click += btn_ListarCiudadanos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 2;
            label1.Text = "REGISTRO DE CIUDADANO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombres:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(236, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(176, 23);
            txtApellido.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 77);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellidos:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(438, 97);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(103, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 77);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 136);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 138);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "Zona:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 138);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 11;
            label7.Text = "Situación:";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(99, 154);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 10;
            // 
            // cmbZona
            // 
            cmbZona.FormattingEnabled = true;
            cmbZona.Location = new Point(251, 156);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(145, 23);
            cmbZona.TabIndex = 13;
            // 
            // cmbSituacion
            // 
            cmbSituacion.FormattingEnabled = true;
            cmbSituacion.Location = new Point(433, 156);
            cmbSituacion.Name = "cmbSituacion";
            cmbSituacion.Size = new Size(121, 23);
            cmbSituacion.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegistrar.Location = new Point(33, 222);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(97, 34);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(144, 222);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 34);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnActualizar.Location = new Point(678, 348);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(142, 34);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Visible = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpiar.Location = new Point(262, 222);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 34);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(678, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 34);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.InitialImage = (Image)resources.GetObject("btnBuscar.InitialImage");
            btnBuscar.Location = new Point(678, 225);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 37);
            btnBuscar.TabIndex = 24;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panelCiudadano
            // 
            panelCiudadano.Controls.Add(label9);
            panelCiudadano.Controls.Add(cmbTipoTarifa);
            panelCiudadano.Controls.Add(txt_buscarCiudadano);
            panelCiudadano.Controls.Add(label8);
            panelCiudadano.Controls.Add(btnLimpiar);
            panelCiudadano.Controls.Add(label7);
            panelCiudadano.Controls.Add(cmbSituacion);
            panelCiudadano.Controls.Add(btnRegistrar);
            panelCiudadano.Controls.Add(btnEditar);
            panelCiudadano.Controls.Add(label6);
            panelCiudadano.Controls.Add(txtDNI);
            panelCiudadano.Controls.Add(cmbGenero);
            panelCiudadano.Controls.Add(label5);
            panelCiudadano.Controls.Add(btn_ListarCiudadanos);
            panelCiudadano.Controls.Add(txtTelefono);
            panelCiudadano.Controls.Add(cmbZona);
            panelCiudadano.Controls.Add(label4);
            panelCiudadano.Dock = DockStyle.Fill;
            panelCiudadano.Location = new Point(0, 0);
            panelCiudadano.Name = "panelCiudadano";
            panelCiudadano.Size = new Size(843, 450);
            panelCiudadano.TabIndex = 25;
            panelCiudadano.Paint += panelCiudadano_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(594, 138);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 28;
            label9.Text = "Tipo Tarifa:";
            // 
            // cmbTipoTarifa
            // 
            cmbTipoTarifa.FormattingEnabled = true;
            cmbTipoTarifa.Location = new Point(594, 156);
            cmbTipoTarifa.Name = "cmbTipoTarifa";
            cmbTipoTarifa.Size = new Size(121, 23);
            cmbTipoTarifa.TabIndex = 27;
            // 
            // txt_buscarCiudadano
            // 
            txt_buscarCiudadano.Location = new Point(452, 233);
            txt_buscarCiudadano.Name = "txt_buscarCiudadano";
            txt_buscarCiudadano.Size = new Size(220, 23);
            txt_buscarCiudadano.TabIndex = 26;
            txt_buscarCiudadano.TextChanged += txt_buscarCiudadano_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(566, 79);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 17;
            label8.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(569, 97);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(103, 23);
            txtDNI.TabIndex = 8;
            // 
            // Ciudadanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGrid_Ciudadanos);
            Controls.Add(panelCiudadano);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ciudadanos";
            Text = "Ciudadanos";
            Load += Ciudadanos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_Ciudadanos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            panelCiudadano.ResumeLayout(false);
            panelCiudadano.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView dataGrid_Ciudadanos;
        private Button btn_ListarCiudadanos;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbGenero;
        private ComboBox cmbZona;
        private ComboBox cmbSituacion;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private PictureBox btnBuscar;
        private Panel panelCiudadano;
        private Label label8;
        private TextBox txtDNI;
        private TextBox txt_buscarCiudadano;
        private Label label9;
        private ComboBox cmbTipoTarifa;
    }
}