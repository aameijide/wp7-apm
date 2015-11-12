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
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void bien_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/bien.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance bien = se.CreateInstance();
            bien.Play();
        }

        private void lio_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/lio.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance lio = se.CreateInstance();
            lio.Play();
        }

        private void carteras_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/carteras.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance carteras = se.CreateInstance();
            carteras.Play();
        }

        private void follon_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/follon.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance follon = se.CreateInstance();
            follon.Play();
        }

        private void pocon_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/pocon.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance pocon = se.CreateInstance();
            pocon.Play();
        }

        private void vist_Checked(object sender, RoutedEventArgs e)
        {
            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("/APMmòbil;component/Sound/vist.wav", UriKind.Relative));
            SoundEffect se = SoundEffect.FromStream(streamInfo.Stream);
            SoundEffectInstance vist = se.CreateInstance();
            vist.Play();
        }
    }
}