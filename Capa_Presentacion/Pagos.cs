using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Pagos : Form
    {

        CN_Pago objetoCN = new CN_Pago();

        private string idPago = null;
        private string valor = null;

        public Pagos()
        {
            InitializeComponent();
        }

        private void MostrarPagos()
        {
            CN_Pago objetoCN = new CN_Pago();
            dataGrid_Pagos.DataSource = objetoCN.Listar_Pagos();
        }


        private void MostrarDetalleDeuda(string idPago)
        {
            CN_Pago objetoCN = new CN_Pago();
            dataGrid_DetallePago.DataSource = objetoCN.Listar_DetallePago(idPago);
        }


        private void btn_ListarPagos_Click(object sender, EventArgs e)
        {
            MostrarPagos();
        }


        private void txtBuscarPago_TextChanged(object sender, EventArgs e)
        {
            CN_Pago objetoCN = new CN_Pago();
            valor = txtBuscarPago.Text;
            dataGrid_Pagos.DataSource = objetoCN.BuscarPago(valor);
        }


        private void btn_VerDetallePago_Click(object sender, EventArgs e)
        {
            if (dataGrid_Pagos.SelectedRows.Count > 0)
            {
                idPago = dataGrid_Pagos.CurrentRow.Cells["ID Pago"].Value.ToString();

                MostrarDetalleDeuda(idPago);
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila
            {
                MessageBox.Show("Seleccione una fila para ver su detalle");
            }
        }








        private void panelPagos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pagos_Load(object sender, EventArgs e)
        {

        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void txtBuscarCiudadano_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
