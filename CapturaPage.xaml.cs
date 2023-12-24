using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
    public sealed partial class CapturaPage : Page
    {
        DispatcherTimer dtTimeB;
        bool direccionBarra = true;
        string ipokemon;
        public CapturaPage()
        {
            this.InitializeComponent();
            pbMove();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e != null)
            {
                string str = e.Parameter as string;
                if (str == "Psyduck")
                {
                    this.ipokemon = "Psyduck";
                    vbPorygon.Visibility = Visibility.Collapsed;
                    vbPsyduck.Visibility = Visibility.Visible;
                }
                else if (str == "Porygon")
                {
                    this.ipokemon = "Porygon";
                    vbPsyduck.Visibility = Visibility.Collapsed;
                    vbPorygon.Visibility = Visibility.Visible;
                }
            }
        }

        private void pbMove()
        {
            dtTimeB = new DispatcherTimer();
            dtTimeB.Interval = TimeSpan.FromMilliseconds(5);
            dtTimeB.Tick += move;
            dtTimeB.Start();
        }

        private void move(object sender, object e)
        {
            if (this.direccionBarra == true)
            {
                this.pbFuerza.Value += 0.5;
                if (pbFuerza.Value >= 100)
                {
                    this.direccionBarra = false;
                }
            }
            else if (this.direccionBarra==false)
            {
                this.pbFuerza.Value -= 0.5;
                if (pbFuerza.Value <= 0)
                {
                    this.direccionBarra = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.dtTimeB.Stop();

            if (40 <= this.pbFuerza.Value && this.pbFuerza.Value <= 60)
            {
                Storyboard sbLanzamientoMedio = (Storyboard)this.Resources["lanzamientoMedio"];
                sbLanzamientoMedio.Begin();

                ToastContentBuilder notificacion = new ToastContentBuilder();
                notificacion.AddArgument("action", "Captura")
                .AddArgument("conversationId", 9813)
                .AddText("IPOKEMON CAPTURADO")
                .AddText("Has capturado un " + ipokemon)
                .SetToastDuration(0)
                .Show();


                //new ToastContentBuilder()
                //.AddArgument("action", "Captura")
                //.AddArgument("conversationId", 9813)
                //.AddText("IPOKEMON CAPTURADO")
                //.AddText("Has capturado un " + ipokemon)
                //.Show();

                fmMain.Navigate(typeof(PokedexPage), ipokemon);
            }
            else if (60 < this.pbFuerza.Value)
            {
                Storyboard sbLanzamientoLargo = (Storyboard)this.Resources["lanzamientoLargo"];
                sbLanzamientoLargo.Completed += (s, evt) =>
                {
                    this.dtTimeB.Start();
                };
                sbLanzamientoLargo.Begin();
                //sbLanzamientoLargo.Begin();

                //this.dtTimeB.Start();
            }
            else if (this.pbFuerza.Value < 40)
            {
                Storyboard sbLanzamientoCorto = (Storyboard)this.Resources["lanzamientoCorto"];
                sbLanzamientoCorto.Completed += (s, evt) =>
                {
                    this.dtTimeB.Start();
                };
                sbLanzamientoCorto.Begin();
                //sbLanzamientoCorto.Begin();

                //this.dtTimeB.Start();
            }
        }

    }
}
