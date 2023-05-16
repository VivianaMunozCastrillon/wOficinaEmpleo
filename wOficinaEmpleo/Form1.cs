using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///Nombres:Viviana Muñoz Castriilon, Laura Serena Rivera Mejia
///Fecha:15/05/2023
///Descripcion:Este programa registra en base de datos los datos personales de empleados y valida empleos 
///exitentes desde el codigo asignado en la base de datos
///en una oficina de empleo coN implementacion de formularios MDI a traves de menustrip
///y funcionalidades de CRUD.
namespace wOficinaEmpleo
{
    public partial class frmOficinaEmpleo : Form
    {
        public frmOficinaEmpleo()
        {
            InitializeComponent();
        }

        private void móduloEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuloEmpleado FrmModuloEmpleado = new frmModuloEmpleado();
            FrmModuloEmpleado.MdiParent = this;
            FrmModuloEmpleado.Show();
        }

        private void móduloBuscarEmpleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuloBuscarEmpleo FrmModuloBuscarEmpleo = new frmModuloBuscarEmpleo();
            FrmModuloBuscarEmpleo.MdiParent = this;
            FrmModuloBuscarEmpleo.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmModulo = this.ActiveMdiChild;
            if (frmModulo != null)
            {
                frmModulo.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
