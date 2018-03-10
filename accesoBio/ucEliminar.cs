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
using libDatos;


namespace accesoBio
{
    public partial class ucEliminar : UserControl
    {
        #region ATRIBUTOS
        clsConexion objCon;
        clsCaracteres objCar;
        private SqlConnection Conector;
        private SqlDataReader Tabla;
        byte[] foto;
        bool fot;
        #endregion

        #region PROPIEDADES

        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public bool Fot
        {
            get
            {
                return fot;
            }

            set
            {
                fot = value;
            }
        }
        #endregion

        #region CONSTRUCTOR

        public ucEliminar()
        {
            InitializeComponent();
            objCon = new clsConexion();
            objCar = new clsCaracteres();
            fot = false;
        }
        #endregion

        #region METODOS PRIVADOS               
        private void eliminar()
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

        private void buscar()
        {
            if (txtCedula.Text.Trim() != "")
            {
                try
                {
                    Conector = objCon.conectar();
                    string inst = "SELECT nombre, rostro FROM usuario WHERE cedula= '" + txtCedula.Text.Trim() + "'";
                    Tabla = objCon.consulta(inst, Conector);

                    if (Tabla.Read())
                    {
                        gbInformacion.Visible = true;
                        lblMsj.Visible = false;
                        lblNombre.Text = Tabla[0].ToString();
                        lblNombre.Visible = true;  //muestro el nombre 
                        foto = (byte[])Tabla[1]; //guardo la imagen
                        fot = true;
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
        #endregion

        #region EVENTOS

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Los datos del usuario seran borrados \r ¿Desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                eliminar();
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

        #endregion

    }
}
