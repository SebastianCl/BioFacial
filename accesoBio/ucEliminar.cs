using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace accesoBio
{
    public partial class ucEliminar : UserControl
    {
        clsConexion objCon = new clsConexion();
        clsCaracteres objCar = new clsCaracteres();
        private SqlConnection Conector;
        private SqlDataReader Tabla;
        public byte[] foto;
        public bool fot = false;
        string rol;


        public ucEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();    
        }

        private void buscar()
        {
            if (txtCedula.Text.Trim() != "")
            {
                try
                {
                    Conector = objCon.conectar();
                    string inst = "SELECT nombre, rostro, rol FROM usuario WHERE cedula= '" + txtCedula.Text.Trim() + "'";
                    Tabla = objCon.consulta(inst, Conector);

                    if (Tabla.Read())
                    {
                        gbInformacion.Visible = true;
                        lblMsj.Visible = false;
                        lblNombre.Text = Tabla[0].ToString();
                        lblNombre.Visible = true;  //muestro el nombre 
                        foto = (byte[])Tabla[1]; //guardo la imagen
                        fot = true;
                        rol = Tabla[2].ToString();
                        btnEliminar.Visible = true;
                        Tabla.Close();
                        Conector.Close();
                    }
                    else
                    {
                        gbInformacion.Visible = false;
                        lblNombre.Visible = false;
                        lblMsj.Visible = true;
                        lblMsj.Text = "El usuario no existe";
                        btnEliminar.Visible = false;
                        fot = false;
                        Tabla.Close();
                        Conector.Close();
                    }
                }
                catch (Exception)
                {
                    lblMsj.Visible = true;
                    lblMsj.Text = "Ocurrió un error";
                    fot = false;
                    btnEliminar.Visible = false;
                }
            }
            else
            {
                lblMsj.Text = "Ingrese una cédula para realizar la busqueda";
                lblMsj.Visible = true;
                gbInformacion.Visible = false;
                fot = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conector = objCon.conectar();
                string inst = "DELETE FROM usuario WHERE cedula= '" + txtCedula.Text.Trim() + "'"; //borro el registro de la tabla USUARIO
                SqlCommand cmd = new SqlCommand(inst, Conector);         
                cmd.ExecuteNonQuery();
                Conector.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (buscarADMON())
            {
                try
                {
                    Conector = objCon.conectar();
                    string inst = "DELETE FROM admon WHERE cedula= '" + txtCedula.Text.Trim() + "'"; //borro el registro de la tabla ADMON
                    SqlCommand cmd = new SqlCommand(inst, Conector);
                    cmd.ExecuteNonQuery();
                    Conector.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            lblMsj.Visible = true;
            lblMsj.Text = "REGISTRO ELIMINADO";
            fot = false;
            gbInformacion.Visible = false;
            btnEliminar.Visible = false;
        }

        private bool buscarADMON()
        {
            try
            {
                Conector = objCon.conectar();
                string inst = "SELECT * FROM admon WHERE cedula='" + txtCedula.Text.Trim() + "'";
                Tabla = objCon.consulta(inst, Conector);
                if (Tabla.Read())
                {
                    Conector.Close();
                    return true;
                }
                else
                {
                    Conector.Close();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloNumeros(e);
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }
    }
}
