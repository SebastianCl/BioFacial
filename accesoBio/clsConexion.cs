using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace accesoBio
{
    class clsConexion
    {
        string nomBD = "bioFacial";
        string nomSer = "SEBASTIAN\\SQLEXPRESS";
        SqlConnection conecta;

        public clsConexion()
        {
        }

        public SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        public int operar(string conSQL, SqlConnection conector)//inse,del,upd  
        {
            int num = 0;
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta" + e.ToString());
                return num;
            }
        }
        public void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq)
            {
                MessageBox.Show(eq.ToString());
            }
        }

        public SqlConnection conectar()
        {
            conecta = new SqlConnection("Data Source=" + nomSer + ";Initial Catalog=" + nomBD + ";Integrated Security=SSPI;");
            try
            {
                conecta.Open();
                return conecta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }
    }
}



