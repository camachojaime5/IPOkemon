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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace IPOkemonAdrianUtrilla
{
    public sealed partial class MyUserControl1 : UserControl
    {
        DispatcherTimer dtTime, dtRelojStamina;
        public MyUserControl1()
        {
            this.InitializeComponent();
            Storyboard mc = (Storyboard)this.Resources["MoverCola"];
            mc.RepeatBehavior = RepeatBehavior.Forever;
            mc.Begin();
            Storyboard mD = (Storyboard)this.Resources["MoverPataDer"];
            mD.RepeatBehavior = RepeatBehavior.Forever;
            mD.Begin();
            Storyboard mI = (Storyboard)this.Resources["MoverPataIzq"];
            mI.RepeatBehavior = RepeatBehavior.Forever;
            mI.Begin();
            
        }

        private void Image_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseHealth;
            dtTime.Start();
            this.imRPotion.Opacity= 0.5;
        }

        private void increaseHealth(object sender, object e) {
            this.pbHealth.Value += 0.2;
            if(pbHealth.Value >= 100)
            {
                this.dtTime.Stop();
                this.imRPotion.Opacity = 1;
            }
        }

        private void increaseStamina(Object sender, object e)
        {
            this.pbStamina.Value += 0.2;
            if(pbStamina.Value >= 100)
            {
                this.dtRelojStamina.Stop();
                this.imYPotion.Opacity = 1;

            }
        }

        private void Atacar1_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["Atacar"];
            Ataque.Visibility = Visibility.Visible;
            this.pbStamina.Value -= 2.5;
            sb.Begin();
        }

        private void Defenderse_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["SacarEscudo"];
            Escudo.Visibility = Visibility.Visible;
            sb.RepeatBehavior = new RepeatBehavior(2);
            this.pbStamina.Value -= 2.5;
            sb.Begin();
        }

        private void Image_PointerReleased_1(object sender, PointerRoutedEventArgs e)
        {
            dtRelojStamina = new DispatcherTimer();
            dtRelojStamina.Interval = TimeSpan.FromMilliseconds(100);
            dtRelojStamina.Tick += increaseStamina;
            dtRelojStamina.Start();
            this.imYPotion.Opacity = 0.5;
        }

        private void Atacar2_Click(object sender, RoutedEventArgs e) {
            Storyboard sb = (Storyboard)this.Resources["Placar"];
            sb.AutoReverse = true;
            this.pbStamina.Value -= 2.5;
            sb.Begin();
        }

        private void Descansar1_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["Descansar"];
            this.pbStamina.Value += 5;
            sb.Begin();
        }

        public double vida
        {
            get { return this.pbHealth.Value; }
            set { this.pbHealth.Value = value;}
        }

        public double stamina
        {
            get { return this.pbStamina.Value; }
            set { this.pbStamina.Value = value; }
        }

        private bool verEnergia = true;

        private void Herir_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["herido"];
            sb.Begin();
            pbHealth.Value -= 5;
        }

        public bool VerEnergia
        {
            get { return verEnergia; }
            set { 
                this.verEnergia = value;
                if(!verEnergia)
                { 
                this.gridGeneral.RowDefinitions[1].Height = new GridLength(0);
                }
                else this.gridGeneral.RowDefinitions[1].Height = new GridLength(10, GridUnitType.Star);
            }   
        }
        
    }
}
