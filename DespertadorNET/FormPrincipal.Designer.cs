namespace DespertadorNET
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.apagarMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarAlarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorioDestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSiguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnterior = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Despertador NET";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarMonitorToolStripMenuItem,
            this.reporducirToolStripMenuItem,
            this.configurarAlarmaToolStripMenuItem,
            this.directorioDestiToolStripMenuItem,
            this.MenuSiguiente,
            this.MenuPlay,
            this.MenuAnterior,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 180);
            // 
            // apagarMonitorToolStripMenuItem
            // 
            this.apagarMonitorToolStripMenuItem.Name = "apagarMonitorToolStripMenuItem";
            this.apagarMonitorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.apagarMonitorToolStripMenuItem.Text = "Apagar Monitor";
            this.apagarMonitorToolStripMenuItem.Click += new System.EventHandler(this.apagarMonitorToolStripMenuItem_Click);
            // 
            // reporducirToolStripMenuItem
            // 
            this.reporducirToolStripMenuItem.Name = "reporducirToolStripMenuItem";
            this.reporducirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reporducirToolStripMenuItem.Text = "Lista de canciones";
            this.reporducirToolStripMenuItem.Click += new System.EventHandler(this.reporducirToolStripMenuItem_Click);
            // 
            // configurarAlarmaToolStripMenuItem
            // 
            this.configurarAlarmaToolStripMenuItem.Name = "configurarAlarmaToolStripMenuItem";
            this.configurarAlarmaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.configurarAlarmaToolStripMenuItem.Text = "Configurar Alarma";
            this.configurarAlarmaToolStripMenuItem.Click += new System.EventHandler(this.configurarAlarmaToolStripMenuItem_Click);
            // 
            // directorioDestiToolStripMenuItem
            // 
            this.directorioDestiToolStripMenuItem.Name = "directorioDestiToolStripMenuItem";
            this.directorioDestiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.directorioDestiToolStripMenuItem.Text = "Directorio destino";
            this.directorioDestiToolStripMenuItem.Click += new System.EventHandler(this.directorioDestiToolStripMenuItem_Click);
            // 
            // MenuSiguiente
            // 
            this.MenuSiguiente.Name = "MenuSiguiente";
            this.MenuSiguiente.Size = new System.Drawing.Size(172, 22);
            this.MenuSiguiente.Text = ">>";
            this.MenuSiguiente.Click += new System.EventHandler(this.MenuSiguiente_Click);
            // 
            // MenuPlay
            // 
            this.MenuPlay.Name = "MenuPlay";
            this.MenuPlay.Size = new System.Drawing.Size(172, 22);
            this.MenuPlay.Text = "||>";
            this.MenuPlay.Click += new System.EventHandler(this.MenuPlay_Click);
            // 
            // MenuAnterior
            // 
            this.MenuAnterior.Name = "MenuAnterior";
            this.MenuAnterior.Size = new System.Drawing.Size(172, 22);
            this.MenuAnterior.Text = "<<";
            this.MenuAnterior.Click += new System.EventHandler(this.MenuAnterior_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DespertadorNET.Properties.Resources.despertador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 308);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem apagarMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporducirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem configurarAlarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorioDestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSiguiente;
        private System.Windows.Forms.ToolStripMenuItem MenuPlay;
        private System.Windows.Forms.ToolStripMenuItem MenuAnterior;
    }
}

