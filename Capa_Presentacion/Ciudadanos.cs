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
    public partial class Ciudadanos : Form
    {
        CN_Ciudadano objetoCN = new CN_Ciudadano();

        private string idCiudadano = null;
        private string valor = null;

        public Ciudadanos()
        {
            InitializeComponent();
        }

        private void Ciudadanos_Load(object sender, EventArgs e)
        {
            //Lo que se quiere ejecutar cuando se corre el programa
            ListarTipoGenero();
            ListarZona();
            ListarSituacion();
            ListarTipoTarifa();

            //btnEliminar.Enabled = true;
        }

        private void MostrarCiudadanos()
        {
            CN_Ciudadano objetoCN = new CN_Ciudadano();
            dataGrid_Ciudadanos.DataSource = objetoCN.Listar_Ciudadanos();
        }

        private void btn_ListarCiudadanos_Click(object sender, EventArgs e)
        {
            MostrarCiudadanos();
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void ListarTipoGenero()
        {
            cmbGenero.DataSource = objetoCN.Listar_TipoGenero();
            cmbGenero.DisplayMember = "descripcionTG";
            cmbGenero.ValueMember = "idTipoGenero";
        }

        private void ListarZona()
        {
            cmbZona.DataSource = objetoCN.Listar_Zona();
            cmbZona.DisplayMember = "descripcionZ";
            cmbZona.ValueMember = "idZona";
        }
        private void ListarSituacion()
        {
            cmbSituacion.DataSource = objetoCN.Listar_Situacion();
            cmbSituacion.DisplayMember = "descripcionS";
            cmbSituacion.ValueMember = "idSituacion";
        }

        private void ListarTipoTarifa()
        {
            cmbTipoTarifa.DataSource = objetoCN.Listar_TipoTarifa();
            cmbTipoTarifa.DisplayMember = "descripcionTT";
            cmbTipoTarifa.ValueMember = "idTipoTarifa";
        }

        private string borrarEspacios(string palabraEspacios)
        {
            char[] charsToTrim = { '*', '(', ')', ' ', '\'' };

            string Texto = palabraEspacios.Trim(charsToTrim);

            return Texto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Ciudadano objetoCN = new CN_Ciudadano();
            valor = txt_buscarCiudadano.Text;
            dataGrid_Ciudadanos.DataSource = objetoCN.Buscar_Ciudadano(valor);
        }

        private void txt_buscarCiudadano_TextChanged(object sender, EventArgs e)
        {
            CN_Ciudadano objetoCN = new CN_Ciudadano();
            valor = txt_buscarCiudadano.Text;
            dataGrid_Ciudadanos.DataSource = objetoCN.Buscar_Ciudadano(valor);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.Insertar_Ciudadano(
                                    borrarEspacios(txtNombre.Text),
                                    borrarEspacios(txtApellido.Text),
                                    borrarEspacios(txtTelefono.Text),
                                    borrarEspacios(txtDNI.Text),

                                    cmbGenero.SelectedValue.ToString(),
                                    cmbZona.SelectedValue.ToString(),
                                    cmbSituacion.SelectedValue.ToString(),
                                    cmbTipoTarifa.SelectedValue.ToString());

                MessageBox.Show("Se registró exitosamente al Ciudadano");
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                MostrarCiudadanos();
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar al Cliente" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGrid_Ciudadanos.SelectedRows.Count > 0)
            {
                idCiudadano = dataGrid_Ciudadanos.CurrentRow.Cells["Id"].Value.ToString();

                txtNombre.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtTelefono.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Teléfono"].Value.ToString();
                txtDNI.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Dni"].Value.ToString();
                
                cmbGenero.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Género"].Value.ToString();
                cmbZona.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Zona"].Value.ToString();
                cmbSituacion.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Situación"].Value.ToString();
                cmbTipoTarifa.Text = dataGrid_Ciudadanos.CurrentRow.Cells["Tipo Tarifa"].Value.ToString();

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
                objetoCN.Editar_Ciudadano(
                                    idCiudadano,
                                    borrarEspacios(txtNombre.Text),
                                    borrarEspacios(txtApellido.Text),
                                    borrarEspacios(txtTelefono.Text),
                                    borrarEspacios(txtDNI.Text),

                                    cmbGenero.SelectedValue.ToString(),
                                    cmbZona.SelectedValue.ToString(),
                                    cmbSituacion.SelectedValue.ToString(),
                                    cmbTipoTarifa.SelectedValue.ToString());

                MessageBox.Show("Se actualizó correctamente al Ciudadano");

                btnRegistrar.Visible = true;
                btnActualizar.Visible = false;
                MostrarCiudadanos();
                limpiarForm();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGrid_Ciudadanos.SelectedRows.Count > 0)
            {
                idCiudadano = dataGrid_Ciudadanos.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.Eliminar_Ciudadano(idCiudadano);
                MessageBox.Show("Ciudadano eliminado exitosamente");
                limpiarForm();
                MostrarCiudadanos();
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDNI.Clear();

            btnRegistrar.Visible = true;
            btnActualizar.Visible = false;
        }

        private void dataGrid_Ciudadanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelCiudadano_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
