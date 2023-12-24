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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemonAdrianUtrilla
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CombatePage : Page
    {
        public CombatePage()
        {
            this.InitializeComponent();
            loadFlipViews();
        }

        private void loadFlipViews()
        {
            MyUserControl1 ucPorygon1 = new MyUserControl1();
            MyUserControl1 ucPorygon2 = new MyUserControl1();

            ucPsyduck ucPsyduck1 = new ucPsyduck();
            ucPsyduck ucPsyduck2 = new ucPsyduck();

            flipViewIzq.Items.Add(ucPorygon1);
            flipViewDer.Items.Add(ucPorygon2);

            flipViewIzq.Items.Add(ucPsyduck1);
            flipViewDer.Items.Add(ucPsyduck2);
        }
    }
}
