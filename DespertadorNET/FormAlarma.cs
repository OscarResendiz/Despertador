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
    public delegate void OnAlarmaEvent();
    public partial class FormAlarma : Form
    {
        public event OnAlarmaEvent OnAlarma;
        public event OnAlarmaEvent OnAnterior;
        public event OnAlarmaEvent OnPlayStop;
        public event OnAlarmaEvent OnSiguiente;
        public FormAlarma()
        {
            InitializeComponent();
            dateTimePicker1.Value = Hora;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s;
            int i, n,pos=0;
            s=System.DateTime.Now.TimeOfDay.ToString();
            //n = s.Length;
            //for (i = 0; i < n; i++)
            //{
            //    if (s[i] == '.')
            //        break;
            //}
            //
                n = s.Length;
            pos=0;
            for (i = 0; i < n; i++)
            {
                if (s[i] == ':')
                    pos = i;
            }
            LHora.Text = s.Substring(0, pos);
            string s2;
            s2 = dateTimePicker1.Value.TimeOfDay.ToString();
            n = s2.Length;
            pos = 0;
            for (i = 0; i < n; i++)
            {
                if (s2[i] == ':')
                    pos=i;
            }
            s2 = s2.Substring(0, pos);
            if (s2.Trim() == LHora.Text.Trim())
            {
                if (OnAlarma != null)
                {
                    OnAlarma();
                }
            }
        }

        private void FormAlarma_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Visible == true)
            //{
            //    Visible = false;
            //    e.Cancel = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hora=dateTimePicker1.Value ;
        }
        private System.DateTime Hora
        {
            get
            {
                System.DateTime pos = System.DateTime.Now;
                string s = DirectorioExcutable + "Hora.txt";
                StreamReader sr;
                if (!System.IO.File.Exists(s))
                    return System.DateTime.Now;
                sr = System.IO.File.OpenText(s);
                try
                {
                    pos = System.DateTime.Parse(sr.ReadLine());
                }
                catch (System.Exception)
                {
                    pos = System.DateTime.Now;
                }
                sr.Close();
                return pos;
            }
            set
            {
                string s = DirectorioExcutable + "Hora.txt";
                StreamWriter sw;
                sw = File.CreateText(s);
                sw.WriteLine(value.ToString());
                sw.Close();
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
        public void Muestrate()
        {
            formOpacador1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool rata;
        int X,Y;
        private void LHora_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rata = true;
                X= e.X;
                Y = e.Y;
            }
        }

        private void LHora_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rata = false;
            }
        }

        private void LHora_MouseMove(object sender, MouseEventArgs e)
        {
            if (rata == false)
                return;
            if (e.Button == MouseButtons.Left)
            {
                int dx, dy;
                Left+= e.X-X;
                Top+=e.Y-Y;

            }
        }

        private void LHora_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void BAtras_Click(object sender, EventArgs e)
        {
            if(OnAnterior!=null)
                OnAnterior();

        }

        private void BPlayStop_Click(object sender, EventArgs e)
        {
            if(OnPlayStop!=null)
                OnPlayStop();

        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if(OnSiguiente!=null)
                OnSiguiente();
        }
    }
}
