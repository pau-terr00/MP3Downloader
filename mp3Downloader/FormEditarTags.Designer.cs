namespace mp3Downloader
{
    partial class FormEditarTags
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
            this.pictureBoxPortada = new System.Windows.Forms.PictureBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtAlbumArtista = new System.Windows.Forms.TextBox();
            this.butGuardar = new System.Windows.Forms.Button();
            this.butPortada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPortada
            // 
            this.pictureBoxPortada.Location = new System.Drawing.Point(30, 27);
            this.pictureBoxPortada.Name = "pictureBoxPortada";
            this.pictureBoxPortada.Size = new System.Drawing.Size(228, 228);
            this.pictureBoxPortada.TabIndex = 0;
            this.pictureBoxPortada.TabStop = false;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(464, 45);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(149, 20);
            this.txtArtista.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(284, 45);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(149, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(284, 115);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(149, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtAlbumArtista
            // 
            this.txtAlbumArtista.Location = new System.Drawing.Point(464, 115);
            this.txtAlbumArtista.Name = "txtAlbumArtista";
            this.txtAlbumArtista.Size = new System.Drawing.Size(149, 20);
            this.txtAlbumArtista.TabIndex = 4;
            // 
            // butGuardar
            // 
            this.butGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butGuardar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.butGuardar.Location = new System.Drawing.Point(541, 265);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = false;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // butPortada
            // 
            this.butPortada.Location = new System.Drawing.Point(85, 268);
            this.butPortada.Name = "butPortada";
            this.butPortada.Size = new System.Drawing.Size(121, 20);
            this.butPortada.TabIndex = 6;
            this.butPortada.Text = "Portada";
            this.butPortada.UseVisualStyleBackColor = true;
            this.butPortada.Click += new System.EventHandler(this.butPortada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Albúm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Artista del Albúm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Título";
            // 
            // FormEditarTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butPortada);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.txtAlbumArtista);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.pictureBoxPortada);
            this.Name = "FormEditarTags";
            this.Text = "FormEditarTags";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPortada;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtAlbumArtista;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button butPortada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}