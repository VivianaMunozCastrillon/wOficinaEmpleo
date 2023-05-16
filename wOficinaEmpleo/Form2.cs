using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wOficinaEmpleo
{
    public partial class frmModuloEmpleado : Form
    {
        public frmModuloEmpleado()
        {
            InitializeComponent();
        }

        private void frmModuloEmpleado_Load(object sender, EventArgs e)
        {
            //Desactiva los botones insertar al iniciar la compilacion.
            btnInsertar.Enabled= false;
        }

        private void validarCampo()
        {
            //Metodo para validar si los campos estan vacios y no permite guardar hasta que todos
            //esten diligenciados

            var validacion = !string.IsNullOrEmpty(txtNombreEmpleado.Text) &&
            !string.IsNullOrEmpty(txtApellidoEmpleado.Text) &&
            !string.IsNullOrEmpty(txtNumeroDocumento.Text) &&
            !string.IsNullOrEmpty(cboTipoDocumento.Text) &&
            !string.IsNullOrEmpty(cboNivelDeEstudios.Text) &&
            !string.IsNullOrEmpty(txtTituloAcademico.Text);
            btnInsertar.Enabled = validacion;

        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
                conexion.Open();

                DateTime datFechaNacimiento = datFechaDeNacimiento.Value.Date;

                clsEmpleado empleado = new clsEmpleado(cboTipoDocumento.SelectedItem.ToString(), Convert.ToInt32(txtNumeroDocumento.Text), txtNombreEmpleado.Text, txtApellidoEmpleado.Text, datFechaNacimiento, cboNivelDeEstudios.SelectedItem.ToString(), txtTituloAcademico.Text);
                //Aqui lo llamamos desde un objeto porque le hicimos una clase. Si hubiera sido en el mismo lado solo colocabamos el evento
                empleado.insertarDato();
                MessageBox.Show("Dato ingresado","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //A la vez que lo atrapa lo inserta en el datagridview
                dtgEmpleado.DataSource = empleado;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar el dato, verifique que el número de documento es distinto.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboTienda;integrated security=true");
                conexion.Open();
                clsEmpleado empleado = new clsEmpleado();
                dtgEmpleado.DataSource = empleado.consultarDato();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al consultar el dato");
            }
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
                conexion.Open();

                DateTime datFechaNacimiento = datFechaDeNacimiento.Value.Date;

                clsEmpleado empleado = new clsEmpleado(cboTipoDocumento.SelectedItem.ToString(), Convert.ToInt32(txtNumeroDocumento.Text), txtNombreEmpleado.Text, txtApellidoEmpleado.Text, datFechaNacimiento, cboNivelDeEstudios.SelectedItem.ToString(), txtTituloAcademico.Text);
                empleado.modificarDato();
                MessageBox.Show("Datos modificados exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgEmpleado.DataSource = empleado.consultarDato();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar el dato","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboTienda;integrated security=true");
                conexion.Open();
                clsEmpleado empleado = new clsEmpleado();
                //Control J para el intellisense
                empleado.eliminarDato(Convert.ToInt32(txtNumeroDocumento.Text));
                dtgEmpleado.DataSource = empleado.consultarDato();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar dato","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            cboTipoDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[0].Value.ToString();
            txtNumeroDocumento.Text = dtgEmpleado.SelectedRows[0].Cells[1].Value.ToString();
            txtNombreEmpleado.Text = dtgEmpleado.SelectedRows[0].Cells[2].Value.ToString();
            txtApellidoEmpleado.Text = dtgEmpleado.SelectedRows[0].Cells[3].Value.ToString();
            datFechaDeNacimiento.Text = dtgEmpleado.SelectedRows[0].Cells[4].Value.ToString();
            cboNivelDeEstudios.Text = dtgEmpleado.SelectedRows[0].Cells[5].Value.ToString();
            txtTituloAcademico.Text = dtgEmpleado.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            cboNivelDeEstudios.SelectedIndex = -1;
            txtTituloAcademico.Clear();
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtApellidoEmpleado_TextChanged(object sender, EventArgs e)
        {
            validarCampo();

        }

        private void cboNivelDeEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();

        }

        private void txtTituloAcademico_TextChanged(object sender, EventArgs e)
        {
            validarCampo();

        }
    }
}
