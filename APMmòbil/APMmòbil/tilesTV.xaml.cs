using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using Microsoft.Phone.Controls;

using System.Windows.Navigation;
using System.Windows.Resources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
//using Microsoft.Xna.Framework.Media;

namespace APMmòbil
{
    public partial class tilesTV : UserControl
    {
        private SoundEffect SE;

        public tilesTV()
        {
            InitializeComponent();
        }

        private void LoadSound(String URL)
        {

            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri(URL, UriKind.Relative));
                SE = SoundEffect.FromStream(streamInfo.Stream);
                SE.CreateInstance().Play();
            }
            catch
            {
                MessageBox.Show("Error. Això està mal implementat. És de ser inútiles.");
            }
        }

        private void aixo_Click(object sender, RoutedEventArgs e)
        {

            LoadSound("Sounds/aixo.wav");
        }

        private void bien_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/bien.wav");
        }

        private void buenapersona_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/buenapersona.wav");
        }

        private void cagada_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/cagada.wav");
        }

        private void carteras_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/carteras.wav");
        }
        
        private void clar_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/clar.wav");
        }

        private void contracatalanes_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/contracatalanes.wav");
        }

        private void crecno_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/crecno.wav");
        }
        
        private void depredadores_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/depredadores.wav");
        }
        
        private void dicho_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/dicho.wav");
        }

        private void equivocacio_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/equivocacio.wav");
        }

        private void excuseme_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/excuseme.wav");
        }

        private void freak_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/freak.wav");
        }
        
        private void follon_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/follon.wav");
        }
        
        private void investigacion_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/investigacion.wav");
        }

        private void gumersindo_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/gumersindo.wav");
        }

        private void lio_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/lio.wav");
        }

        private void manzanas_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/manzanas.wav");
        }

        private void mundoloco_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/mundoloco.wav");
        }
        
        private void nonoiara_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/nonoiara.wav");
        }

        private void pocon_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/pocon.wav");
        }

        private void porculo_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/porculo.wav");
        }
        
        private void quediceud_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/quediceud.wav");
        }

        private void sicuela_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/sicuela.wav");
        }

        private void riomierda_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/riomierda.wav");
        }

        private void siseguro_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/siseguro.wav");
        }

        private void tejodes_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/tejodes.wav");
        }
        
        private void terrible_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/terrible.wav");
        }

        private void tomaya_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/tomaya.wav");
        }

        private void vist_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/vist.wav");
        }

    }
}
