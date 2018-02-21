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
    public partial class ucBuscar : UserControl
    {
        clsConexion objCon = new clsConexion();
        clsCaracteres objCar = new clsCaracteres();
        private SqlConnection Conector;
        private SqlDataReader Tabla;
        public byte[] foto;
        public bool fot = false;


        public ucBuscar()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
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
