using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace libDatos
{
    public class clsConexion
    {
        #region ATRIBUTOS               
        private string strNomBD;
        private string strNomSer;
        private string strUser;
        private string strPassword;
        private SqlConnection objCnx;
        private SqlCommand objCmd;
        private SqlDataReader objTabla;        
        #endregion

        #region CONSTRUCTOR
        public clsConexion()
        {
            strNomBD = "bioFacial";
            strNomSer = "Server\\SQLEXPRESS";
            strUser = "user";
            strPassword = "password";
        }
        #endregion

        #region METODOS PUBLICOS

        public SqlDataReader consulta(string strConSQL, SqlConnection objConector)
        {
            try
            {
                objCmd = new SqlCommand(strConSQL, objConector);
                objTabla = objCmd.ExecuteReader();                
                return objTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }
        
        public SqlDataReader consultaSP(string strStored_Procedure)
        {
            try
            {                
                //Preparar el Comando para ejecutar la transacción SQL en la BD
                objCmd = new SqlCommand(strStored_Procedure, objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;                
                objTabla = objCmd.ExecuteReader();  //Realizar la transacción en la BD
                return objTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public SqlDataReader consultaSP(string strStored_Procedure, string strParametro)
        {
            try
            {
                //Preparar el Comando para ejecutar la transacción SQL en la BD
                objCmd = new SqlCommand(strStored_Procedure, objCnx);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.AddWithValue("@cedula",strParametro);
                objTabla = objCmd.ExecuteReader();  //Realizar la transacción en la BD
                return objTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
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
            objCnx = new SqlConnection("Data Source=" + strNomSer + ";Initial Catalog=" + strNomBD + ";Persist Security Info=false; User ID=" + strUser + "; Password=" + strPassword + ";");
            try
            {
                objCnx.Open();
                return objCnx;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }
        #endregion
        
    }
}
