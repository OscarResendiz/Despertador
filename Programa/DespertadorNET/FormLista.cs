using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace DespertadorNET
{
    enum estatusLista
    {
        abriendo=0,
        Cerrado,
        abierto
    };
    public partial class FormLista : Form
    {
        CNodo Raiz;
        CNodo RaizVideos;
        FormDestino Destino;
        IntPtr ResulHook;
        int WH_KEYBOARD;
        estatusLista estatus;
        List<string> Directorios;
       public  FormRepoructor Repoructor;
       List<CCancion> Musica;
       List<CCancion> Videos;
        public FormLista(FormDestino destino)
        {
            Musica = new List<CCancion>();
            Videos = new List<CCancion>();
            Destino = destino;
            WH_KEYBOARD = 2;
            estatus = estatusLista.Cerrado;
            InitializeComponent();
            Repoructor = new FormRepoructor();
            Repoructor.OnPlay += new OnDespertadorEvent(OnPlay);
            Repoructor.OnFin += new OnDespertadorEvent(OnFin);
            RBMusica.Checked = MusicaOVIdeo;
            RBVideos.Checked = !RBMusica.Checked;
            CargaCanciones();
            CargaVideos();
            Program.ki.KeyPress += new KeyPressEventHandler(kh_KeyPress);
            Program.ki.KeyDown += new KeyEventHandler(ki_KeyDown);
            Program.ki.KeyUp += new KeyEventHandler(ki_KeyUp);
        }
        public string DirectorioExcutable
        {
            get
            {
                string s = Application.ExecutablePath;// +"\\Canciones.txt";
                int i, n,ultimo=0;
                n = s.Length;
                for (i = 0; i < n; i++)
                {
                    if (s[i] == '\\')
                        ultimo = i;
                }
                s = s.Substring(0, ultimo);
                return s+"\\";
            }
        }
        private void OnPlay()
        {
            estatus = estatusLista.abierto;
                Repoructor.Replay();
        }
        private void OnFin()
        {
            TimerSiguiente.Enabled = true;
            //if (estatus != estatusLista.abriendo)
            //{
            //    //me paso a la siguiente cancion
            //    estatus = estatusLista.abriendo;
            //    BSigiente_Click(null, null);
            //}
        }

        private void FormLista_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        public void Siguiente()
        {
            if (ListaCanciones.SelectedIndex == -1)
            {
                if (ListaCanciones.Items.Count > Actual)
                    ListaCanciones.SelectedIndex = Actual;
                else
                {
                    ListaCanciones.SelectedIndex = ListaCanciones.Items.Count - 1;
                    Actual = ListaCanciones.SelectedIndex;
                }
            }
            if (ListaCanciones.SelectedIndex < ListaCanciones.Items.Count - 1)
            {
                ListaCanciones.SelectedIndex++;
            }
            else
            {
                if (ListaCanciones.Items.Count > 0)
                    ListaCanciones.SelectedIndex = 0;
            }
            ListaCanciones_MouseDoubleClick(null, null);
        }
        private void BSigiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }
        public void Anterior()
        {
            if (ListaCanciones.SelectedIndex > 0)
            {
                ListaCanciones.SelectedIndex--;
            }
            else
            {
                ListaCanciones.SelectedIndex = ListaCanciones.Items.Count - 1;
            }
            ListaCanciones_MouseDoubleClick(null, null);
        }
        private void BAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }
        public void PlayStop()
        {
            if (BPausa.Text == "||")
            {
                Repoructor.Pausa();
                BPausa.Text = ">";
            }
            else
            {
                if (Repoructor.Cancion == "")
                {
                    ListaCanciones_MouseDoubleClick(null, null);
                    BPausa.Text = "||";
                    return;
                }
                try
                {
                    Repoructor.Replay();
                }
                catch (System.Exception)
                {
                    ListaCanciones_MouseDoubleClick(null, null);
                    BPausa.Text = "||";
                    return;
                }
                BPausa.Text = "||";
            }
        }
        private void BPausa_Click(object sender, EventArgs e)
        {
            PlayStop();
        }


        private void buscarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directorios == null)
                Directorios = new List<string>();
            Directorios.Clear();
            System.IO.DriveInfo[] dribers = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo s in dribers)
            {
                Directorios.Add(s.ToString());
            }
            TBuscar.Enabled = true;
        }
        private void TBuscar_Tick(object sender, EventArgs e)
        {
            if (Directorios == null)
            {
                TBuscar.Enabled = false;
                label1.Text = "";
                return;
            }
            if(Directorios.Count==0)
            {
                TBuscar.Enabled = false;
                label1.Text = "";
                return;
            }
            string path = Directorios[0];
            label1.Text = path;
            Directorios.RemoveAt(0);
            string[] Archivos;
            try
            {
                Archivos = Directory.GetFiles(path);
            }
            catch (System.Exception)
            {
                return;
            }
            foreach (string s in Archivos)
            {
                string sx = s.Substring(s.Length - 3).ToLower().Trim();
                if (RBMusica.Checked == true)
                {
                    if (sx == "mp3")
                    {
                        //es un mp3, 
                        CCancion obj = new CCancion();
                        obj.Path = s;
                        AgregaCancion(obj);
                    }
                }
                else
                {
                    if (sx == "wmv" || sx == "mpg" || sx == "avi" )
                    {
                        //es un mp3, 
                        CCancion obj = new CCancion();
                        obj.Path = s;
                        AgregaVideo(obj);
                    }
                }
            }
            //agregolos directorios a la lista
            string []directorios = Directory.GetDirectories(path);
            foreach (string dir in directorios)
            {
                Directorios.Add(dir);
            }
        }


        private void TimerSiguiente_Tick(object sender, EventArgs e)
        {
            BSigiente_Click(null, null);
            TimerSiguiente.Enabled = false;
        }
        private int Actual
        {
            get
            {
                int pos = 0;
                string s = "";
                if(RBMusica.Checked==true)
                    s=DirectorioExcutable + "Actual.txt";
                else
                    s = DirectorioExcutable + "ActualV.txt";
                StreamReader sr;
                if (!System.IO.File.Exists(s))
                    return pos;
                sr = System.IO.File.OpenText(s);
                try
                {
                    pos = int.Parse(sr.ReadLine());
                }
                catch (System.Exception)
                {
                    pos = 0;
                }
                sr.Close();
                return pos;
            }
            set
            {
                string s = "";
                if (RBMusica.Checked == true)
                    s = DirectorioExcutable + "Actual.txt";
                else
                    s = DirectorioExcutable + "ActualV.txt";
                StreamWriter sw;
                sw = File.CreateText(s);
                sw.WriteLine(ListaCanciones.SelectedIndex.ToString());
                sw.Close();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedIndex == -1)
                return;
            CCancion obj = (CCancion)ListaCanciones.Items[ListaCanciones.SelectedIndex];
            if (RBMusica.Checked == true)
            {
                if (Raiz != null)
                    Raiz.Borra(obj.Path);
                Musica.Remove(obj);
            }
            else
            {
                if (RaizVideos != null)
                    RaizVideos.Borra(obj.Path);
                Videos.Remove(obj);
            }
            ListaCanciones.Items.RemoveAt(ListaCanciones.SelectedIndex);
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCanciones.Items.Clear();
            Raiz = null;
            Actual = 0;
            if (RBMusica.Checked == true)
            {
                Musica.Clear();
            }
            else
            {
                Videos.Clear();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Visible == true)
                Visible = false;
        }

        private void TimerProgreso_Tick(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Maximum = Repoructor.Duracion;
                trackBar1.Value = Repoructor.Posision;
            }
            catch (System.Exception)
            {
                return;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Repoructor.Pausa();
            Repoructor.Posision = trackBar1.Value;
            Repoructor.Replay();
        }

        private void verReproductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repoructor.Show();
            Repoructor.SiempreVisible = reporductorSiempreVisibleToolStripMenuItem.Checked;
        }
        public void Play()
        {
            ListaCanciones_MouseDoubleClick(null, null);
            //Repoructor.Replay();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ListaCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCanciones.SelectedIndex == -1)
                return;
            CCancion obj = (CCancion)ListaCanciones.Items[ListaCanciones.SelectedIndex];
            label1.Text = obj.Path;
        }
        private void ListaCanciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //reporducir la cancion
            if (ListaCanciones.SelectedIndex == -1)
            {
                try
                {
                    ListaCanciones.SelectedIndex = Actual;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (ListaCanciones.SelectedIndex == -1)
            {
                if (ListaCanciones.Items.Count > 0)
                {
                    ListaCanciones.SelectedIndex = 0;
                    Actual = 0;
                }
                else
                {
                    //no hay nada en la lista de canciones
                    //por lo que mejor me pongo a buscar
                    buscarCancionesToolStripMenuItem_Click(null, null);
                    Visible = true;
                    return;
                }
            }
            CCancion obj = (CCancion)ListaCanciones.Items[ListaCanciones.SelectedIndex];
            if (File.Exists(obj.Path) == false)
            {
                int tmp = ListaCanciones.SelectedIndex;
                // se salta la cancion
                eliminarToolStripMenuItem_Click(null, null);
                guardarToolStripMenuItem_Click(null, null);
                if (tmp < ListaCanciones.Items.Count)
                {
                    ListaCanciones.SelectedIndex = tmp;
                    ListaCanciones_MouseDoubleClick(null, null);
                }
                return;
            }
            Repoructor.Play(obj.Path);
            Actual = ListaCanciones.SelectedIndex;
        }
        private void kh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // put here code for key press 
        }

        private void ki_KeyDown(object sender, KeyEventArgs e)
         {
            // put here code for key down 
             if (e.KeyValue == 179)
             {
                 BPausa_Click(null, null);
                 //MessageBox.Show("PLAY");
             }
             if (e.KeyValue == 178)
             {
                 //como no funciona bien que digamos este boton, lo voy a utilizar para copiar a una unidad la camcion actual
                 CopiaCancion();
              //   Repoructor.Stop();
              //   BPausa.Text = ">";
              ////   MessageBox.Show("STOP");
             }
             if (e.KeyValue == 177)
             {
                 BAnterior_Click(null, null);
                 //MessageBox.Show("ANTERIOR");
             }
             if (e.KeyValue == 176)
             {
                 BSigiente_Click(null, null);
                 //MessageBox.Show("SIGUIENTE");
             }
         }

        private void ki_KeyUp(object sender, KeyEventArgs e)
        {
            // put here code for key up 
        }
        private void CopiaCancion()
        {
            if(ListaCanciones.SelectedIndex==-1)
                return;
            CCancion obj = (CCancion)ListaCanciones.Items[ListaCanciones.SelectedIndex];
            try
            {
                File.Copy(obj.Path, Destino.Path + "\\" + obj.ToString());
            }
            catch (System.Exception)
            {
                return;
            }
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string s in openFileDialog1.FileNames)
            {
                
                CCancion obj = new CCancion();
                obj.Path = s;
                if (RBMusica.Checked == true)
                {

                    AgregaCancion(obj);
                }
                else
                {
                    AgregaVideo(obj);
                }
            }
        }

        private void buacarEnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (Directorios == null)
                Directorios = new List<string>();
            Directorios.Clear();
            Directorios.Add(folderBrowserDialog1.SelectedPath);
            TBuscar.Enabled = true;
        }

        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallaCompletaToolStripMenuItem.Checked = !pantallaCompletaToolStripMenuItem.Checked;
            string s = DirectorioExcutable + "PantallaCompleta.txt";
            StreamWriter sw;
            sw = File.CreateText(s);
            sw.WriteLine(pantallaCompletaToolStripMenuItem.Checked.ToString());
            sw.Close();
        }
        private void FormLista_Load(object sender, EventArgs e)
        {
            try
            {
                ListaCanciones.SelectedIndex = Actual;
            }
            catch (System.Exception)
            {
                if (ListaCanciones.Items.Count > 0)
                {
                    ListaCanciones.SelectedIndex = 0;
                    Actual = 0;
                }
            }
            //cargo el indicador de pantalla completa
            StreamReader sr;
            string s = DirectorioExcutable + "PantallaCompleta.txt";
            if (!System.IO.File.Exists(s))
                return;
            sr = System.IO.File.OpenText(s);
             s= sr.ReadLine();
            sr.Close();
            pantallaCompletaToolStripMenuItem.Checked = bool.Parse(s);

            //cargo el indicador de siempre visible
            s = DirectorioExcutable + "Siemprevisible.txt";
            if (!System.IO.File.Exists(s))
                return;
            sr = System.IO.File.OpenText(s);
            s = sr.ReadLine();
            sr.Close();
            reporductorSiempreVisibleToolStripMenuItem.Checked = bool.Parse(s);
        }

        private void reporductorSiempreVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporductorSiempreVisibleToolStripMenuItem.Checked = !reporductorSiempreVisibleToolStripMenuItem.Checked;
            string s = DirectorioExcutable + "Siemprevisible.txt";
            StreamWriter sw;
            sw = File.CreateText(s);
            sw.WriteLine(reporductorSiempreVisibleToolStripMenuItem.Checked.ToString());
            sw.Close();
            Repoructor.SiempreVisible = reporductorSiempreVisibleToolStripMenuItem.Checked;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Repoructor.Opaco = Trasparencia.Value;
        }

        private void RBMusica_CheckedChanged(object sender, EventArgs e)
        {
            MusicaOVIdeo = RBMusica.Checked;
        }
        private bool MusicaOVIdeo
        {
            get
            {
                StreamReader sr;
                string s = DirectorioExcutable + "MusicaVideo.txt";
                if (!System.IO.File.Exists(s))
                    return true; //regresa musica
                sr = System.IO.File.OpenText(s);
                s = sr.ReadLine();
                sr.Close();
                bool ok;
                try
                {
                    ok=bool.Parse(s);
                }
                catch(System.Exception ex)
                {

                    return false;
                }
                return ok;
            }
            set
            {
                string s = DirectorioExcutable + "MusicaVideo.txt";
                StreamWriter sw;
                sw = File.CreateText(s);
                sw.WriteLine(value.ToString());
                sw.Close();
                //ahora hago el cambio en la lista
                ListaCanciones.Items.Clear();
                if (value == true)
                {
                    //hay que poner la musica
                    foreach (CCancion obj in Musica)
                    {
                        ListaCanciones.Items.Add(obj);
                    }
                }
                else
                {
                    //son videos
                    foreach (CCancion obj in Videos)
                    {
                        ListaCanciones.Items.Add(obj);
                    }
                }
                try
                {
                    ListaCanciones.SelectedIndex = Actual;
                }
                catch (System.Exception ex)
                {
                    return;
                }
            }
        }

        private void RBVideos_CheckedChanged(object sender, EventArgs e)
        {
            MusicaOVIdeo = RBMusica.Checked;
        }
        private void CargaCanciones()
        {
            string s = DirectorioExcutable + "Canciones.txt";
            List<CCancion> Canciones;
            Canciones = new List<CCancion>();
            StreamReader sr;
            if (!System.IO.File.Exists(s))
                return;
            sr = System.IO.File.OpenText(s);
            while (sr.Peek() > 0)
            {
                CCancion obj = new CCancion();
                obj.Path = sr.ReadLine();
                AgregaCancion(obj);
            }
            sr.Close();
        }
        private void CargaVideos()
        {
            string s = DirectorioExcutable + "Videos.txt";
            List<CCancion> Canciones;
            Canciones = new List<CCancion>();
            StreamReader sr;
            if (!System.IO.File.Exists(s))
                return;
            sr = System.IO.File.OpenText(s);
            while (sr.Peek() > 0)
            {
                CCancion obj = new CCancion();
                obj.Path = sr.ReadLine();
                AgregaVideo(obj);
            }
            sr.Close();
        }
        private void AgregaCancion(CCancion obj)
        {
            if (Raiz == null)
            {
                Raiz = new CNodo(obj.Path);
            }
            if (Raiz.Buscar(obj.Path) == true)
                return;
            if (Musica == null)
                Musica = new List<CCancion>();
            Musica.Add(obj);
            if (RBMusica.Checked == true)
            {
                ListaCanciones.Items.Add(obj);
            }
        }
        private void AgregaVideo(CCancion obj)
        {
            if (RaizVideos == null)
            {
                RaizVideos = new CNodo(obj.Path);
            }
            if (RaizVideos.Buscar(obj.Path) == true)
                return;
            if (Videos == null)
                Videos = new List<CCancion>();
            Videos.Add(obj);
            if (RBVideos.Checked == true)
            {
                ListaCanciones.Items.Add(obj);
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = DirectorioExcutable + "Canciones.txt";
            StreamWriter sw;
            sw = File.CreateText(s);
            foreach (CCancion obj in Musica)
            {
                sw.WriteLine(obj.Path);
            }
            sw.Close();
            //ahora gusrado los videos
            s = DirectorioExcutable + "Videos.txt";
            sw=null;
            sw = File.CreateText(s);
            foreach (CCancion obj in Videos)
            {
                sw.WriteLine(obj.Path);
            }
            sw.Close();
        }
        bool rata;
        int X, Y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rata = true;
                X = e.X;
                Y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rata = false;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rata == false)
                return;
            Left += e.X - X;
            Top += e.Y - Y;
        }
        public void Muestrate()
        {
            formOpacador1.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ListaCanciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                eliminarToolStripMenuItem_Click(null, null);
                ListaCanciones_MouseDoubleClick(null, null);
                return;
            }
            switch(e.KeyCode)
            {
                case Keys.F1:
                    Repoructor.Posision = (10 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F2:
                    Repoructor.Posision = (20 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F3:
                    Repoructor.Posision = (30 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F4:
                    Repoructor.Posision = (40 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F5:
                    Repoructor.Posision = (50 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F6:
                    Repoructor.Posision = (60 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F7:
                    Repoructor.Posision = (70 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F8:
                    Repoructor.Posision = (80 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F9:
                    Repoructor.Posision = (90 * Repoructor.Duracion) / 100;
                    break;
                case Keys.F10:
                    Repoructor.Posision = (98 * Repoructor.Duracion) / 100;
                    break;

            }
        }
    }
}
