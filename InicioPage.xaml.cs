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
    public sealed partial class InicioPage : Page
    {
        public InicioPage()
        {
            this.InitializeComponent();
        }
        private String textoESP = "IPOkemon permite a los entrenadores pokemon mas novatos adaptarse a las mecanicas sobre los pokemon, como por ejemplo buscar pokemon en una pokeDex y tambien permite que los pokemon combatan entre ellos.";
        private String textoEN = "IPokemon allows newer pokemon trainers to adapt to pokemon mechanics, such as looking for pokemon in a pokeDex and also allows pokemon to battle each other.";
        private void btnESP_Click(object sender, RoutedEventArgs e)
        {
            txtInicio.Text = textoESP;
        }

        private void btnEN_Click(object sender, RoutedEventArgs e)
        {
            txtInicio.Text = textoEN;
        }
    }
}
