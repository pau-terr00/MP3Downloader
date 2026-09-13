namespace mp3Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben desecharse; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblStatusDot = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.labDescargado = new System.Windows.Forms.Label();
            this.butDownload = new System.Windows.Forms.Button();
            this.urlPanel = new System.Windows.Forms.Panel();
            this.lblUrlIcon = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.urlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.mainPanel.Controls.Add(this.footerPanel);
            this.mainPanel.Controls.Add(this.progressBar);
            this.mainPanel.Controls.Add(this.lblProgress);
            this.mainPanel.Controls.Add(this.lblSong);
            this.mainPanel.Controls.Add(this.labDescargado);
            this.mainPanel.Controls.Add(this.butDownload);
            this.mainPanel.Controls.Add(this.urlPanel);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.lblSubtitle);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.lblLogo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(650, 400);
            this.mainPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.footerPanel.Controls.Add(this.lblQuality);
            this.footerPanel.Controls.Add(this.lblFormat);
            this.footerPanel.Controls.Add(this.lblSource);
            this.footerPanel.Controls.Add(this.lblStatusDot);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 350);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(650, 50);
            this.footerPanel.TabIndex = 8;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.lblQuality.Location = new System.Drawing.Point(503, 17);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(88, 15);
            this.lblQuality.TabIndex = 3;
            this.lblQuality.Text = "320 kbps • MP3";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.lblFormat.Location = new System.Drawing.Point(87, 17);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(72, 15);
            this.lblFormat.TabIndex = 2;
            this.lblFormat.Text = "High quality";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.lblSource.Location = new System.Drawing.Point(187, 17);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(130, 15);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "YouTube • SoundCloud";
            // 
            // lblStatusDot
            // 
            this.lblStatusDot.AutoSize = true;
            this.lblStatusDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(140)))));
            this.lblStatusDot.Location = new System.Drawing.Point(57, 13);
            this.lblStatusDot.Name = "lblStatusDot";
            this.lblStatusDot.Size = new System.Drawing.Size(20, 21);
            this.lblStatusDot.TabIndex = 0;
            this.lblStatusDot.Text = "●";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(125, 330);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 8);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblProgress.Location = new System.Drawing.Point(525, 309);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(50, 20);
            this.lblProgress.TabIndex = 10;
            this.lblProgress.Text = "0%";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProgress.Visible = false;
            // 
            // lblSong
            // 
            this.lblSong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblSong.Location = new System.Drawing.Point(75, 308);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(450, 20);
            this.lblSong.TabIndex = 11;
            this.lblSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSong.Visible = false;
            // 
            // labDescargado
            // 
            this.labDescargado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(140)))));
            this.labDescargado.Location = new System.Drawing.Point(150, 308);
            this.labDescargado.Name = "lab Descargado";
            this.labDescargado.Size = new System.Drawing.Size(350, 22);
            this.labDescargado.TabIndex = 7;
            this.labDescargado.Text = "✓  Download completed";
            this.labDescargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labDescargado.Visible = false;
            // 
            // butDownload
            // 
            this.butDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.butDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDownload.FlatAppearance.BorderSize = 0;
            this.butDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(67)))), ((int)(((byte)(195)))));
            this.butDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(250)))));
            this.butDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDownload.ForeColor = System.Drawing.Color.White;
            this.butDownload.Location = new System.Drawing.Point(225, 253);
            this.butDownload.Name = "butDownload";
            this.butDownload.Size = new System.Drawing.Size(200, 45);
            this.butDownload.TabIndex = 5;
            this.butDownload.Text = "↓   DOWNLOAD";
            this.butDownload.UseVisualStyleBackColor = false;
            this.butDownload.Click += new System.EventHandler(this.butDownload_Click);
            // 
            // urlPanel
            // 
            this.urlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.urlPanel.Controls.Add(this.lblUrlIcon);
            this.urlPanel.Controls.Add(this.txtURL);
            this.urlPanel.Location = new System.Drawing.Point(65, 191);
            this.urlPanel.Name = "urlPanel";
            this.urlPanel.Size = new System.Drawing.Size(520, 48);
            this.urlPanel.TabIndex = 4;
            // 
            // lblUrlIcon
            // 
            this.lblUrlIcon.AutoSize = true;
            this.lblUrlIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.lblUrlIcon.Location = new System.Drawing.Point(15, 11);
            this.lblUrlIcon.Name = "lblUrlIcon";
            this.lblUrlIcon.Size = new System.Drawing.Size(25, 25);
            this.lblUrlIcon.TabIndex = 1;
            this.lblUrlIcon.Text = "↗";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.txtURL.Location = new System.Drawing.Point(50, 14);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(450, 18);
            this.txtURL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(90, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paste a YouTube video or SoundCloud track link";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblSubtitle.Location = new System.Drawing.Point(150, 113);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 22);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Simple. Fast. High quality.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(150, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "MP3 DOWNLOADER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.lblLogo.Location = new System.Drawing.Point(305, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(38, 45);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "♪";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Downloader";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.urlPanel.ResumeLayout(false);
            this.urlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel urlPanel;

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button butDownload;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUrlIcon;

        private System.Windows.Forms.Label labDescargado;

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblSong;

        private System.Windows.Forms.Label lblStatusDot;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblQuality;
    }
}

