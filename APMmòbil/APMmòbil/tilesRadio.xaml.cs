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
    public partial class tilesRadio : UserControl
    {
        private SoundEffect SE;

        public tilesRadio()
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

        private void cabron_Click(object sender, RoutedEventArgs e)
        {

            LoadSound("Sounds/Radio/cabron.wav");
        }

        private void callar_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/callar.wav");
        }

        private void carmina_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/carminaburana.wav");
        }

        private void clos_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/clos.wav");
        }

        private void figo_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/figo.wav");
        }

        private void iaiacule_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/iaiacule.wav");
        }

        private void mentira_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/mentira.wav");
        }

        private void noigo_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/noigo.wav");
        }

        private void resbarca_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/resbarca.wav");
        }

        private void tato_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/tato.wav");
        }

        private void treball_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/treball.wav");
        }

        private void venut_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/venut.wav");
        }

        private void xof_Click(object sender, RoutedEventArgs e)
        {
            LoadSound("Sounds/Radio/xof.wav");
        }
    }
}
