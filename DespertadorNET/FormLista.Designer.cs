namespace DespertadorNET
{
    partial class FormLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLista));
            this.ListaCanciones = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buacarEnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporductorSiempreVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RBVideos = new System.Windows.Forms.RadioButton();
            this.RBMusica = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Trasparencia = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BPausa = new System.Windows.Forms.Button();
            this.BSigiente = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TBuscar = new System.Windows.Forms.Timer(this.components);
            this.TimerSiguiente = new System.Windows.Forms.Timer(this.components);
            this.TimerProgreso = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.formOpacador1 = new Opacador.FormOpacador(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trasparencia)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaCanciones
            // 
            this.ListaCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListaCanciones.ContextMenuStrip = this.contextMenuStrip1;
            this.ListaCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ListaCanciones.FormattingEnabled = true;
            this.ListaCanciones.Location = new System.Drawing.Point(0, 0);
            this.ListaCanciones.Name = "ListaCanciones";
            this.ListaCanciones.Size = new System.Drawing.Size(327, 486);
            this.ListaCanciones.TabIndex = 0;
            this.ListaCanciones.SelectedIndexChanged += new System.EventHandler(this.ListaCanciones_SelectedIndexChanged);
            this.ListaCanciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListaCanciones_KeyUp);
            this.ListaCanciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaCanciones_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buacarEnToolStripMenuItem,
            this.buscarCancionesToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.verReproductorToolStripMenuItem,
            this.pantallaCompletaToolStripMenuItem,
            this.reporductorSiempreVisibleToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 224);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buacarEnToolStripMenuItem
            // 
            this.buacarEnToolStripMenuItem.Name = "buacarEnToolStripMenuItem";
            this.buacarEnToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.buacarEnToolStripMenuItem.Text = "Buacar en";
            this.buacarEnToolStripMenuItem.Click += new System.EventHandler(this.buacarEnToolStripMenuItem_Click);
            // 
            // buscarCancionesToolStripMenuItem
            // 
            this.buscarCancionesToolStripMenuItem.Name = "buscarCancionesToolStripMenuItem";
            this.buscarCancionesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.buscarCancionesToolStripMenuItem.Text = "Buscar Canciones";
            this.buscarCancionesToolStripMenuItem.Click += new System.EventHandler(this.buscarCancionesToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // verReproductorToolStripMenuItem
            // 
            this.verReproductorToolStripMenuItem.Name = "verReproductorToolStripMenuItem";
            this.verReproductorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.verReproductorToolStripMenuItem.Text = "Ver Reproductor";
            this.verReproductorToolStripMenuItem.Click += new System.EventHandler(this.verReproductorToolStripMenuItem_Click);
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pantallaCompletaToolStripMenuItem.Text = "Pantalla Completa";
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.pantallaCompletaToolStripMenuItem_Click);
            // 
            // reporductorSiempreVisibleToolStripMenuItem
            // 
            this.reporductorSiempreVisibleToolStripMenuItem.Name = "reporductorSiempreVisibleToolStripMenuItem";
            this.reporductorSiempreVisibleToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reporductorSiempreVisibleToolStripMenuItem.Text = "Reporductor siempre visible";
            this.reporductorSiempreVisibleToolStripMenuItem.Click += new System.EventHandler(this.reporductorSiempreVisibleToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RBVideos);
            this.panel1.Controls.Add(this.RBMusica);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Trasparencia);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BPausa);
            this.panel1.Controls.Add(this.BSigiente);
            this.panel1.Controls.Add(this.BAnterior);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 189);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(238, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBVideos
            // 
            this.RBVideos.AutoSize = true;
            this.RBVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RBVideos.Location = new System.Drawing.Point(117, 132);
            this.RBVideos.Name = "RBVideos";
            this.RBVideos.Size = new System.Drawing.Size(57, 17);
            this.RBVideos.TabIndex = 9;
            this.RBVideos.TabStop = true;
            this.RBVideos.Text = "Videos";
            this.RBVideos.UseVisualStyleBackColor = true;
            this.RBVideos.CheckedChanged += new System.EventHandler(this.RBVideos_CheckedChanged);
            // 
            // RBMusica
            // 
            this.RBMusica.AutoSize = true;
            this.RBMusica.Checked = true;
            this.RBMusica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RBMusica.Location = new System.Drawing.Point(12, 132);
            this.RBMusica.Name = "RBMusica";
            this.RBMusica.Size = new System.Drawing.Size(59, 17);
            this.RBMusica.TabIndex = 8;
            this.RBMusica.TabStop = true;
            this.RBMusica.Text = "Musica";
            this.RBMusica.UseVisualStyleBackColor = true;
            this.RBMusica.CheckedChanged += new System.EventHandler(this.RBMusica_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "transparencia";
            // 
            // Trasparencia
            // 
            this.Trasparencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Trasparencia.Location = new System.Drawing.Point(3, 89);
            this.Trasparencia.Maximum = 100;
            this.Trasparencia.Name = "Trasparencia";
            this.Trasparencia.Size = new System.Drawing.Size(312, 45);
            this.Trasparencia.TabIndex = 6;
            this.Trasparencia.Value = 100;
            this.Trasparencia.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 37);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // BPausa
            // 
            this.BPausa.BackColor = System.Drawing.Color.Black;
            this.BPausa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BPausa.Location = new System.Drawing.Point(81, 35);
            this.BPausa.Name = "BPausa";
            this.BPausa.Size = new System.Drawing.Size(75, 23);
            this.BPausa.TabIndex = 3;
            this.BPausa.Text = ">";
            this.BPausa.UseVisualStyleBackColor = false;
            this.BPausa.Click += new System.EventHandler(this.BPausa_Click);
            // 
            // BSigiente
            // 
            this.BSigiente.BackColor = System.Drawing.Color.Black;
            this.BSigiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BSigiente.Location = new System.Drawing.Point(162, 35);
            this.BSigiente.Name = "BSigiente";
            this.BSigiente.Size = new System.Drawing.Size(75, 23);
            this.BSigiente.TabIndex = 2;
            this.BSigiente.Text = ">>";
            this.BSigiente.UseVisualStyleBackColor = false;
            this.BSigiente.Click += new System.EventHandler(this.BSigiente_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.BackColor = System.Drawing.Color.Black;
            this.BAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BAnterior.Location = new System.Drawing.Point(0, 35);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(75, 23);
            this.BAnterior.TabIndex = 1;
            this.BAnterior.Text = "<<";
            this.BAnterior.UseVisualStyleBackColor = false;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(323, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // TBuscar
            // 
            this.TBuscar.Tick += new System.EventHandler(this.TBuscar_Tick);
            // 
            // TimerSiguiente
            // 
            this.TimerSiguiente.Interval = 300;
            this.TimerSiguiente.Tick += new System.EventHandler(this.TimerSiguiente_Tick);
            // 
            // TimerProgreso
            // 
            this.TimerProgreso.Enabled = true;
            this.TimerProgreso.Tick += new System.EventHandler(this.TimerProgreso_Tick);
            // 
            // formOpacador1
            // 
            this.formOpacador1.AutoCerrar = false;
            this.formOpacador1.Degradado = true;
            this.formOpacador1.Formulario = this;
            this.formOpacador1.ModoGradiente = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.formOpacador1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formOpacador1.SegundoColor = System.Drawing.Color.Black;
            this.formOpacador1.Tiempo = 10;
            this.formOpacador1.Visible = false;
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 675);
            this.Controls.Add(this.ListaCanciones);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLista";
            this.Text = "Lista de canciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLista_FormClosing);
            this.Load += new System.EventHandler(this.FormLista_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trasparencia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaCanciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BPausa;
        private System.Windows.Forms.Button BSigiente;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer TBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerSiguiente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer TimerProgreso;
        private System.Windows.Forms.ToolStripMenuItem verReproductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buacarEnToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem pantallaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporductorSiempreVisibleToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Trasparencia;
        private System.Windows.Forms.RadioButton RBVideos;
        private System.Windows.Forms.RadioButton RBMusica;
        private Opacador.FormOpacador formOpacador1;
        private System.Windows.Forms.Button button1;
    }
}