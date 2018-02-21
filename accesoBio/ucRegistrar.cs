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
    public partial class ucRegistrar : UserControl
    {
        public string nombre, cedula, rol,clave,pregunta,respuesta;
        public byte[] foto;
        public bool act = false;
        clsConexion objCon = new clsConexion();
        clsCaracteres objCar = new clsCaracteres();
        private SqlConnection Conector;
        SqlDataReader Tabla;


        public ucRegistrar()
        {
            InitializeComponent();
        }       
        

        private void rdbAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            gbTipo.Enabled = false;
            gbDatos.Enabled = true;
            gbSeguridad.Visible = true;
            gbSeguridad.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void rdbUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            gbTipo.Enabled = false;
            gbDatos.Enabled = true;
            gbSeguridad.Visible = false;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblMsj.Text = "";
            gbTipo.Enabled = true;
            gbDatos.Enabled = false;
            gbSeguridad.Visible = false;
            btnGuardar.Enabled = false;            
            act = false;
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtClave1.Text = "";
            txtClave2.Text = "";
            txtPregunta.Text = "";
            txtRespuesta.Text = "";
            rdbAdmin.Checked = false;
            rdbUsuario.Checked = false;
            btnLimpiar.Enabled = false;       
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloLetras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloNumeros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e) //guardo los datos 
        {
            if (buscarUsuario())
            {
                lblMsj.Visible = true;
                lblMsj.Text = "El usuario ya se encuentra registrado";
            }
            else
            {
                lblMsj.Text = "";
                if (rdbUsuario.Checked)
                {
                    if (!validarDatos())
                    {
                        lblMsj.Visible = true;
                        return;
                    }
                    nombre = txtNombre.Text.Trim();
                    cedula = txtCedula.Text.Trim();
                    rol = "U";

                    act = true;
                    gbDatos.Enabled = false;
                    gbTipo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnLimpiar.Enabled = true;
                }
                if (rdbAdmin.Checked)
                {
                    if (!validarDatos())
                    {
                        lblMsj.Visible = true;
                        return;
                    }
                    if (!validarSeguridad())
                    {
                        lblMsj.Visible = true;
                        return;
                    }
                    if (!validarClaves())
                    {
                        lblMsj.Visible = true;
                        return;
                    }
                    nombre = txtNombre.Text.Trim();
                    cedula = txtCedula.Text.Trim();
                    rol = "A";
                    clave = txtClave1.Text.Trim();
                    pregunta = txtPregunta.Text.Trim();
                    respuesta = txtRespuesta.Text.Trim();
                    act = true;
                    gbDatos.Enabled = false;
                    gbSeguridad.Enabled = false;
                    gbTipo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnLimpiar.Enabled = true;
                }
            }
        }

        #region VALIDACIONES
        private bool validarDatos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese el nombre";
                return false;
            }
            if (txtCedula.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese la cédula";
                return false;
            }
            return true;
        }
        private bool validarSeguridad()
        {
            if (txtClave1.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese la clave";
                return false;
            }
            if (txtClave2.Text.Trim() == "")
            {
                lblMsj.Text = "Debe confirmar la clave";
                return false;
            }
            if (txtPregunta.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese la pregunta de seguridad";
                return false;
            }
            if (txtRespuesta.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese la respuesta";
                return false;
            }
            return true;
        }
        private bool validarClaves()
        {
            if (txtClave1.Text.Trim() == txtClave2.Text.Trim())
            {
                return true;
            }
            lblMsj.Text = "Las contraseñas no coinciden";
            return false;
        }
        private bool buscarUsuario()
        {
            try
            {
                Conector = objCon.conectar();
                string inst = "SELECT * FROM usuario WHERE cedula='" + txtCedula.Text.Trim() + "'";
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
    }
}
