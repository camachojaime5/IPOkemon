using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemonAdrianUtrilla
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ucPsyduck : UserControl
    {
        DispatcherTimer dtTimeS;
        DispatcherTimer dtTimeE;
        public ucPsyduck()
        {
            this.InitializeComponent();
        }
        private void usePotionRed(object sender, PointerRoutedEventArgs e)
        {
            dtTimeS = new DispatcherTimer();
            dtTimeS.Interval = TimeSpan.FromMilliseconds(100);
            dtTimeS.Tick += increaseHealth;
            dtTimeS.Start();
            this.imagenPocionS.Opacity = 0.5;
        }

        private void increaseHealth(object sender, object e)
        {
            this.barraSalud.Value += 0.2;
            if (barraSalud.Value >= 100)
            {
                this.dtTimeS.Stop();
                this.imagenPocionS.Opacity = 1;
            }
        }

        private void usePotionYellow(object sender, PointerRoutedEventArgs e)
        {
            dtTimeE = new DispatcherTimer();
            dtTimeE.Interval = TimeSpan.FromMilliseconds(100);
            dtTimeE.Tick += increaseEnergy;
            dtTimeE.Start();
            this.imagenPocionE.Opacity = 0.5;
        }

        private void increaseEnergy(object sender, object e)
        {
            this.barraEnergia.Value += 0.2;
            if (barraEnergia.Value >= 100)
            {
                this.dtTimeE.Stop();
                this.imagenPocionE.Opacity = 1;
            }
        }

        private void btnBajarVida_Click(object sender, RoutedEventArgs e)
        {
            if (this.imagenPocionS.Opacity != 0.5)
            {
                this.barraSalud.Value -= 5;
            }
        }

        private void btnBajarEnergia_Click(object sender, RoutedEventArgs e)
        {
            if (this.imagenPocionE.Opacity != 0.5)
            {
                this.barraEnergia.Value -= 5;
            }
        }

        private void btnEstKO_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbKO = (Storyboard)this.Resources["estadoKO"];
            sbKO.Begin();
        }

        private void btnEstHer_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbH = (Storyboard)this.Resources["estadoHerido"];
            sbH.Begin();
        }

        private void btnEstSal_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbS = (Storyboard)this.Resources["estadoSaludable"];
            sbS.Begin();
        }

        private void btnAcc1_Click(object sender, RoutedEventArgs e)
        {

            Storyboard sb0 = (Storyboard)this.Resources["burbujas0"];
            sb0.Begin();

        }

        private void btnAcc2_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbCuerpo = (Storyboard)this.Resources["ataqueCuerpo"];
            sbCuerpo.Begin();
        }

        private void btnAcc3_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sbEsquivar = (Storyboard)this.Resources["esquivar"];
            sbEsquivar.Begin();
        }
    }
}
