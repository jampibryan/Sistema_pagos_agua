namespace Capa_Presentacion
{
    partial class Recibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibos));
            panel1 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            txtBuscarCiudadano = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtBuscarCiudadano);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 501);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 36);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 17;
            label7.Text = "RECIBOS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 165);
            dataGridView1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(732, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarCiudadano
            // 
            txtBuscarCiudadano.Location = new Point(664, 189);
            txtBuscarCiudadano.Name = "txtBuscarCiudadano";
            txtBuscarCiudadano.Size = new Size(198, 23);
            txtBuscarCiudadano.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(292, 80);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 22;
            label3.Text = "RECIBOS PENDIENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(291, 295);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 23;
            label1.Text = "RECIBOS GENERADOS";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(51, 322);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(607, 164);
            dataGridView2.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(732, 348);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(664, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(674, 293);
            label2.Name = "label2";
            label2.Size = new Size(188, 17);
            label2.TabIndex = 29;
            label2.Text = "____________________________________";
            // 
            // Recibos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 498);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recibos";
            Text = "Recibos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox txtBuscarCiudadano;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label2;
    }
}