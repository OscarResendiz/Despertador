namespace DespertadorNET
{
    partial class FormRepoructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepoructor));
            this.ocxPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerPantallaCompleta = new System.Windows.Forms.Timer(this.components);
            this.timerOpaciti = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ocxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ocxPlayer
            // 
            this.ocxPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocxPlayer.Enabled = true;
            this.ocxPlayer.Location = new System.Drawing.Point(0, 0);
            this.ocxPlayer.Name = "ocxPlayer";
            this.ocxPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ocxPlayer.OcxState")));
            this.ocxPlayer.Size = new System.Drawing.Size(877, 488);
            this.ocxPlayer.TabIndex = 1;
            this.ocxPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.ocxPlayer_PlayStateChange);
            this.ocxPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.ocxPlayer_MouseMoveEvent);
            // 
            // timerPantallaCompleta
            // 
            this.timerPantallaCompleta.Tick += new System.EventHandler(this.timerPantallaCompleta_Tick);
            // 
            // timerOpaciti
            // 
            this.timerOpaciti.Interval = 2000;
            this.timerOpaciti.Tick += new System.EventHandler(this.timerOpaciti_Tick);
            // 
            // FormRepoructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 488);
            this.Controls.Add(this.ocxPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRepoructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRepoructor";
            this.Load += new System.EventHandler(this.FormRepoructor_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRepoructor_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRepoructor_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ocxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ocxPlayer;
        private System.Windows.Forms.Timer timerPantallaCompleta;
        private System.Windows.Forms.Timer timerOpaciti;
    }
}