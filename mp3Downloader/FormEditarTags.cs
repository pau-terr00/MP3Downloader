using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;
using SystemFile = System.IO.File;
using TagLibFile = TagLib.File;


namespace mp3Downloader
{
    public partial class FormEditarTags : Form
    {
        private string archivoMP3;
        private string rutaPortada;
        public FormEditarTags(string archivo)
        {
            InitializeComponent();
            archivoMP3 = archivo;
        }

        private void CargarDatos()
        {
            try
            {
                var file = TagLibFile.Create(archivoMP3);

                txtTitulo.Text = file.Tag.Title;
                txtTitulo.Text = string.Join(", ", file.Tag.Performers);
                txtAlbum.Text = file.Tag.Album;
                txtAlbumArtista.Text = string.Join(", ", file.Tag.AlbumArtists);

                if (file.Tag.Pictures.Length > 0)
                {
                    var picture = file.Tag.Pictures[0];
                    byte[] portadaBytes = picture.Data.ToArray();

                    using (MemoryStream ms = new MemoryStream(portadaBytes))
                    {
                        pictureBoxPortada.Image = System.Drawing.Image.FromStream(ms);

                        // Establecer el modo de tamaño para ajustar la imagen al PictureBox sin deformarse
                        pictureBoxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    // Si no hay portada, limpiar el PictureBox
                    pictureBoxPortada.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir el archivo MP3 para editar los tags
                var file = TagLib.File.Create(archivoMP3);

                // Actualizar los tags
                file.Tag.Title = txtTitulo.Text;
                file.Tag.Performers = new string[] { txtArtista.Text };
                file.Tag.Album = txtAlbum.Text;
                file.Tag.AlbumArtists = new string[] { txtAlbumArtista.Text }; // Establecer el Artista del Álbum

                // Si se ha seleccionado una portada, añadirla
                if (!string.IsNullOrEmpty(rutaPortada))
                {
                    byte[] portada = SystemFile.ReadAllBytes(rutaPortada);
                    file.Tag.Pictures = new TagLib.Picture[] { new TagLib.Picture(portada) };
                }

                // Guardar los cambios
                file.Save();

                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butPortada_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg",
                Title = "Selecciona una portada"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaPortada = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox para vista previa
                pictureBoxPortada.Image = System.Drawing.Image.FromFile(rutaPortada);
                pictureBoxPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    
    }

    
}
