using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wOficinaEmpleo
{
    internal class clsBuscarEmpleo
    {
        //Declaracion de variables
        public int intCodigoEmpleo{ get; set; }
        //Constructor
        public clsBuscarEmpleo()
        {

        }
        
        public clsBuscarEmpleo(int intCodigoEmpleo)
        {
            this.intCodigoEmpleo = intCodigoEmpleo;
        }


        public DataTable consultarDato()
        {   //Método consultar dato
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();
            this.intCodigoEmpleo = intCodigoEmpleo;

            DataTable dt = new DataTable();
            string consulta = "select * from tblBuscarEmpleo where intCodigoEmpleo = @intCodigoEmpleo";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@intCodigoEmpleo", this.intCodigoEmpleo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public bool ExisteCodigo(int intCodigo)
        {   //Método para validar la existencia de N ID en la base de datos, si estos existen o no
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboOficinaEmpleo;integrated security=true");
            conexion.Open();

            SqlCommand comando = new SqlCommand("select count (*) FROM tblBuscarEmpleo where intCodigoEmpleo = @intCodigoEmpleo", conexion);
            comando.Parameters.AddWithValue("@intCodigoEmpleo", intCodigoEmpleo);

            int count = (int)comando.ExecuteScalar();
            bool existe = count > 0;

            conexion.Close();
            return existe;


        }












    }
}
