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
    public partial class ucModificar : UserControl
    {
        clsConexion objCon = new clsConexion();
        clsCaracteres objCar = new clsCaracteres();
        private SqlConnection Conector;
        private SqlDataReader Tabla;
        public byte[] foto;
        public bool fot = false;


        public ucModificar()
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
                    string inst = "SELECT nombre, rostro, cedula, rol FROM usuario WHERE cedula= '" + txtCedula.Text.Trim() + "'";
                    Tabla = objCon.consulta(inst, Conector);

                    if (Tabla.Read())
                    {
                        gbTipo.Visible = true;
                        gbDatos.Visible = true;
                        gbTipo.Enabled = false;
                        gbDatos.Enabled = false;
                        gbSeguridad.Visible = false;
                        btnGuardar.Enabled = false;
                        btnDeshacer.Enabled = false;
                        txtNombre.Text = Tabla[0].ToString();
                        txtCedula.Text = Tabla[2].ToString();
                        txtCc.Text = txtCedula.Text.Trim();
                        foto = (byte[])Tabla[1]; //guardo la imagen
                        fot = true;
                        lblMsj.Text = "";
                        if (Tabla[3].ToString().Equals("U"))
                        {
                            rdbUsuario.Checked = true;
                            Tabla.Close();
                        }
                        else
                        {
                            Tabla.Close();
                            rdbAdmin.Checked = true;
                            gbSeguridad.Visible = true;
                            gbSeguridad.Enabled = false;
                            inst = "SELECT pregunta, respuesta, clave FROM admon WHERE cedula = '" + txtCedula.Text.Trim() + "'";
                            SqlDataReader TablaSeg = objCon.consulta(inst, Conector);
                            if (TablaSeg.Read())
                            {
                                txtPregunta.Text = TablaSeg[0].ToString();
                                txtRespuesta.Text = TablaSeg[1].ToString();
                                txtClave1.Text = TablaSeg[2].ToString();
                                txtClave2.Visible = false;
                                lblClave2.Visible = false;
                            }
                            TablaSeg.Close();
                        }
                        Conector.Close();
                        btnEditar.Visible = true;
                        btnEditar.Enabled = true;
                    }
                    else
                    {
                        lblMsj.Visible = true;
                        lblMsj.Text = "El usuario no existe";
                        gbDatos.Visible = false;
                        gbSeguridad.Visible = false;
                        gbTipo.Visible = false;
                        btnEditar.Visible = false;
                        btnGuardar.Visible = false;
                        btnDeshacer.Visible = false;
                        fot = false;
                        Tabla.Close();
                        Conector.Close();
                    }
                }
                catch (Exception)
                {
                    lblMsj.Visible = true;
                    lblMsj.Text = "Ocurrió un error";
                }
            }
            else
            {
                lblMsj.Text = "Ingrese una cédula para realizar la busqueda";
                lblMsj.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnDeshacer.Visible = true;
            btnGuardar.Enabled = true;
            btnDeshacer.Enabled = true;
            gbTipo.Enabled = true;
            gbDatos.Enabled = true;
            gbSeguridad.Enabled = true;
            lblClave2.Visible = true;
            txtClave2.Visible = true;
            gbCedula.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void rdbUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            gbSeguridad.Visible = false;
            gbDatos.Visible = true;
        }

        private void rdbAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            gbSeguridad.Visible = true;
            gbDatos.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rdbUsuario.Checked) //ACTUALIZAR USUARIO
            {
                if (!validarDatos())
                {
                    lblMsj.Visible = true;
                    return;
                }
                if (buscarADMON())
                {
                    actualizarUSUARIO("U"); //si era administrador el rol cambia a U
                    try
                    {
                        Conector = objCon.conectar();
                        string inst="DELETE FROM admon WHERE cedula= '" + txtCedula.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(inst,Conector);         //borro el registro de la tabla ADMON
                        cmd.ExecuteNonQuery();
                        Conector.Close();                        
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    actualizarUSUARIO("U"); //si era usuario el rol queda igual
                }                
                gbCedula.Enabled = true;
                gbCedula.Text = "";
                gbDatos.Visible = false;
                gbTipo.Visible = false;
                btnEditar.Visible = false;
                gbSeguridad.Visible = false;
                btnDeshacer.Visible = false;
                btnGuardar.Visible = false;
            }

            if (rdbAdmin.Checked)       //ACTUALIZAR ADMINISTRADOR
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
                actualizarUSUARIO("A");                
                try
                {                    
                    string inst;                    
                    if (buscarADMON())
                    {
                        Conector = objCon.conectar();
                        inst = "UPDATE admon SET cedula='" + txtCc.Text.Trim() + "', pregunta='" + txtPregunta.Text.Trim() +
                                    "', respuesta='" + txtRespuesta.Text.Trim() + "', clave='" + txtClave1.Text.Trim() +
                                    "' WHERE cedula = '" + txtCedula.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(inst, Conector);
                        cmd.ExecuteNonQuery();
                        Conector.Close();
                    }
                    else
                    {
                        Conector = objCon.conectar();
                        inst = "INSERT INTO admon (cedula,pregunta,respuesta,clave) VALUES(@cedula,@pregunta,@respuesta,@clave)";
                        SqlCommand cmd = new SqlCommand(inst, Conector);
                        cmd.Parameters.AddWithValue("@cedula", txtCc.Text.Trim());
                        cmd.Parameters.AddWithValue("@pregunta", txtPregunta.Text.Trim());
                        cmd.Parameters.AddWithValue("@respuesta", txtRespuesta.Text.Trim());
                        cmd.Parameters.AddWithValue("@clave", txtClave1.Text.Trim());
                        cmd.ExecuteNonQuery();
                        Conector.Close();
                    }                    
                    lblMsj.Text = "ADMINISTRADOR ACTUALIZADO";
                    lblMsj.Visible = true;
                    gbCedula.Enabled = true;
                    gbCedula.Text = "";
                    gbDatos.Visible = false;
                    gbTipo.Visible = false;
                    btnEditar.Visible = false;
                    gbSeguridad.Visible = false;
                    btnDeshacer.Visible = false;
                    btnGuardar.Visible = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (txtCc.Text.Trim() == "")
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
                lblMsj.Text = "Ingrese la contraseña";
                return false;
            }
            if (txtClave2.Text.Trim() == "")
            {
                lblMsj.Text = "Debe confirmar la contraseña";
                return false;
            }
            if (txtPregunta.Text.Trim() == "")
            {
                lblMsj.Text = "Ingrese la pregunta";
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
        #endregion

        private void actualizarUSUARIO(string rol)
        {
            try
            {
                Conector = objCon.conectar();
                string inst = "UPDATE usuario SET nombre='" + txtNombre.Text.Trim() + "', cedula='" + txtCc.Text.Trim() +
                                "', rol='" + rol + "' WHERE cedula = '" + txtCedula.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(inst, Conector);
                cmd.ExecuteNonQuery();
                Conector.Close();
                lblMsj.Text = "REGISTRO ACTUALIZADO";
                lblMsj.Visible = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool buscarADMON()
        {
            try
            {
                Conector = objCon.conectar();
                string inst = "SELECT * FROM ADMON WHERE cedula='" +txtCedula.Text.Trim() + "'";
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

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            lblMsj.Visible = false;
            gbCedula.Enabled = true;
            gbTipo.Visible = false;
            gbDatos.Visible = false;
            gbSeguridad.Visible = false;
            btnEditar.Visible = false;
            btnGuardar.Visible = false;
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCc.Text = "";
            txtClave1.Text = "";
            txtClave2.Text = "";
            txtPregunta.Text = "";
            txtRespuesta.Text = "";
            btnDeshacer.Visible = false;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloNumeros(e);
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloLetras(e);
        }

        private void txtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            objCar.SoloNumeros(e);
        }
    }
}
