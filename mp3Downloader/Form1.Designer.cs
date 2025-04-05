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
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.butDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labDescargado = new System.Windows.Forms.Label();
            this.labDescargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(57, 82);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(452, 23);
            this.txtURL.TabIndex = 0;
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butDownload
            // 
            this.butDownload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDownload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butDownload.Location = new System.Drawing.Point(221, 122);
            this.butDownload.Name = "butDownload";
            this.butDownload.Size = new System.Drawing.Size(129, 45);
            this.butDownload.TabIndex = 1;
            this.butDownload.Text = "Download";
            this.butDownload.UseVisualStyleBackColor = false;
            this.butDownload.Click += new System.EventHandler(this.butDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "YouTube To MP3 320kbm";
            // 
            // labDescargado
            // 
            this.labDescargado.AutoSize = true;
            this.labDescargado.Location = new System.Drawing.Point(227, 182);
            this.labDescargado.Name = "labDescargado";
            this.labDescargado.Size = new System.Drawing.Size(117, 13);
            this.labDescargado.TabIndex = 4;
            this.labDescargado.Text = "¡Descarga completada!";
            this.labDescargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDescargando
            // 
            this.labDescargando.AutoSize = true;
            this.labDescargando.Location = new System.Drawing.Point(246, 182);
            this.labDescargando.Name = "labDescargando";
            this.labDescargando.Size = new System.Drawing.Size(80, 13);
            this.labDescargando.TabIndex = 5;
            this.labDescargando.Text = "Descargando...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 219);
            this.Controls.Add(this.labDescargando);
            this.Controls.Add(this.labDescargado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDownload);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Mp3Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button butDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDescargado;
        private System.Windows.Forms.Label labDescargando;
    }
}

