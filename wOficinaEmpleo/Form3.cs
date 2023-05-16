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

namespace wOficinaEmpleo
{
    public partial class frmModuloBuscarEmpleo : Form
    {
        public frmModuloBuscarEmpleo()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();

            clsBuscarEmpleo p1 = new clsBuscarEmpleo(Convert.ToInt32(txtCodigoDeEmpleo.Text));

            dtgBuscarEmpleo.DataSource = p1.consultarDato();

            if (p1.ExisteCodigo(p1.intCodigoEmpleo))
            {
                dtgBuscarEmpleo.DataSource = p1.consultarDato();
            }
            else
            {
                MessageBox.Show("El empleo no está registrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmModuloBuscarEmpleo_Load(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;
        }

        private void validarCampo()
        {
            var validacion = !string.IsNullOrEmpty(txtCodigoDeEmpleo.Text);
            btnConsultar.Enabled= validacion;


        }

        private void txtCodigoDeEmpleo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
