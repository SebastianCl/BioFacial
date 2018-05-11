using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SqlClient;
using libDatos;

namespace accesoBio
{
    public partial class frmPrincipal : Form
    {
        #region ATRIBUTOS

        Image<Bgr, byte> imgMarcoActual;
        Capture capturador;
        HaarCascade rostro;
        MCvFont fuente = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> imgResultado;
        Image<Gray, byte> imgGris = null;
        List<Image<Gray, byte>> listaEntranamientoImagen = new List<Image<Gray, byte>>();
        List<string> listaEtiqueta = new List<string>();
        List<string> listaNombres = new List<string>();        
        int intTotalRegistros;
        string strRol2 = "", strNomReconocido, strNomAdmin, strCedula;
        private SqlConnection objConector;
        clsConexion objCon = new clsConexion();

        #endregion

        #region CONSTRUCTOR

        public frmPrincipal(string nomReconocido, string rol)
        {
            InitializeComponent();
            strRol2 = rol;
            lblNombre.Text = "Bienvenido \n" + nomReconocido;
            if (rol.Equals("U"))
            {
                lblVista.Text = "Vista de USUARIO";
                btnMenuAdmin.Visible = false;
            }
            else
            {
                lblVista.Text = "Vista de ADMINISTRADOR";
                btnMenuAdmin.Visible = true;
                strNomAdmin = nomReconocido;
            }
            liveCam.ImageLocation = "img/default.png";

            rostro = new HaarCascade("haarcascade_frontalface_default.xml");    //cargo la deteccion de rostros por cascada

            try
            {
                objConector = objCon.conectar();

                string inst = "SELECT nombre, rostro, cedula FROM usuario";  //obtengo los datos principales 
                SqlDataReader TablaDatos = objCon.consulta(inst, objConector);
                intTotalRegistros = 0;

                while (TablaDatos.Read())
                {
                    intTotalRegistros = intTotalRegistros + 1;

                    listaNombres.Add(TablaDatos[0].ToString());
                    listaEtiqueta.Add(TablaDatos[2].ToString());

                    byte[] rostro = (byte[])TablaDatos[1];
                    MemoryStream ms = new MemoryStream(rostro);
                    Image img = new Bitmap(ms);
                    Bitmap bmp = new Bitmap(img);
                    listaEntranamientoImagen.Add(new Image<Gray, byte>(bmp));
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
        #endregion

        #region EVENTOS

        private void btnActivar_Click(object sender, EventArgs e)
        {
            switch (btnActivar.Text)
            {
                case "ACTIVAR RECONOCIMIENTO MULTIPLE":
                    capturador = new Capture();
                    capturador.QueryFrame();
                    Application.Idle += new EventHandler(frameg);
                    pbAni1.Visible = true;
                    pbAni2.Visible = true;

                    btnActivar.Text = "DESACTIVAR";
                    btnActivar.BackColor = Color.FromArgb(255, 102, 102);
                    btnSalir.Visible = false;
                    lblVista.Visible = false;
                    btnMenuAdmin.Visible = false;
                    break;
                case "DESACTIVAR":
                    Application.Idle -= new EventHandler(frameg);
                    capturador.Dispose();
                    liveCam.ImageLocation = "img/default.png";
                    pbAni1.Visible = false;
                    pbAni2.Visible = false;

                    btnActivar.Text = "ACTIVAR RECONOCIMIENTO MULTIPLE";
                    btnActivar.BackColor = Color.Honeydew;
                    btnSalir.Visible = true;
                    lblVista.Visible = true;
                    if (strRol2.Equals("A"))
                    {
                        btnMenuAdmin.Visible = true;
                    }
                    break;
            }
        }

        private void btnMenuAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin objAd = new frmAdmin(strNomAdmin);
            this.Hide();
            objAd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin objL = new frmLogin();
            this.Hide();
            objL.Show();
        }

        void frameg(object sender, EventArgs e)
        {
            try
            {
                imgMarcoActual = capturador.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC); //capturo la imagen actual de la camara

                imgGris = imgMarcoActual.Convert<Gray, Byte>(); //convierto a gris

                //DETECTAR rostro
                MCvAvgComp[][] rostrosDetectados = imgGris.DetectHaarCascade(rostro, 1.2, 2, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));


                //accion para cada elemento detectado
                foreach (MCvAvgComp f in rostrosDetectados[0])
                {
                    imgResultado = imgMarcoActual.Copy(f.rect).Convert<Gray, byte>().Resize(150, 150, INTER.CV_INTER_CUBIC);  //min 100 max 200
                    imgMarcoActual.Draw(f.rect, new Bgr(Color.DarkBlue), 4); //dibujo un cuadrado en el rostro detectado

                    if (listaEntranamientoImagen.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCrit = new MCvTermCriteria(intTotalRegistros, 0.001);

                        //RECONOCER rostro
                        EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(listaEntranamientoImagen.ToArray(), listaEtiqueta.ToArray(), 2500, ref termCrit);
                        strCedula = reconocedor.Recognize(imgResultado);//Intenta reconocer la imagen y devolver su etiqueta   

                        if (strCedula != "")
                        {
                            objConector = objCon.conectar();
                            string inst = "SELECT nombre FROM usuario WHERE cedula= '" + strCedula + "'";
                            SqlDataReader TablaNombres = objCon.consulta(inst, objConector);
                            TablaNombres.Read();
                            strNomReconocido = TablaNombres[0].ToString();
                            TablaNombres.Close();
                            objConector.Close();
                            imgMarcoActual.Draw(strNomReconocido, ref fuente, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.DarkRed));//escribo el nombre                            
                        }
                    }
                }
                liveCam.Image = imgMarcoActual;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion       
        
    }
}
