using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SqlClient;
using libDatos;

namespace accesoBio
{
    public partial class frmLogin : Form
    {
        #region ATRIBUTOS
        Image<Bgr, byte> marcoActual;
        Capture capturador;
        HaarCascade rostro;
        MCvFont fuente; 
        Image<Gray, byte> resultado;
        Image<Gray, byte> gris;
        List<Image<Gray, byte>> listaEntranamientoImagen;
        List<string> listaEtiqueta;
        int intTotalRegistros;
        string strRol, strCedula, strNomReconocido;

        clsConexion objCon;
        private SqlConnection objConector;
        #endregion

        #region CONSTRUCTOR
        public frmLogin()
        {
            InitializeComponent();
            fuente = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
            gris = null;
            listaEntranamientoImagen = new List<Image<Gray, byte>>();
            listaEtiqueta = new List<string>();
            objCon = new clsConexion();
            liveCam.ImageLocation = "img/default.png";

            rostro = new HaarCascade("haarcascade_frontalface_default.xml");    //cargo la deteccion de rostros por cascada
            cargarDatos();
        }
        #endregion

        #region METODOS PRIVADOS
        private void cargarDatos()
        {
            try
            {
                objConector = objCon.conectar();
                SqlDataReader TablaDatos = objCon.consultaSP("SP_datosUsuarios");
                intTotalRegistros = 0;

                while (TablaDatos.Read())
                {
                    intTotalRegistros = intTotalRegistros + 1;

                    byte[] rostro = (byte[])TablaDatos[0];
                    MemoryStream ms = new MemoryStream(rostro);
                    Image img = new Bitmap(ms);
                    Bitmap bmp = new Bitmap(img);
                    listaEntranamientoImagen.Add(new Image<Gray, byte>(bmp));

                    listaEtiqueta.Add(TablaDatos[1].ToString());
                }
                TablaDatos.Close();
                objConector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No hay información en la base de datos");
            }
        }
        private void confirmarIdentidad()
        {
            Application.Idle -= new EventHandler(frameg);
            capturador.Dispose();
            pbCamara.Enabled = true;
            lblMensaje.Visible = true;

            switch (strRol)
            {
                case "A":
                    lblMensaje.Text = "Bienvenido " + strNomReconocido;
                    gbClave.Visible = true;
                    break;
                case "U":
                    frmPrincipal objPrin = new frmPrincipal(strNomReconocido, strRol);
                    this.Hide();
                    objPrin.Show();
                    break;
                default:
                    lblMensaje.Text = "Usuario no identificado";
                    gbClave.Visible = false;
                    break;
            }
        }
        private void logueo()
        {
            if (txtContra.Text.Trim() != "")
            {
                objConector = objCon.conectar();
                SqlDataReader TablaClave = objCon.consultaSP("SP_loginAdmin", strCedula);

                if (TablaClave.Read())
                {
                    if (txtContra.Text.Trim() == TablaClave[0].ToString())
                    {
                        TablaClave.Close();
                        objConector.Close();
                        frmAdmin objAdmin = new frmAdmin(strNomReconocido);
                        objAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMensaje.Visible = true;
                        lblMensaje.Text = "Contraseña incorrecta";
                        TablaClave.Close();
                        objConector.Close();
                    }
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Por favor, ingrese la contraseña";
            }
        }
        #endregion

        #region EVENTOS

        void frameg(object sender, EventArgs e)
        {
            try
            {
                marcoActual = capturador.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC); //capturo la imagen actual de la camara

                gris = marcoActual.Convert<Gray, Byte>(); //convierto a gris

                //DETECTAR rostro
                MCvAvgComp[][] rostrosDetectados = gris.DetectHaarCascade(rostro, 1.2, 2, HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));

                //accion para cada elemento detectado
                foreach (MCvAvgComp f in rostrosDetectados[0])
                {
                    resultado = marcoActual.Copy(f.rect).Convert<Gray, byte>().Resize(150, 150, INTER.CV_INTER_CUBIC);  //min 100 max 200
                    marcoActual.Draw(f.rect, new Bgr(Color.DarkBlue), 4); //dibujo un cuadrado en el rostro detectado

                    if (listaEntranamientoImagen.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCrit = new MCvTermCriteria(intTotalRegistros, 0.001);

                        //RECONOCER rostro
                        EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(listaEntranamientoImagen.ToArray(), listaEtiqueta.ToArray(), 2800, ref termCrit);
                        strCedula = reconocedor.Recognize(resultado);  //intenta reconocer la imagen y devolver su etiqueta   
                        if (strCedula != "")
                        {
                            objConector = objCon.conectar();
                            SqlDataReader TablaNombres = objCon.consultaSP("SP_rostroDetectado", strCedula);
                            TablaNombres.Read();
                            strNomReconocido = TablaNombres[0].ToString();
                            strRol = TablaNombres[1].ToString();
                            TablaNombres.Close();
                            objConector.Close();
                            marcoActual.Draw(strNomReconocido, ref fuente, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.DarkRed)); //escribo el nombre                            
                        }
                        else
                        {
                            strRol = null;
                        }
                    }
                }
                liveCam.Image = marcoActual;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            logueo();
        }

        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            confirmarIdentidad();
        }

        private void lblClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            frmClave objC = new frmClave(strCedula);
            this.Hide();
            objC.Show();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                logueo();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void pbCamara_Click(object sender, EventArgs e)
        {
            capturador = new Capture();
            capturador.QueryFrame();
            Application.Idle += new EventHandler(frameg);
            pbCamara.Enabled = false;
            pbConfirmar.Enabled = true;
            pbConfirmar.Visible = true;
            lblMensaje.Visible = false;
        }        
        #endregion      
                
    }
}
