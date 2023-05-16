using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace wOficinaEmpleo
{


    internal class clsEmpleado
    { 
        //Declaro las variables con las propiedades para obtener y modificar el valor
        public string strTipoDocumento { get; set; }
        public int intNumeroDocumento { get; set; }
        public string strNombreEmpleado { get; set; }

        public string strApellidoEmpleado { get; set; }

        public DateTime datFechaNacimiento { get; set; }

        public string strNivelDeEstudios { get; set; }

        public string strTituloAcademico { get; set; }

        //Constructor

        public clsEmpleado()
        {

        }

        public clsEmpleado(string strTipoDocumento, int intNumeroDocumento, string strNombreEmpleado, string strApellidoEmpleado, DateTime datFechaNacimiento, string strNivelDeEstudios, string strTituloAcademico)
        {
            //Usare el this para aclarar que es la variable para esa clase y no otra.

            this.strTipoDocumento = strTipoDocumento;
            this.intNumeroDocumento = intNumeroDocumento;
            this.strNombreEmpleado = strNombreEmpleado;
            this.strApellidoEmpleado = strApellidoEmpleado;
            this.datFechaNacimiento = datFechaNacimiento;
            this.strNivelDeEstudios = strNivelDeEstudios;
            this.strTituloAcademico = strTituloAcademico;
        }

        public bool insertarDato()
        {
            
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();
    

            string insertar = "insert into tblEmpleado values (@strTipoDocumento, @intNumeroDocumento, @strNombreEmpleado, @strApellidoEmpleado, @datFechaNacimiento,@strNivelDeEstudios,@strTituloAcademico)";
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strTipoDocumento", this.strTipoDocumento);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strNombreEmpleado", this.strNombreEmpleado);
            sql.Parameters.AddWithValue("@strApellidoEmpleado", this.strApellidoEmpleado);
            sql.Parameters.AddWithValue("@datFechaNacimiento", this.datFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelDeEstudios", this.strNivelDeEstudios);
            sql.Parameters.AddWithValue("@strTituloAcademico", this.strTituloAcademico);
            sql.ExecuteNonQuery(); //Cierra la base de datos
            return true;


        }

        public DataTable consultarDato()
        {
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();
            DataTable datatable = new DataTable();
            string consulta = "select * from tblEmpleado";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            //Si yo no hago esto no me lleva la consulta al datagridview
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //Llenar todas las filas
            dataAdapter.Fill(datatable);
            return datatable;
        }

        public bool modificarDato()
        {
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();


            string insertar = "update tblEmpleado set strTipoDocumento =@strTipoDocumento, intNumeroDocumento = @intNumeroDocumento, strNombreEmpleado = @strNombreEmpleado, @strApellidoEmpleado = strApellidoEmpleado, @datFechaNacimiento = datFechaNacimiento, @strNivelDeEstudios = strNivelDeEstudios, @strTituloAcademico= strTituloAcademico where intNumeroDocumento =@intNumeroDocumento";
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strTipoDocumento", this.strTipoDocumento);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.Parameters.AddWithValue("@strNombreEmpleado", this.strNombreEmpleado);
            sql.Parameters.AddWithValue("@strApellidoEmpleado", this.strApellidoEmpleado);
            sql.Parameters.AddWithValue("@datFechaNacimiento", this.datFechaNacimiento);
            sql.Parameters.AddWithValue("@strNivelDeEstudios", this.strNivelDeEstudios);
            sql.Parameters.AddWithValue("@strTituloAcademico", this.strTituloAcademico);
            sql.ExecuteNonQuery(); //Cierra la base de datos
            return true;

           
        }

        public bool eliminarDato(int intNumeroDocumento)
        {
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();
            //Eliminar por ID, código

            this.intNumeroDocumento = intNumeroDocumento;
            string eliminar = "Delete tblEmpleado where intNumeroDocumento=@intNumeroDocumento";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intNumeroDocumento", this.intNumeroDocumento);
            sql.ExecuteNonQuery();
            return true;
        }

















    }
}
