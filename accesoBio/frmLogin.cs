using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SqlClient;

namespace accesoBio
{
    public partial class frmLogin : Form
    {
        Image<Bgr, byte> marcoActual;
        Capture capturador;
        HaarCascade rostro;
        MCvFont fuente = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> resultado;
        Image<Gray, byte> gris = null;
        List<Image<Gray, byte>> listaEntranamientoImagen = new List<Image<Gray, byte>>();
        List<string> listaEtiqueta = new List<string>();
        List<string> listaNombres = new List<string>();
        List<string> listaNombrePersonas = new List<string>();
        int  totalRegistros,t;
        string rol,nombres;
        string cedula, nomReconocido;

        clsConexion objCon = new clsConexion();        
        private SqlConnection Conector;
        

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim() != "")
            {
                Conector = objCon.conectar();
                string inst = "SELECT clave FROM admon WHERE cedula = '" + cedula + "'";
                SqlDataReader TablaClave = objCon.consulta(inst, Conector);
                
                if (TablaClave.Read())
                {
                    if (txtContra.Text.Trim() == TablaClave[0].ToString())
                    {
                        TablaClave.Close();
                        Conector.Close();
                        frmAdmin objAdmin = new frmAdmin(nomReconocido);
                        objAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMensaje.Visible = true;
                        lblMensaje.Text = "Contraseña incorrecta";
                        TablaClave.Close();
                        Conector.Close();
                    }
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Por favor, ingrese la contraseña";
            }            
        }

        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(frameg);
            capturador.Dispose();
            pbCamara.Enabled = true;            
            lblMensaje.Visible = true;

            switch (rol)
            {
                case "A":
                    lblMensaje.Text = "Bienvenido " + nomReconocido;
                    gbClave.Visible = true;
                    pbAnim.Visible = true;             
                    break;
                case "U":
                    frmPrincipal objPrin = new frmPrincipal(nomReconocido,rol);
                    this.Hide();
                    objPrin.Show();                    
                    break;
                default:
                    lblMensaje.Text = "Aún no estas registrado";
                    gbClave.Visible = false;
                    pbAnim.Visible = false;
                    break;
            }
        }

        private void lblClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            frmClave objC = new frmClave(cedula);
            this.Hide();
            objC.Show();
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
        }
        

        public frmLogin()
        {
            InitializeComponent();
            liveCam.ImageLocation = "img/default.png";
            //cargo la deteccion de rostros por cascada
            rostro = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                Conector = objCon.conectar();

                string inst = "SELECT nombre, rostro, cedula FROM usuario";  //obtengo los datos principales 
                SqlDataReader TablaDatos = objCon.consulta(inst, Conector);
                totalRegistros = 0;

                while (TablaDatos.Read())
                {
                    totalRegistros = totalRegistros + 1;

                    listaNombres.Add(TablaDatos[0].ToString());
                    listaEtiqueta.Add(TablaDatos[2].ToString());

                    byte[] rostro = (byte[])TablaDatos[1];
                    MemoryStream ms = new MemoryStream(rostro);
                    Image img = new Bitmap(ms);
                    Bitmap bmp = new Bitmap(img);
                    listaEntranamientoImagen.Add(new Image<Gray, byte>(bmp));
                }
                TablaDatos.Close();
                Conector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("No hay información en la base de datos");
            }
        }

        void frameg(object sender, EventArgs e)
        {
            listaNombrePersonas.Add("");

            try
            {
                marcoActual = capturador.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC); //capturo la imagen actual de la camara

                gris = marcoActual.Convert<Gray, Byte>(); //convierto a gris

                //DETECTAR rostro
                MCvAvgComp[][] rostrosDetectados = gris.DetectHaarCascade(rostro, 1.2, 10, HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));


                //accion para cada elemento detectado
                foreach (MCvAvgComp f in rostrosDetectados[0])
                {
                    t++;
                    resultado = marcoActual.Copy(f.rect).Convert<Gray, byte>().Resize(150, 150, INTER.CV_INTER_CUBIC);  //min 100 max 200
                    marcoActual.Draw(f.rect, new Bgr(Color.DarkBlue), 4); //dibujo un cuadrado en el rostro detectado

                    if (listaEntranamientoImagen.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCrit = new MCvTermCriteria(totalRegistros, 0.001);

                        //RECONOCER rostro
                        EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(listaEntranamientoImagen.ToArray(), listaEtiqueta.ToArray(), 2800, ref termCrit);
                        cedula = reconocedor.Recognize(resultado);//Intenta reconocer la imagen y devolver su etiqueta   

                        if (cedula != "")
                        {
                            Conector = objCon.conectar();
                            string inst = "SELECT nombre, rol FROM usuario WHERE cedula= '" + cedula + "'";
                            SqlDataReader TablaNombres = objCon.consulta(inst, Conector);
                            TablaNombres.Read();
                            nomReconocido = TablaNombres[0].ToString();
                            rol = TablaNombres[1].ToString();
                            TablaNombres.Close();
                            Conector.Close();
                            marcoActual.Draw(nomReconocido, ref fuente, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.DarkRed));//escribo el nombre                            
                        }
                        else
                        {
                            rol = null;
                        }
                    }

                    listaNombrePersonas[t - 1] = cedula;
                    listaNombrePersonas.Add("");
                }
                t = 0;

                //muestro el nombre de los rostros reconocidos
                for (int nn = 0; nn < rostrosDetectados[0].Length; nn++)
                {
                    nombres = nombres + listaNombrePersonas[nn];
                }
                nombres = "";

                liveCam.Image = marcoActual;    
                listaNombrePersonas.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
