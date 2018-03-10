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
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using libDatos;

namespace accesoBio
{
    public partial class frmAdmin : Form
    {

        #region ATRIBUTOS
        Image<Bgr, byte> marcoActual;
        Capture capturador;
        HaarCascade rostro;
        MCvFont fuente;
        Image<Gray, byte> resultado, rostroEntrenado,gris;        
        List<Image<Gray, byte>> listaEntranamientoImagen;
        List<string> listaEtiqueta;
        List<string> listaNombres;
        int intTotalRegistros;

        int intContadorEntrenamiento, intNumFotoCap;
        string strCedula, strRol, strNombreReconocido, strNombreAdmin;
        clsConexion objCon;
        private SqlConnection objConector;
        #endregion

        #region CONSTRUCTOR
        public frmAdmin(string nomAdmin)
        {
            InitializeComponent();
            fuente = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
            rostroEntrenado = null;
            gris = null;
            listaEntranamientoImagen = new List<Image<Gray, byte>>();
            listaEtiqueta = new List<string>();
            listaNombres = new List<string>();
            intNumFotoCap = 0;
            objCon = new clsConexion();
            strNombreAdmin = nomAdmin;
            ucBuscar1.BringToFront();
            liveCam.ImageLocation = "img/default.png";

            rostro = new HaarCascade("haarcascade_frontalface_default.xml");    //cargo la detección de rostros por cascada
            cargarDatos();
            
        }
        #endregion

