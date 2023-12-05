using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WW_v04
{
    public partial class F1_PantallaInicial : Form
    {
        public F1_PantallaInicial()
        {
            InitializeComponent();
            ReproducirSonido();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Cierra el formulario F1_PantallaInicial
            this.Hide();

            // Abre el formulario F2_Quiz
            F2_Quiz f2 = new F2_Quiz();
            f2.ShowDialog();        
            
        }

        string rutaAudio = "C:/Users/Jez/source/repos/WW v04/WW v04/Resources/startmusic.wav";
        private void ReproducirSonido() 
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaAudio;
            player.Play();
        }


    }
}
