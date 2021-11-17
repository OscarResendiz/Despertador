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
    public partial class FormDestino : Form
    {
        public FormDestino()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            TDestino.Text = folderBrowserDialog1.SelectedPath;
        }
        public string Path
        {
            get
            {
                if (File.Exists("Destino.txt") == false)
                {
                    return "";
                }
                StreamReader sr;
                sr = File.OpenText("Destino.txt");
                string s = sr.ReadLine();
                sr.Close();
                return s;
            }
            set
            {
                StreamWriter sw;
                sw=File.CreateText("Destino.txt");
                sw.WriteLine(value);
                sw.Close();
            }
        }

        private void FormDestino_Load(object sender, EventArgs e)
        {
            TDestino.Text = Path;
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Path = TDestino.Text;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ok=true;
            if (TDestino.Text.Trim() == "")
                ok = false;
            BAceptar.Enabled = ok;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDestino_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Visible == true)
            //{
            //    Visible = false;
            //    e.Cancel = true;               
            //}
        }
        public void Muestrate()
        {
            formOpacador1.Visible = true;
        }
    }
}
