using NAudio.Wave;
using System.Windows.Forms;

namespace DokiDokiTetrisClub
{
    public partial class Menu : Form
    {
        private const string MusicaMenu = "Musica/Menu/Musica_Menu.wav";
        private const string SonidoHover = "Musica/Menu/Hover_Menu.wav";
        private const string SonidoBoton = "Musica/Menu/Select_Menu.wav";

        private WaveStream StreamMusicaMenu;
        private WaveStream StreamSonidoHover;
        private WaveStream StreamSonidoBoton;

        private WaveOut PlayMusicaMenu;
        private WaveOut PlaySonidoHover;
        private WaveOut PlaySonidoBoton;
        public Menu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            StreamMusicaMenu = new WaveFileReader(MusicaMenu);
            PlayMusicaMenu = new WaveOut();
            PlayMusicaMenu.Init(StreamMusicaMenu);
            PlayMusicaMenu.Play();

            StreamSonidoHover = new WaveFileReader(SonidoHover);
            PlaySonidoHover = new WaveOut();
            PlaySonidoHover.Init(StreamSonidoHover);

            StreamSonidoBoton = new WaveFileReader(SonidoBoton);
            PlaySonidoBoton = new WaveOut();
            PlaySonidoBoton.Init(StreamSonidoBoton);
        }

        private void NuevaPartida_MouseHover(object sender, System.EventArgs e)
        {
            StreamSonidoHover.Position = 0;
            PlaySonidoHover.Play();
        }

        private void NuevaPartida_Click(object sender, System.EventArgs e)
        {
            StreamSonidoBoton.Position = 0;
            PlaySonidoBoton.Play();
        }

        private void ContinuarPartida_Click(object sender, System.EventArgs e)
        {
            StreamSonidoBoton.Position = 0;
            PlaySonidoBoton.Play();
        }

        private void ContinuarPartida_MouseHover(object sender, System.EventArgs e)
        {
            StreamSonidoHover.Position = 0;
            PlaySonidoHover.Play();
        }

        private void Configuracion_Click(object sender, System.EventArgs e)
        {
            StreamSonidoBoton.Position = 0;
            PlaySonidoBoton.Play();
        }

        private void Configuracion_MouseHover(object sender, System.EventArgs e)
        {
            StreamSonidoHover.Position = 0;
            PlaySonidoHover.Play();
        }

        private void Extras_Click(object sender, System.EventArgs e)
        {
            StreamSonidoBoton.Position = 0;
            PlaySonidoBoton.Play();
        }

        private void Extras_MouseHover(object sender, System.EventArgs e)
        {
            StreamSonidoHover.Position = 0;
            PlaySonidoHover.Play();
        }

        private void Salir_Click(object sender, System.EventArgs e)
        {
            StreamSonidoBoton.Position = 0;
            PlaySonidoBoton.Play();
        }

        private void Salir_MouseHover(object sender, System.EventArgs e)
        {
            StreamSonidoHover.Position = 0;
            PlaySonidoHover.Play();
        }
    }
}
