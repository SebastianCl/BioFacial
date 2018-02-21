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
namespace accesoBio
{
    public partial class frmAdmin : Form
    {
        Image<Bgr, byte> marcoActual;
        Capture capturador;
        HaarCascade rostro;
        MCvFont fuente = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> resultado, rostroEntrenado = null;
        Image<Gray, byte> gris = null;
        List<Image<Gray, byte>> listaEntranamientoImagen = new List<Image<Gray, byte>>();
        List<string> listaEtiqueta = new List<string>();
        List<string> listaNombres = new List<string>();
        List<string> listaNombrePersonas = new List<string>();
        int contadorEntrenamiento,t;
        string cedula, nombres = null, rol;
        int numFotoCap = 0;
        string nombreReconocido,nombreAdmin;

        clsConexion objCon = new clsConexion();
        private SqlConnection Conector;
                
        public frmAdmin(string nomAdmin)
        {
            nombreAdmin = nomAdmin;
            InitializeComponent();
            ucBuscar1.BringToFront();
            liveCam.ImageLocation = "img/default.png";
            //cargo la deteccion de rostros por cascada
            rostro = new HaarCascade("haarcascade_frontalface_default.xml");

            try
            {
                Conector = objCon.conectar();
                DataSet ds = new DataSet();

                string inst = "SELECT nombre, rostro, cedula FROM usuario";  //obtengo los datos principales   
                SqlDataReader TablaDatos = objCon.consulta(inst, Conector);
                int totalRegistros = 0;

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

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (ucBuscar1.fot && !ucModificar1.fot && !ucEliminar1.fot)
            {
                MemoryStream ms = new MemoryStream(ucBuscar1.foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto BUSCAR
            }

            if (ucModificar1.fot && !ucBuscar1.fot && !ucEliminar1.fot)
            {
                MemoryStream ms = new MemoryStream(ucModificar1.foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto en MODIFICAR
            }
            if (ucEliminar1.fot && !ucBuscar1.fot && !ucModificar1.fot)
            {
                MemoryStream ms = new MemoryStream(ucEliminar1.foto);
                Image img = new Bitmap(ms);
                Bitmap bmp = new Bitmap(img);
                imbFoto.Image = new Image<Gray, byte>(bmp); //muestro la foto en ELIMINAR
            }

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (numFotoCap < 10)
            {
                pbLiveCam.Enabled = false;
                try
                {
                    contadorEntrenamiento++;
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
                    listaEtiqueta.Add(ucRegistrar1.cedula);

                    //muestro el rostro agregado en gris
                    imbFoto.Image = rostroEntrenado;

                    try
                    {
                        Image Img = imbFoto.Image.Bitmap;
                        Bitmap bmp = new Bitmap(Img);
                        MemoryStream MyStream = new MemoryStream();
                        bmp.Save(MyStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] imagepic = MyStream.ToArray();

                        Conector = objCon.conectar();
                        string inst = "INSERT INTO usuario (nombre,rostro,cedula,rol) VALUES(@nombre,@rostro,@cedula,@rol)";
                        SqlCommand cmd = new SqlCommand(inst, Conector);
                        cmd.Parameters.AddWithValue("@nombre", ucRegistrar1.nombre);
                        cmd.Parameters.AddWithValue("@rostro", imagepic);
                        cmd.Parameters.AddWithValue("@cedula", ucRegistrar1.cedula);                        
                        cmd.Parameters.AddWithValue("@rol", ucRegistrar1.rol);
                        cmd.ExecuteNonQuery();
                        Conector.Close();

                        MessageBox.Show("Los datos de " + ucRegistrar1.nombre + " fueron procesados y agregados", "Entrenimiento realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numFotoCap++;
                        MessageBox.Show("Capturas faltantes: " + (10 - numFotoCap));
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
            if (numFotoCap == 10)
            {
                numFotoCap = 0;
                
                if (ucRegistrar1.rol == "A")
                {
                    try
                    {
                        Conector = objCon.conectar();
                        string inst = "INSERT INTO admon (cedula,pregunta,respuesta,clave) VALUES (@cedula,@pregunta,@respuesta,@clave)";
                        SqlCommand cmd = new SqlCommand(inst, Conector);
                        cmd.Parameters.AddWithValue("@cedula", ucRegistrar1.cedula);
                        cmd.Parameters.AddWithValue("@pregunta", ucRegistrar1.pregunta);
                        cmd.Parameters.AddWithValue("@respuesta", ucRegistrar1.respuesta);
                        cmd.Parameters.AddWithValue("@clave", ucRegistrar1.clave);
                        cmd.ExecuteNonQuery();
                        Conector.Close();                       
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
                ucRegistrar1.act = false;
                btnCapturar.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin objL = new frmLogin();
            this.Hide();
            objL.Show();
        }       

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal objPrin = new frmPrincipal(nombreAdmin, "A");
            this.Hide();
            objPrin.Show();
        }

        private void pbLiveCam_Click(object sender, EventArgs e) //ACTIVAR LA CAMARA
        {
            if (ucRegistrar1.act)
            {
                capturador = new Capture();
                capturador.QueryFrame();
                Application.Idle += new EventHandler(frameg);
                btnCapturar.Visible = true;
                pbLiveCam.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBuscar.Height;
            SidePanel.Top = btnBuscar.Top;
            ucBuscar1.BringToFront();
            ucModificar1.fot = false;
            ucEliminar1.fot = false;
        }

        private void pbOFF_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Visible)
            {
                Application.Idle -= new EventHandler(frameg);
                capturador.Dispose();
                btnCapturar.Visible = false;
                ucRegistrar1.act = false;
                pbLiveCam.Visible = true;
                pbLiveCam.Enabled = true;
            }
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
            ucBuscar1.fot = false;
            ucEliminar1.fot = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEliminar.Height;
            SidePanel.Top = btnEliminar.Top;
            ucEliminar1.BringToFront();
            ucBuscar1.fot = false;
            ucBuscar1.fot = false;
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
                        MCvTermCriteria termCrit = new MCvTermCriteria(contadorEntrenamiento, 0.001);

                        //RECONOCER rostro
                        EigenObjectRecognizer reconocedor = new EigenObjectRecognizer(listaEntranamientoImagen.ToArray(), listaEtiqueta.ToArray(), 2500, ref termCrit);
                        cedula = reconocedor.Recognize(resultado);

                        if (cedula != "")
                        {
                            Conector = objCon.conectar();
                            string inst = "SELECT nombre,rol FROM usuario WHERE cedula= '" + cedula + "'";
                            SqlDataReader TablaNombres = objCon.consulta(inst, Conector);
                            TablaNombres.Read();
                            nombreReconocido = TablaNombres[0].ToString();
                            rol = TablaNombres[1].ToString();
                            TablaNombres.Close();
                            Conector.Close();
                            //marcoActual.Draw(nombreReconocido, ref fuente, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.DarkRed));//escribo el nombre
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
