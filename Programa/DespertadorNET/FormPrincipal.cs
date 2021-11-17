using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DespertadorNET
{
    public partial class FormPrincipal : Form
    {
        FormLista Lista;
        FormAlarma Alarma;
        CMonitor Monitor;
        FormDestino Destino;
        public FormPrincipal()
        {
            Monitor = new CMonitor(Handle);
            Alarma = new FormAlarma();
            Alarma.OnAlarma += new OnAlarmaEvent(OnAlarma);
            InitializeComponent();
            Destino = new FormDestino();
            Lista = new FormLista(Destino);
            Alarma.OnAnterior+=new OnAlarmaEvent(Anterior);
            Alarma.OnPlayStop+=new OnAlarmaEvent(PlayStop);
            Alarma.OnSiguiente+=new OnAlarmaEvent(Siguiente);

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista.Repoructor.Visible = false;
            Lista.Visible = false;
            Alarma.Visible = false;

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Visible = false;
        }

        private void apagarMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monitor.ApagaMonitor();          
        }

        private void reporducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista.Muestrate();
        }

        private void configurarAlarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alarma.Muestrate();
        }
        private void OnAlarma()
        {
            Monitor.Enciende();            
            Lista.Play();
            Alarma.Muestrate();
        }

        private void directorioDestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destino.Muestrate();
        }

        private void MenuPlay_Click(object sender, EventArgs e)
        {
            PlayStop();
        }

        private void MenuSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void MenuAnterior_Click(object sender, EventArgs e)
        {
            Anterior();
        }
        private void Anterior()
        {
            Lista.Anterior();
        }
        private void PlayStop()
        {
            Lista.PlayStop();
        }
        private void Siguiente()
        {
            Lista.Siguiente();
        }

    }
}
