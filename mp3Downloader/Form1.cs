using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3Downloader
{
    public partial class Form1 : Form
    {
        private string rutaDescarga;
        private string nombreCancion = "";

        public Form1()
        {
            InitializeComponent();

            labDescargado.Visible = false;
            progressBar.Visible = false;
            lblProgress.Visible = false;
            lblSong.Visible = false;
        }

        private async void butDownload_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show(
                    "Por favor, ingresa un enlace válido.",
                    "Faltan datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!EsURLValida(url))
            {
                MessageBox.Show(
                    "La URL ingresada no es válida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            await DescargarMP3(url);
        }

        private bool EsURLValida(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute)
                && (
                    url.Contains("youtube.com") ||
                    url.Contains("youtu.be") ||
                    url.Contains("soundcloud.com")
                );
        }

        private async Task DescargarMP3(string url)
        {
            try
            {
                // --------------------------------
                // CAMBIAR INTERFAZ A DESCARGANDO
                // --------------------------------

                butDownload.Enabled = false;
                txtURL.Enabled = false;

                labDescargado.Visible = false;

                progressBar.Visible = true;
                lblProgress.Visible = true;
                lblSong.Visible = true;

                progressBar.Value = 0;
                lblProgress.Text = "0%";
                lblSong.Text = "Getting song information...";

                // --------------------------------
                // OBTENER NOMBRE DE LA CANCIÓN
                // --------------------------------

                nombreCancion = await ObtenerNombreCancion(url);

                if (string.IsNullOrEmpty(nombreCancion))
                {
                    nombreCancion = "Unknown song";
                }

                // Mostrar nombre mientras descarga
                lblSong.Text = nombreCancion;

                // --------------------------------
                // CARPETA DE DESCARGA
                // --------------------------------

                string directorioPrograma =
                    AppDomain.CurrentDomain.BaseDirectory;

                string directorioDescarga =
                    Path.Combine(
                        directorioPrograma,
                        "DescargasMP3");

                Directory.CreateDirectory(directorioDescarga);

                string rutaArchivo =
                    Path.Combine(
                        directorioDescarga,
                        "%(title)s.%(ext)s");

                rutaDescarga = directorioDescarga;

                // --------------------------------
                // CONFIGURACIÓN DE YT-DLP
                // --------------------------------

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "yt-dlp",

                    Arguments =
                        $"--no-playlist " +
                        $"--js-runtimes deno " +
                        $"--newline " +
                        $"--progress " +
                        $"--progress-template \"download:%(progress._percent_str)s\" " +
                        $"-x " +
                        $"--audio-format mp3 " +
                        $"--audio-quality 320K " +
                        $"--print after_move:filepath " +
                        $"-o \"{rutaArchivo}\" " +
                        $"\"{url}\"",

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process proc = new Process())
                {
                    proc.StartInfo = psi;

                    // --------------------------------
                    // SALIDA NORMAL
                    // --------------------------------

                    proc.OutputDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            ProcesarSalidaYtdlp(args.Data);
                        }
                    };

                    // --------------------------------
                    // ERRORES / PROGRESO DE YT-DLP
                    // --------------------------------

                    proc.ErrorDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            ProcesarSalidaYtdlp(args.Data);
                        }
                    };

                    proc.Start();

                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();

                    // Esperar sin bloquear la interfaz
                    await Task.Run(() =>
                    {
                        proc.WaitForExit();
                    });

                    await Task.Delay(300);

                    // --------------------------------
                    // RESULTADO
                    // --------------------------------

                    if (proc.ExitCode == 0)
                    {
                        progressBar.Value = 100;
                        lblProgress.Text = "100%";

                        labDescargado.Text =
                            "✓  Download completed";

                        labDescargado.ForeColor =
                            Color.FromArgb(80, 220, 140);

                        labDescargado.Visible = true;

                        // Mostrar nombre de la canción
                        lblSong.Text =
                            $"✓ {nombreCancion}";

                        txtURL.Text = "";

                        await Task.Delay(2500);

                        labDescargado.Visible = false;
                        lblSong.Visible = false;
                        progressBar.Visible = false;
                        lblProgress.Visible = false;
                    }
                    else
                    {
                        progressBar.Visible = false;
                        lblProgress.Visible = false;
                        lblSong.Visible = false;

                        MessageBox.Show(
                            "yt-dlp no pudo realizar la descarga.\n\n" +
                            "Comprueba que el enlace sea correcto y que yt-dlp esté actualizado.",
                            "Download error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblProgress.Visible = false;
                lblSong.Visible = false;

                MessageBox.Show(
                    "Error al descargar:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                butDownload.Enabled = true;
                txtURL.Enabled = true;
            }
        }

        // --------------------------------
        // OBTENER NOMBRE DE LA CANCIÓN
        // --------------------------------

        private async Task<string> ObtenerNombreCancion(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "yt-dlp",

                    Arguments =
                        $"--no-playlist " +
                        $"--js-runtimes deno " +
                        $"--print \"%(title)s\" " +
                        $"--skip-download " +
                        $"\"{url}\"",

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process proc = new Process())
                {
                    proc.StartInfo = psi;

                    proc.Start();

                    string resultado =
                        await proc.StandardOutput.ReadToEndAsync();

                    await proc.StandardError.ReadToEndAsync();

                    await Task.Run(() =>
                    {
                        proc.WaitForExit();
                    });

                    if (proc.ExitCode == 0)
                    {
                        string[] lineas =
                            resultado.Split(
                                new[] { '\r', '\n' },
                                StringSplitOptions.RemoveEmptyEntries);

                        if (lineas.Length > 0)
                        {
                            return lineas[0].Trim();
                        }
                    }
                }
            }
            catch
            {
                // Si no podemos obtener el título,
                // continuamos con la descarga.
            }

            return "";
        }

        // --------------------------------
        // PROCESAR PROGRESO DE YT-DLP
        // --------------------------------

        private void ProcesarSalidaYtdlp(string linea)
        {
            try
            {
                if (!linea.StartsWith("download:"))
                {
                    return;
                }

                string porcentajeTexto =
                    linea.Substring("download:".Length)
                    .Replace("%", "")
                    .Trim();

                Match match =
                    Regex.Match(
                        porcentajeTexto,
                        @"\d+([.,]\d+)?");

                if (match.Success)
                {
                    string numero =
                        match.Value.Replace(',', '.');

                    if (double.TryParse(
                        numero,
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out double porcentaje))
                    {
                        int valor =
                            Math.Max(
                                0,
                                Math.Min(
                                    100,
                                    (int)porcentaje));

                        ActualizarProgreso(valor);
                    }
                }
            }
            catch
            {
                // Ignorar líneas que no podamos procesar
            }
        }

        // --------------------------------
        // ACTUALIZAR PROGRESO
        // --------------------------------

        private void ActualizarProgreso(int valor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    progressBar.Value = valor;
                    lblProgress.Text = valor + "%";
                }));
            }
            else
            {
                progressBar.Value = valor;
                lblProgress.Text = valor + "%";
            }
        }
    }
}