using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Capa_Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = true;
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
        }

        private void btnReporteDeudas_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //private Form formActual = null;
        //public void AbrirFormHija(object formHija)
        //{
        //    if (formActual != null)
        //    {
        //       this.panelContenedor.Controls.Remove(formActual);
        //    }

        //    Form fH = formHija as Form;
        //    fH.TopLevel = false;
        //    fH.Dock = DockStyle.Fill;
        //    this.panelContenedor.Controls.Add(fH);
        //    this.panelContenedor.Tag = fH;
        //    fH.Show();
        //    formActual = fH as Form;
        //}


        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pagos());
        }
        private void btnDeudas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Deudas());
        }

        private void btnCiudadanos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ciudadanos());
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Zonas());
        }

    }
}
