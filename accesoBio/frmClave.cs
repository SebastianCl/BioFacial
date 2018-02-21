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

namespace accesoBio
{
    public partial class frmClave : Form
    {
        clsConexion objCon = new clsConexion();
        private SqlConnection Conector;
        private SqlDataReader Tabla;
        string respuesta;
        string clave;        

        public frmClave(string cedula)
        {
            InitializeComponent();            
            try
            {
                Conector = objCon.conectar();
                string inst = "SELECT pregunta, respuesta, clave FROM admon WHERE cedula = '" + cedula + "'";                
                Tabla = objCon.consulta(inst, Conector);
                if (Tabla.Read())
                {
                    lblPregunta.Text = Tabla[0].ToString();
                    respuesta = Tabla[1].ToString();
                    clave = Tabla[2].ToString();
                }
                Tabla.Close();
                Conector.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            consultar();   
        }

        private void consultar()
        {
            if (txtRespuesta.Text.Trim() != "")
            {
                if (txtRespuesta.Text.Trim() == respuesta)
                {
                    lblMsj.Text = "La clave es: " + clave;
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
    }
}
