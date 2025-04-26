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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mp3Downloader
{
    public partial class Form1 : Form
    {
        private string rutaDescarga;
        private Timer timer;
        private int puntosCount = 0;
        public Form1()
        {
            InitializeComponent();
            labDescargado.Visible = false;
            labDescargando.Visible = false;
        }

        private void butDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, ingresa un enlace válido.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EsURLValida(url))
            {
                MessageBox.Show("La URL ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DescargarMP3(url);
        }
        private bool EsURLValida(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute) && (url.Contains("youtube.com") || url.Contains("soundcloud.com"));
        }
        private void DescargarMP3(string url)
        {
            try
            {
                labDescargando.Visible = true;

                string directorioPrograma = AppDomain.CurrentDomain.BaseDirectory;

                // Crear la carpeta "DescargasMP3" dentro del directorio del programa
                string directorioDescarga = Path.Combine(directorioPrograma, "DescargasMP3");
                Directory.CreateDirectory(directorioDescarga); 

                // Usamos la plantilla "%(title)s.%(ext)s" para que el archivo se guarde con el nombre del título del video
                string rutaArchivo = Path.Combine(directorioDescarga, "%(title)s.%(ext)s");

                string argumentos = $"-x --audio-format mp3 --audio-quality 320k -o \"{rutaArchivo}\" \"{url}\"";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "yt-dlp",
                    Arguments = argumentos,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                Process proc = new Process { StartInfo = psi };

                string nombreArchivoDescargado = string.Empty;

                // Escuchar la salida estándar de yt-dlp para obtener el nombre del archivo
                proc.OutputDataReceived += (s, e) =>
                {
                    // Analizar las líneas de salida de yt-dlp
                    if (e.Data != null && e.Data.Contains("Destination:"))
                    {
                        // Extraer la ruta completa del archivo desde la salida
                        nombreArchivoDescargado = e.Data.Split(new[] { "Destination: " }, StringSplitOptions.None)[1];
                    }
                };
                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();

                labDescargando.Visible = false;
                labDescargado.ForeColor = Color.ForestGreen;
                labDescargado.Visible = true;

                if (!string.IsNullOrEmpty(nombreArchivoDescargado))
                {
                    
                    MessageBox.Show($"¡Descarga completada! {nombreArchivoDescargado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtURL.Text = "";
                    labDescargado.Visible = false;
                }
                else
                    MessageBox.Show("No se pudo obtener el nombre del archivo descargado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
