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
    public partial class ucBuscar : UserControl
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
        public ucBuscar()
        {
            InitializeComponent();
            objCon = new clsConexion();
            objCar = new clsCaracteres();
            fot = false;
        }

        #endregion

        #region METODOS PRIVADOS
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
                        foto = (byte[])Tabla[1]; //guardo la imagen en un array
                        fot = true;
                        if (Tabla[2].ToString() == "A")
                        {
                            pbCheck.Visible = true;
                        }
                        else
                        {
                            pbCheck.Visible = false;
                        }
                        Tabla.Close();
                        Conector.Close();
                    }
                    else
                    {
                        gbInformacion.Visible = false;
                        lblNombre.Visible = false;
                        lblMsj.Visible = true;
                        lblMsj.Text = "El usuario no existe";
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
        #endregion

        #region EVENTOS

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            buscar();
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