        #region EVENTOS
        
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (ucBuscar1.Fot && !ucModificar1.Fot && !ucEliminar1.Fot)
            {
                MemoryStream ms = new MemoryStream(ucBuscar1.Foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto BUSCAR
            }

            if (ucModificar1.Fot && !ucBuscar1.Fot && !ucEliminar1.Fot)
            {
                MemoryStream ms = new MemoryStream(ucModificar1.Foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto en MODIFICAR
            }
            if (ucEliminar1.Fot && !ucBuscar1.Fot && !ucModificar1.Fot)
            {
                MemoryStream ms = new MemoryStream(ucEliminar1.Foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto en ELIMINAR
            }

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            capturar();
        }                

        private void pbLiveCam_Click(object sender, EventArgs e) //ACTIVAR LA CAMARA
        {
            if (ucRegistrar1.Act)
            {
                capturador = new Capture();
                capturador.QueryFrame();
                Application.Idle += new EventHandler(frameg);
                btnCapturar.Visible = true;
                pbLiveCam.Visible = false;
                
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal objPrin = new frmPrincipal(strNombreAdmin, "A");
            this.Hide();
            objPrin.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBuscar.Height;
            SidePanel.Top = btnBuscar.Top;
            ucBuscar1.BringToFront();
            ucModificar1.Fot = false;
            ucEliminar1.Fot = false;
        }                

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRegistro.Height;
            SidePanel.Top = btnRegistro.Top;
            ucRegistrar1.BringToFront();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnModificar.Height;
            SidePanel.Top = btnModificar.Top;
            ucModificar1.BringToFront();
            ucBuscar1.Fot = false;
            ucEliminar1.Fot = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEliminar.Height;
            SidePanel.Top = btnEliminar.Top;
            ucEliminar1.BringToFront();
            ucBuscar1.Fot = false;
            ucBuscar1.Fot = false;
        }

        private void pbOFF_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Visible)
            {
                Application.Idle -= new EventHandler(frameg);
                capturador.Dispose();
                btnCapturar.Visible = false;
                ucRegistrar1.Act = false;
                pbLiveCam.Visible = true;
                pbLiveCam.Enabled = true;
            }
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
                        MCvTermCriteria termCrit = new MCvTermCriteria(intContadorEntrenamiento, 0.001);

                        //RECONOCER rostro
                        EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(listaEntranamientoImagen.ToArray(), listaEtiqueta.ToArray(), 2500, ref termCrit);
                        strCedula = reconocedor.Recognize(resultado);                        

                        if (strCedula != "")
                        {
                            objConector = objCon.conectar();
                            string inst = "SELECT nombre,rol FROM usuario WHERE cedula= '" + strCedula + "'";
                            SqlDataReader TablaNombres = objCon.consulta(inst, objConector);
                            TablaNombres.Read();
                            strNombreReconocido = TablaNombres[0].ToString();
                            strRol = TablaNombres[1].ToString();
                            TablaNombres.Close();
                            objConector.Close();                            
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
        private void capturar()
        {
            if (intNumFotoCap < 5)
            {
                pbLiveCam.Enabled = false;
                try
                {
                    intContadorEntrenamiento++;
                    gris = capturador.QueryGrayFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);

                    //DETECTO el rostro
                    MCvAvgComp[][] rostrosDetectados = gris.DetectHaarCascade(rostro, 1.2, 10,
                        HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));

                    foreach (MCvAvgComp f in rostrosDetectados[0])
                    {
                        rostroEntrenado = marcoActual.Copy(f.rect).Convert<Gray, byte>();
                        break;
                    }
                    rostroEntrenado = resultado.Resize(150, 150, INTER.CV_INTER_CUBIC);//reajusto el tamaño para comparar
                    listaEntranamientoImagen.Add(rostroEntrenado);
                    listaEtiqueta.Add(ucRegistrar1.Cedula);

                    //muestro el rostro agregado en gris
                    imbFoto.Image = rostroEntrenado;

                    try
                    {
                        Image Img = imbFoto.Image.Bitmap;
                        Bitmap bmp = new Bitmap(Img);
                        MemoryStream MyStream = new MemoryStream();
                        bmp.Save(MyStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] imagepic = MyStream.ToArray();

                        objConector = objCon.conectar();
                        string inst = "INSERT INTO usuario (nombre,rostro,cedula,rol) VALUES(@nombre,@rostro,@cedula,@rol)";
                        SqlCommand cmd = new SqlCommand(inst, objConector);
                        cmd.Parameters.AddWithValue("@nombre", ucRegistrar1.Nombre);
                        cmd.Parameters.AddWithValue("@rostro", imagepic);
                        cmd.Parameters.AddWithValue("@cedula", ucRegistrar1.Cedula);
                        cmd.Parameters.AddWithValue("@rol", ucRegistrar1.Rol);
                        cmd.ExecuteNonQuery();
                        objConector.Close();

                        MessageBox.Show("Los datos de " + ucRegistrar1.Nombre + " fueron procesados y agregados", "Entrenimiento realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        intNumFotoCap++;
                        MessageBox.Show("Capturas faltantes: " + (5 - intNumFotoCap));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Active la detección de rostro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (intNumFotoCap == 5)
            {
                intNumFotoCap = 0;

                if (ucRegistrar1.Rol == "A")
                {
                    try
                    {
                        objConector = objCon.conectar();
                        string inst = "INSERT INTO admon (cedula,pregunta,respuesta,clave) VALUES (@cedula,@pregunta,@respuesta,@clave)";
                        SqlCommand cmd = new SqlCommand(inst, objConector);
                        cmd.Parameters.AddWithValue("@cedula", ucRegistrar1.Cedula);
                        cmd.Parameters.AddWithValue("@pregunta", ucRegistrar1.Pregunta);
                        cmd.Parameters.AddWithValue("@respuesta", ucRegistrar1.Respuesta);
                        cmd.Parameters.AddWithValue("@clave", ucRegistrar1.Clave);
                        cmd.ExecuteNonQuery();
                        objConector.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Application.Idle -= new EventHandler(frameg);
                capturador.Dispose();
                liveCam.ImageLocation = "img/default.png";
                pbLiveCam.Visible = true;
                pbLiveCam.Enabled = true;
                ucRegistrar1.Act = false;
                btnCapturar.Visible = false;
            }
        }
        #endregion


    }
}
