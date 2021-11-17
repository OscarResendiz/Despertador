using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace DespertadorNET
{
    public delegate void OnDespertadorEvent();
    public partial class FormRepoructor : Form
    {
        private  int FOpaco;
        public event OnDespertadorEvent OnPlay;
        public event OnDespertadorEvent OnFin;
        public FormRepoructor()
        {
            InitializeComponent();
        }
        public void Play(string cancion)
        {
            try
            {
                this.ocxPlayer.URL = cancion;
            }
            catch (System.Exception ex)
            {
                if (OnFin != null)
                    OnFin();
            }
        }
        public string Cancion
        {
            get
            {
                return this.ocxPlayer.URL;
            }
        }
        public void Stop()
        {
            ocxPlayer.Ctlcontrols.stop();
        }
        public int Posision
        {
            get
            {
                return (int)ocxPlayer.Ctlcontrols.currentPosition;
            }
            set
            {
                ocxPlayer.Ctlcontrols.currentPosition = value;
            }
        }
        public void Pausa()
        {
            ocxPlayer.Ctlcontrols.pause();

        }
        public void Replay()
        {
            ocxPlayer.Ctlcontrols.play();
        }
        public int Volumen
        {
            get
            {
                return ocxPlayer.settings.volume;
            }
            set
            {
                ocxPlayer.settings.volume = value;
            }
        }

        private void ocxPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //e.newState=8  finalizado
            //e.newState=9 Medio abierto
            //e.newState=1 Detenido
            //e.newState=10 Listo
            //e.newState=3 Reproduciendo

            switch (e.newState)
            {
                case 1:
                    if (OnFin != null)
                        OnFin();
                    break;
                case 3:
                    if (OnPlay != null)
                        OnPlay();
                    timerPantallaCompleta.Enabled = true;
                    break;
            }
        }
        public int Duracion
        {
            get
            {
                if (ocxPlayer.currentMedia == null)
                    return 0;
                return (int)ocxPlayer.currentMedia.duration;
            }
        }

        private void FormRepoructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible == true)
            {
                Visible = false;
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timerPantallaCompleta_Tick(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                try
                {
                    ocxPlayer.fullScreen = PantallaCompleta;
                }
                catch (System.Exception)
                {
                    ;
                }
            }
            timerPantallaCompleta.Enabled = false;

        }
        private bool PantallaCompleta
        {
            get
            {
                //cargo el indicador de pantalla completa
                StreamReader sr;
                string s = DirectorioExcutable + "PantallaCompleta.txt";
                if (!System.IO.File.Exists(s))
                    return false;
                sr = System.IO.File.OpenText(s);
                s = sr.ReadLine();
                sr.Close();
                return(bool.Parse(s));

            }
        }
        public string DirectorioExcutable
        {
            get
            {
                string s = Application.ExecutablePath;// +"\\Canciones.txt";
                int i, n, ultimo = 0;
                n = s.Length;
                for (i = 0; i < n; i++)
                {
                    if (s[i] == '\\')
                        ultimo = i;
                }
                s = s.Substring(0, ultimo);
                return s + "\\";
            }
        }

        private void FormRepoructor_Load(object sender, EventArgs e)
        {
            FSiempreVisible = false;
        }
        private bool FSiempreVisible;
        public bool SiempreVisible
        {
            get
            {
                return FSiempreVisible;
            }
            set
            {
                FSiempreVisible = value;
                if (FSiempreVisible == true)
                {
                    WinApi.SiempreEncima(Handle.ToInt32());
                }
                else
                {
                    WinApi.NoSiempreEncima(Handle.ToInt32());
                }
            }
        }
        public int Opaco
        {
            get
            {
                return FOpaco;
            }
            set
            {
                FOpaco = value;
                Opacity = FOpaco * .01;
            }
        }
        private void FormRepoructor_MouseMove(object sender, MouseEventArgs e)
        {
            if (FOpaco == 100)
                return;
            //si esta casi al borde de la pantalla, recobra su opacidad
            int x=10;
            if (e.X <= Left + x || e.X >= Right - x || e.Y <= Top + x || e.Y >= Bottom - x)
            {
                //esta en uno de los bordes de la pantalla
                //recupera su opacidad
                Opacity = FOpaco * .01;
            }
            else
            {
                Opacity = 0;
            }
        }

        private void ocxPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (FOpaco == 100 || FOpaco==0)
                return;
            //si esta casi al borde de la pantalla, recobra su opacidad
            //int x = 10;
            //if (e.fX <= ocxPlayer.Left + x || e.fX >= ocxPlayer.Right - x || e.fY <= ocxPlayer.Top + x || e.fY >= ocxPlayer.Bottom - x)
            //{
            //    //esta en uno de los bordes de la pantalla
            //    //recupera su opacidad
            //    Opacity = FOpaco * .01;
            //}
            //else
            //{
                Opacity = 0;
                timerOpaciti.Enabled = false;
                timerOpaciti.Enabled = true;
            //}

        }

        private void timerOpaciti_Tick(object sender, EventArgs e)
        {
            timerOpaciti.Enabled = false;
            Opacity = FOpaco * .01;
        }
    }
}

