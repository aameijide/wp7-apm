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
    public partial class MainPage : PhoneApplicationPage
    {
        private SoundEffect bienSE;
        private SoundEffect lioSE;
        private SoundEffect carterasSE;
        private SoundEffect follonSE;
        private SoundEffect poconSE;
        private SoundEffect vistSE;



        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void bien_Checked(object sender, RoutedEventArgs e)
        {

            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/bien.wav", UriKind.Relative));
                bienSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance bien = bienSE.CreateInstance();
                bien.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }

        }

        private void lio_Checked(object sender, RoutedEventArgs e)
        {

            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/lio.wav", UriKind.Relative));
                lioSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance lio = lioSE.CreateInstance();
                lio.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }
        }

        private void carteras_Checked(object sender, RoutedEventArgs e)
        {
            
            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/carteras.wav", UriKind.Relative));
                carterasSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance carteras = carterasSE.CreateInstance();
                carteras.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }
        }

        private void follon_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/follon.wav", UriKind.Relative));
                follonSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance follon = follonSE.CreateInstance();
                follon.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }
        }

        private void pocon_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/pocon.wav", UriKind.Relative));
                poconSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance pocon = poconSE.CreateInstance();
                pocon.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }
        }

        private void vist_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("Sounds/vist.wav", UriKind.Relative));
                vistSE = SoundEffect.FromStream(streamInfo.Stream);
                SoundEffectInstance vist = vistSE.CreateInstance();
                vist.Play();
            }
            catch
            {
                MessageBox.Show("Can't play, Sound is null.");
            }
        }
    }
}