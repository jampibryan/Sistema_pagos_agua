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
    public partial class Zonas : Form
    {
        CN_Zona objetoCN = new CN_Zona();

        private string idZona = null;
        private string valor = null;
        public Zonas()
        {
            InitializeComponent();
        }

        private void Zonas_Load(object sender, EventArgs e)
        {

            //btnEliminar.Visible = true;
        }

        private void MostrarZonas()
        {
            CN_Zona objetoCN = new CN_Zona();
            dataGrid_Zonas.DataSource = objetoCN.Listar_Zonas();
        }


        private void btnListarZonas_Click(object sender, EventArgs e)
        {
            MostrarZonas();
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }
        private void btnBuscarZona_Click(object sender, EventArgs e)
        {
            CN_Zona objetoCN = new CN_Zona();
            valor = txt_buscarZona.Text;
            dataGrid_Zonas.DataSource = objetoCN.Buscar_Zona(valor);
        }



        private void txt_buscarZona_TextChanged(object sender, EventArgs e)
        {
            CN_Zona objetoCN = new CN_Zona();
            valor = txt_buscarZona.Text;
            dataGrid_Zonas.DataSource = objetoCN.Buscar_Zona(valor);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Insertar_Zona(borrarEspacios(txtDescripcionZ.Text));

                MessageBox.Show("Se registró exitosamente la Zona");
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                MostrarZonas();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la Zona" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGrid_Zonas.SelectedRows.Count > 0)
            {
                idZona = dataGrid_Zonas.CurrentRow.Cells["Id"].Value.ToString();

                txtDescripcionZ.Text = dataGrid_Zonas.CurrentRow.Cells["Zona"].Value.ToString();

                btnRegistrar.Visible = false;
                btnActualizar.Visible = true;
            }

            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a editar
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Editar_Zona(idZona, borrarEspacios(txtDescripcionZ.Text));

                MessageBox.Show("Se actualizó correctamente la Zona");

                btnRegistrar.Visible = true;
                btnActualizar.Visible = false;
                MostrarZonas();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGrid_Zonas.SelectedRows.Count > 0)
            {
                idZona = dataGrid_Zonas.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Zona(idZona);
                MessageBox.Show("Zona eliminada exitosamente");
                MostrarZonas();
            }
            else //Al no cumplirse la condición, entonces mostraremos al usuario que seleccione la fila a eliminar
            {
                MessageBox.Show("Seleccione una fila para eliminar por favor");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
        {
            txtDescripcionZ.Clear();

            btnRegistrar.Visible = true;
            btnActualizar.Visible = false;
        }


        private void txtDescripcionZ_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
