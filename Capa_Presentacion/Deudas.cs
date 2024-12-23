using Capa_Negocio;
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
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Presentacion
{
    public partial class Deudas : Form
    {
        CN_Deuda objetoCN = new CN_Deuda();

        private string idDeuda = null;
        private string valor = null;


        CN_Pago objetoCNP = new CN_Pago();

        private string idPago = null;
        private string valorP = null;

        public Deudas()
        {
            InitializeComponent();
        }

        private void MostrarDeudas()
        {
            CN_Deuda objetoCN = new CN_Deuda();
            dataGrid_Deudas.DataSource = objetoCN.Listar_Deudas();
        }

        private void MostrarDetalleDeuda(string idDeuda)
        {
            CN_Deuda objetoCN = new CN_Deuda();
            dataGrid_DetalleDeuda.DataSource = objetoCN.Listar_DetalleDeuda(idDeuda);
        }


        private void txtBuscarDeuda_TextChanged(object sender, EventArgs e)
        {
            CN_Deuda objetoCN = new CN_Deuda();
            valor = txtBuscarDeuda.Text;
            dataGrid_Deudas.DataSource = objetoCN.Buscar_Deuda(valor);
        }

        private void btn_ListarDeudas_Click(object sender, EventArgs e)
        {
            MostrarDeudas();
            btn_VerDetaleDeuda.Visible = true;
        }


        private void btn_VerDetaleDeuda_Click(object sender, EventArgs e)
        {

            if (dataGrid_Deudas.SelectedRows.Count > 0)
            {
                idDeuda = dataGrid_Deudas.CurrentRow.Cells["Id"].Value.ToString();

                MostrarDetalleDeuda(idDeuda);
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila
            {
                MessageBox.Show("Seleccione una fila para ver su detalle");
            }
        }



        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {

            if (dataGrid_Deudas.SelectedRows.Count > 0)
            {
                idDeuda = dataGrid_Deudas.CurrentRow.Cells["Id"].Value.ToString();

                try
                {
                    objetoCNP.Insertar_Pago(
                        idDeuda,
                        cantidadSemanas.Text);

                    MessageBox.Show("Se registró exitosamente el Pago");

                    MostrarDeudas();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar al Pago" + ex);
                }

            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila
            {
                MessageBox.Show("Seleccione una fila para realizar el pago");
            }
        }


        private void limpiarForm()
        {
            cantidadSemanas.Value = cantidadSemanas.Minimum;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Deudas_Load(object sender, EventArgs e)
        {

        }

    }
}
