namespace DespertadorNET
{
    partial class FormAlarma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlarma));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formOpacador1 = new Opacador.FormOpacador(this.components);
            this.BAtras = new System.Windows.Forms.Button();
            this.BPlayStop = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BSiguiente);
            this.panel1.Controls.Add(this.BPlayStop);
            this.panel1.Controls.Add(this.BAtras);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 36);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(403, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(322, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 515);
            this.panel2.TabIndex = 3;
            // 
            // LHora
            // 
            this.LHora.BackColor = System.Drawing.Color.Transparent;
            this.LHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHora.Location = new System.Drawing.Point(0, 0);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(975, 515);
            this.LHora.TabIndex = 0;
            this.LHora.Text = "label2";
            this.LHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LHora.DoubleClick += new System.EventHandler(this.LHora_DoubleClick);
            this.LHora.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LHora_MouseDown);
            this.LHora.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LHora_MouseMove);
            this.LHora.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LHora_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formOpacador1
            // 
            this.formOpacador1.AutoCerrar = false;
            this.formOpacador1.Degradado = true;
            this.formOpacador1.Formulario = this;
            this.formOpacador1.ModoGradiente = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.formOpacador1.PrimerColor = System.Drawing.Color.Gray;
            this.formOpacador1.SegundoColor = System.Drawing.Color.White;
            this.formOpacador1.Tiempo = 10;
            this.formOpacador1.Visible = false;
            // 
            // BAtras
            // 
            this.BAtras.Location = new System.Drawing.Point(498, 7);
            this.BAtras.Name = "BAtras";
            this.BAtras.Size = new System.Drawing.Size(75, 23);
            this.BAtras.TabIndex = 4;
            this.BAtras.Text = "<<";
            this.BAtras.UseVisualStyleBackColor = true;
            this.BAtras.Click += new System.EventHandler(this.BAtras_Click);
            // 
            // BPlayStop
            // 
            this.BPlayStop.Location = new System.Drawing.Point(580, 7);
            this.BPlayStop.Name = "BPlayStop";
            this.BPlayStop.Size = new System.Drawing.Size(75, 23);
            this.BPlayStop.TabIndex = 5;
            this.BPlayStop.Text = "||>";
            this.BPlayStop.UseVisualStyleBackColor = true;
            this.BPlayStop.Click += new System.EventHandler(this.BPlayStop_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.Location = new System.Drawing.Point(661, 7);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BSiguiente.TabIndex = 6;
            this.BSiguiente.Text = ">>";
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // FormAlarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAlarma_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private Opacador.FormOpacador formOpacador1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BPlayStop;
        private System.Windows.Forms.Button BAtras;
    }
}