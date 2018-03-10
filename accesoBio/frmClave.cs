using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using libDatos;

namespace accesoBio
{
    public partial class frmClave : Form
    {
        #region ATRIBUTOS
        clsConexion objCon;
        private SqlConnection objConector;
        private SqlDataReader objTabla;
        string strRespuesta;
        string strClave;
        #endregion

        #region CONSTRUCTOR

        public frmClave(string strCedula)
        {
            InitializeComponent();
            objCon = new clsConexion();
            cargarDatos(strCedula);
        }

        #endregion

        #region METODOS PRIVADOS
        private void cargarDatos(string strCc)
        {
            try
            {
                objConector = objCon.conectar();
                string inst = "SELECT pregunta, respuesta, clave FROM admon WHERE cedula = '" + strCc + "'";
                objTabla = objCon.consulta(inst, objConector);
                if (objTabla.Read())
                {
                    lblPregunta.Text = objTabla[0].ToString();
                    strRespuesta = objTabla[1].ToString();
                    strClave = objTabla[2].ToString();
                }
                objTabla.Close();
                objConector.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void consultar()
        {
            if (txtRespuesta.Text.Trim() != "")
            {
                if (txtRespuesta.Text.Trim() == strRespuesta)
                {
                    lblMsj.Text = "La clave es: " + strClave;
                    lblMsj.Visible = true;
                    gbPregunta.Enabled = false;
                }
                else
                {
                    lblMsj.Text = "Respuesta incorrecta";
                    lblMsj.Visible = true;
                }
            }
            else
            {
                lblMsj.Visible = true;
                lblMsj.Text = "Digite la respuesta";
            }
        }
        #endregion

        #region EVENTOS

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            consultar();   
        }
                
        private void pbVolver_Click(object sender, EventArgs e)
        {
            frmLogin objL = new frmLogin();
            this.Hide();
            objL.Show();
        }

        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                consultar();
            }
        }

        #endregion
        
    }
}
