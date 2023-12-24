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
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemonAdrianUtrilla
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class infoPokemon : Page
    {
        public infoPokemon()
        {
            this.InitializeComponent();
        }

        //Generales

        private String generacionESP = "Generación:";
        private String CategoriaESP = "Categoria:";
        private String tipoESP = "Tipo:";
        private String pesoESP = "Peso:";
        private String AlturaESP = "Altura:";
        private String GrupoHuevoESP = "Grupo de huevo";
        private String SexoESP = "Sexo:";
        private String HabitatESP = "Habitat:";
        private String ColorESP = "Color:";

        private String generacionEN = "Generatio:";
        private String CategoriaEN = "Category:";
        private String tipoEN = "Type:";
        private String pesoEN = "Weight:";
        private String AlturaEN = "Height:";
        private String GrupoHuevoEN = "Egg group";
        private String SexoEN = "Sex:";
        private String HabitatEN = "Habitat:";
        private String ColorEN = "Color:";

        //Porygon

        private String GPorygonESP = "Primera";
        private String GPorygonEN = "First";
        private String CPorygon = "Virtual";
        private String TPorygon = "Normal";
        private String PPorygon = "36,5 Kg";
        private String APorygon = "0.8 m";
        private String GHPorygon = "Mineral";
        private String SPorygonESP = "Sin sexo";
        private String SPorygonEN = "Without sex";
        private String HPorygonESP = "Ciudad";
        private String HPorygonEN = "City";
        private String CPorygonESP = "Rosa";
        private String CPorygonEN = "Pink";

        private String MPorygonESP = "Movimiento";
        private String MPorygonEN = "Movement";
        private String TipoESP = "Tipo";
        private String TipoEN = "Type";
        private String ElectricoESP = "Electrico";
        private String ElectricoEN = "Electric";
        private String PlacajeESP = "Placaje";
        private String PlacajeEN = "Tackle";
        private String ImpactruenoESP = "Impactrueno";
        private String ImpactruenoEN = "Thunder Shock";
        private String OndaTruenoESP = "OndaTrueno";
        private String OndaTruenoEN = "Thunder Wave";
        private String ChispaESP = "Chispa";
        private String ChispaEN = "Spark";
        private String TriataqueESP = "Triataque";
        private String TriataqueEN = "Tri attack";
        private String RayoESP = "Rayo";
        private String RayoEN = "Beam";
        private String RecuperacionESP = "Recuperación";
        private String RecuperacionEN = "Recovery";
        private String HiperrayoESP = "Hiperrayo";
        private String HiperrayoEN = "Hyper beam";

        //Psyduck

        private String GPsyduckESP = "Primera";
        private String GPsyduckEN = "First";
        private String CPsyduckESP = "Pato";
        private String CPsyduckEN = "Duck";
        private String TPsyduckESP = "Agua"; 
        private String TPsyduckEN = "Water";
        private String PPsyduck = "19,6 Kg";
        private String APsyduck = "0.8 m";
        private String GHPsyduckESP = "Campo agua 1";
        private String GHPsyduckEN = "Water field 1";
        private String SPsyduckESP = "Macho/Hembra";
        private String SPsyduckEN = "Male/Female";
        private String HPsyduckESP = "Agua dulce";
        private String HPsyduckEN = "Sweet water";
        private String CoPsyduckESP = "Amarillo";
        private String CoPsyduckEN = "Yellow";

        private String ArañazoESP = "Arañazo";
        private String ArañazoEN = "Scratch";
        private String LatigoESP = "Latigo";
        private String LatigoEN = "Tail whip";
        private String PistolaAguaESP = "Pistola Agua";
        private String PistolaAguaEN = "Water gun";
        private String Confusion = "Confusion";
        private String GolpesFuriaESP = "GolpesFuria";
        private String GolpesFuriaEN = "Fury swipes";
        private String HidropulsoESP = "Hidropulso";
        private String HidropulsoEN = "Water Pulse";
        private String AnulacionESP = "Anulacion";
        private String AnulacionEN = "Disable";
        private String CabezazoZenESP = "Cabezazo zen";
        private String CabezazoZenEN = "Zen headbutt";
        private String ChirridoESP = "Chirrido";
        private String ChirridoEN = "Screech";
        private String AcuaColaESP = "Acua cola";
        private String AcuaColaEN = "Aqua tail";
        private String EmpaparESP = "Empapar";
        private String EmpaparEN = "Soak";
        private String AutosugestionESP = "Autosugestion";
        private String AutosugestionEN = "Psych up";
        private String Amnesia = "Amnesia";
        private String ZonaExtranaESP = "Zona extraña";
        private String ZonaExtranaEN = "Wonder room";

        private String PsiquicoESP = "Psiquico";
        private String PsiquicoEN = "Psychic";

        private String BiologiaESP = "Biologia";
        private String BiologiaEN = "Biology";

        private String Porygon1ESP = "Porygon posee una forma física similar a la de un pato poligonal.\r\n Porygon es el primer Pokémon artificial y fue creado en el laboratorio de Isla Canela, según un informe que se encuentra en Silph S.A..\r\n Su cuerpo es de color rosa en la espalda y la cabeza, mientras que el estómago, los pies, la cola y el pico son de color azul.\r\n Porygon está completamente fuera de código de programación. Tiene protección anti-copia, por lo que es imposible duplicarlo.";
        private String Porygon2ESP = "Debido a que es un Pokémon creado por el hombre y que no necesita respirar, suelen querer usarlo en cualquier sitio para probar sus capacidades.\r\n Fue creado hace unos veinte años en base a muchas investigaciones y usando tecnología de punta de la época, sin embargo, sus habilidades siguen siendo básicas, haciendo cosas que solo le hayan asignado por lo que ahora se encuentra desfasado en muchos aspectos.\r\n Algunos científicos lo crearon con el sueño de que fuera capaz de volar y de explorar el espacio, lamentablemente dicho sueño aún no se ha cumplido.\r\n Algunos han viajado por el tiempo gracias a las distorsiones espaciotemporales, dejando a los investigadores de la época totalmente perplejos debido a que puede vivir sin respirar y sin tener pulso alguno.";
        private String Porygon3ESP = "Se puede mover libremente por el ciberespacio, haciendo que vivan dentro de los ordenadores y todo tipo de sistemas informáticos, transportadores de Poké Balls, etc... investigando y comprobando que no haya datos sospechosos.";

        private String Porygon1EN = "Porygon possesses a physical form similar to that of a polygonal duck.\r\n Porygon is the first artificial Pokémon and was created in the Isla Canela laboratory, according to a report found in Silph Inc..\r\n Its body is pink on the back and head, while the stomach, feet, tail, and beak are blue.\r\n Porygon is completely out of programming code. It has anti-copy protection, so it is impossible to duplicate it.";
        private String Porygon2EN = "Because it is a man-made Pokémon that doesn't need to breathe, they often want to use it anywhere to test its abilities.\r\n It was created about twenty years ago based on much research and using state-of-the-art technology of the time. , however, his abilities are still basic, doing things that he has only been assigned, so he is now out of date in many aspects.\r\n Some scientists created him with the dream that he would be able to fly and explore space , unfortunately this dream has not yet come true.\r\nSome have traveled through time thanks to space-time distortions, leaving researchers of the time totally perplexed because he can live without breathing and without having any pulse.";
        private String Porygon3EN = "It can move freely through cyberspace, making them live inside computers and all kinds of computer systems, Poké Ball transporters, etc... investigating and checking that there is no suspicious data.";

        private String Psyduck1ESP = "Psyduck está basado en un pato. Este Pokémon bípedo de tonalidad amarilla posee un enorme pico ancho, un par de ojos con una mirada perdida y tres pelos en la cabeza.\r\n Sus patas delanteras tienen tres garras con las que puede llegar a rasguñar a sus oponentes, generalmente las usa para sostener su cabeza, sus patas traseras son palmeadas.\r\n Posee una pequeña cola amarrilla.";
        private String Psyduck2ESP = "La principal característica de este Pokémon son sus poderes psíquicos, los cuales son más poderosos entre más fuerte sea la jaqueca que padece, estos dolores son tan fuertes que lo hacen chillar.\r\nA pesar de esto, Psyduck nunca recuerda haber usado estos poderes, por lo que siempre parece desconcertado, de igual manera es muy difícil determinar cuando este los usará de nuevo.\r\n Se dice que podrá usar estos poderes cuando sus neuronas se encuentren totalmente despiertas, este poder consiste en emitir ondas cerebrales similares a las que generan cuando está dormido.\r\n Estos descubrimientos levantaron gran polémica entre los eruditos y científicos que lo investigan.";
        private String Psyduck3ESP = "Psyduck odia sus dolores de cabeza por lo que es común verlo tratando de mantener su mente en blanco y quedándose sin hacer nada.\r\n Habita cerca de mantos acuíferos como lagos y ríos, siendo a veces arrastrados por las corrientes de estos últimos, aunque parece que no les importa demasiado.\r\n Cuando anida se le suele ver en grupos para cuidar a sus huevos y polluelos.";

        private String Psyduck1EN = "Psyduck is based on a duck. This yellow-hued bipedal Pokémon has a huge wide beak, a pair of staring eyes, and three hairs on its head.\r\n Its front legs have three claws with which it can scratch its opponents, usually the front legs. it uses to support its head, its hind legs are webbed.\r\n It has a small yellow tail.";
        private String Psyduck2EN = "The main characteristic of this Pokémon is its psychic powers, which are more powerful the stronger the headache it suffers from, these pains are so strong that they make it scream.\r\nDespite this, Psyduck never remembers using these powers , so he always seems bewildered, in the same way it is very difficult to determine when he will use them again.\r\n It is said that he will be able to use these powers when his neurons are fully awake, this power consists of emitting brain waves similar to those that are generated when he is asleep.\r\n These discoveries raised great controversy among scholars and scientists who investigate him.";
        private String Psyduck3EN = "Psyduck hates his headaches, so it is common to see him trying to keep his mind blank and doing nothing.\r\n It lives near aquifers such as lakes and rivers, sometimes being carried away by the currents of the latter, although it seems that they do not care too much.\r\n When nesting they are usually seen in groups to care for their eggs and chicks.";

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e != null)
            {
                string str = e.Parameter as string;
                if (str == "Psyduck")
                {
                    gridPorygon.Visibility = Visibility.Collapsed;
                    gridPsyduck.Visibility = Visibility.Visible;
                }
                else if (str == "Porygon")
                {
                    gridPsyduck.Visibility = Visibility.Collapsed;
                    gridPorygon.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnPotygonESP_Click(object sender, RoutedEventArgs e)
        {
            ///RichTextBlock1

            text1Porygon.Blocks.Clear();
            Paragraph paragraph1 = new Paragraph();
            paragraph1.Inlines.Add(new Run { Text = generacionESP, FontSize = 20});
            text1Porygon.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Inlines.Add(new Run { Text = CategoriaESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            paragraph3.Inlines.Add(new Run { Text = tipoESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph3);

            Paragraph paragraph4 = new Paragraph();
            paragraph4.Inlines.Add(new Run { Text = pesoESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph4);

            Paragraph paragraph5 = new Paragraph();
            paragraph5.Inlines.Add(new Run { Text = AlturaESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph5);

            Paragraph paragraph6 = new Paragraph();
            paragraph6.Inlines.Add(new Run { Text = GrupoHuevoESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph6);

            Paragraph paragraph7 = new Paragraph();
            paragraph7.Inlines.Add(new Run { Text = SexoESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph7);

            Paragraph paragraph8 = new Paragraph();
            paragraph8.Inlines.Add(new Run { Text = HabitatESP, FontSize = 20});
            text1Porygon.Blocks.Add(paragraph8);

            Paragraph paragraph9 = new Paragraph();
            paragraph9.Inlines.Add(new Run { Text = ColorESP, FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph9);

            ///RichTextBlock2
            text2Porygon.Blocks.Clear();

            Paragraph paragraph10 = new Paragraph();
            paragraph10.Inlines.Add(new Run { Text = GPorygonESP, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph10);

            Paragraph paragraph11 = new Paragraph();
            paragraph11.Inlines.Add(new Run { Text = CPorygon, FontSize = 20});
            text2Porygon.Blocks.Add(paragraph11);

            Paragraph paragraph12 = new Paragraph();
            paragraph12.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph12);

            Paragraph paragraph13 = new Paragraph();
            paragraph13.Inlines.Add(new Run { Text = PPorygon, FontSize= 20 });
            text2Porygon.Blocks.Add(paragraph13);

            Paragraph paragraph14 = new Paragraph();
            paragraph14.Inlines.Add(new Run { Text = APorygon,FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph14);

            Paragraph paragraph15 = new Paragraph();
            paragraph15.Inlines.Add(new Run {Text = GHPorygon ,FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph15);

            Paragraph paragraph16 = new Paragraph();
            paragraph16.Inlines.Add(new Run { Text= SPorygonESP,FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph16);

            Paragraph paragraph17 = new Paragraph();
            paragraph17.Inlines.Add(new Run {Text = HPorygonESP ,FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph17);

            Paragraph paragraph18 = new Paragraph();
            paragraph18.Inlines.Add(new Run {Text = CPorygonESP, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph18);

            ///RichTextBlock4

            text4Porygon.Blocks.Clear();

            Paragraph paragraph19 = new Paragraph();
            paragraph19.Inlines.Add(new Run { Text = MPorygonESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph19);

            Paragraph paragraph20 = new Paragraph();
            paragraph20.Inlines.Add(new Run { Text = PlacajeESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph20);

            Paragraph paragraph21 = new Paragraph();
            paragraph21.Inlines.Add(new Run { Text = ImpactruenoESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph21);

            Paragraph paragraph22 = new Paragraph();
            paragraph22.Inlines.Add(new Run { Text = OndaTruenoESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph22);

            Paragraph paragraph23 = new Paragraph();
            paragraph23.Inlines.Add(new Run { Text = ChispaESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph23);

            Paragraph paragraph24 = new Paragraph();
            paragraph24.Inlines.Add(new Run { Text = TriataqueESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph24);

            Paragraph paragraph25 = new Paragraph();
            paragraph25.Inlines.Add(new Run { Text = RayoESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph25);

            Paragraph paragraph26 = new Paragraph();
            paragraph26.Inlines.Add(new Run { Text = RecuperacionESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph26);

            Paragraph paragraph27 = new Paragraph();
            paragraph27.Inlines.Add(new Run { Text = HiperrayoESP, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph27);


            ///RichTextBlock5

            text5Porygon.Blocks.Clear();

            Paragraph paragraph28 = new Paragraph();
            paragraph28.Inlines.Add(new Run { Text = TipoESP, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph28);

            Paragraph paragraph29 = new Paragraph();
            paragraph29.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph29);

            Paragraph paragraph30 = new Paragraph();
            paragraph30.Inlines.Add(new Run { Text = ElectricoESP, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph30);

            Paragraph paragraph31 = new Paragraph();
            paragraph31.Inlines.Add(new Run { Text = ElectricoESP, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph31);

            Paragraph paragraph32 = new Paragraph();
            paragraph32.Inlines.Add(new Run { Text = ElectricoESP, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph32);

            Paragraph paragraph33 = new Paragraph();
            paragraph33.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph33);

            Paragraph paragraph34 = new Paragraph();
            paragraph34.Inlines.Add(new Run { Text = ElectricoESP, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph34);

            Paragraph paragraph35 = new Paragraph();
            paragraph35.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph35);

            Paragraph paragraph36 = new Paragraph();
            paragraph36.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph36);

            text3Porygon.Blocks.Clear();

            Paragraph paragraph37 = new Paragraph();
            paragraph37.Inlines.Add(new Run { Text = BiologiaESP, FontSize = 33 });
            text3Porygon.Blocks.Add(paragraph37);

            Paragraph paragraph38 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = Porygon1ESP, FontSize = 15 });
            text3Porygon.Blocks.Add(paragraph38);

            Paragraph paragraph39 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = Porygon2ESP, FontSize = 15 });
            text3Porygon.Blocks.Add(paragraph39);

            Paragraph paragraph40 = new Paragraph();
            paragraph40.Inlines.Add(new Run { Text = Porygon3ESP, FontSize = 15 });
            text3Porygon.Blocks.Add(paragraph40);


        }

        private void btnPorygonEN_Click(object sender, RoutedEventArgs e)
        {
            ///RichTextBlock1
            text1Porygon.Blocks.Clear();

            Paragraph paragraph1 = new Paragraph();
            paragraph1.Inlines.Add(new Run { Text = generacionEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Inlines.Add(new Run { Text = CategoriaEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            paragraph3.Inlines.Add(new Run { Text = tipoEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph3);

            Paragraph paragraph4 = new Paragraph();
            paragraph4.Inlines.Add(new Run { Text = pesoEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph4);

            Paragraph paragraph5 = new Paragraph();
            paragraph5.Inlines.Add(new Run { Text = AlturaEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph5);

            Paragraph paragraph6 = new Paragraph();
            paragraph6.Inlines.Add(new Run { Text = GrupoHuevoEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph6);

            Paragraph paragraph7 = new Paragraph();
            paragraph7.Inlines.Add(new Run { Text = SexoEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph7);

            Paragraph paragraph8 = new Paragraph();
            paragraph8.Inlines.Add(new Run { Text = HabitatEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph8);

            Paragraph paragraph9 = new Paragraph();
            paragraph9.Inlines.Add(new Run { Text = ColorEN , FontSize = 20 });
            text1Porygon.Blocks.Add(paragraph9);

            ///RichTextBlock2
            text2Porygon.Blocks.Clear();

            Paragraph paragraph10 = new Paragraph();
            paragraph10.Inlines.Add(new Run { Text = GPorygonEN, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph10);

            Paragraph paragraph11 = new Paragraph();
            paragraph11.Inlines.Add(new Run { Text = CPorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph11);

            Paragraph paragraph12 = new Paragraph();
            paragraph12.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph12);

            Paragraph paragraph13 = new Paragraph();
            paragraph13.Inlines.Add(new Run { Text = PPorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph13);

            Paragraph paragraph14 = new Paragraph();
            paragraph14.Inlines.Add(new Run { Text = APorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph14);

            Paragraph paragraph15 = new Paragraph();
            paragraph15.Inlines.Add(new Run { Text = GHPorygon, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph15);

            Paragraph paragraph16 = new Paragraph();
            paragraph16.Inlines.Add(new Run { Text = SPorygonEN, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph16);

            Paragraph paragraph17 = new Paragraph();
            paragraph17.Inlines.Add(new Run { Text = HPorygonEN, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph17);

            Paragraph paragraph18 = new Paragraph();
            paragraph18.Inlines.Add(new Run { Text = CPorygonEN, FontSize = 20 });
            text2Porygon.Blocks.Add(paragraph18);

            text4Porygon.Blocks.Clear();

            Paragraph paragraph19 = new Paragraph();
            paragraph19.Inlines.Add(new Run { Text = MPorygonEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph19);

            Paragraph paragraph20 = new Paragraph();
            paragraph20.Inlines.Add(new Run { Text = PlacajeEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph20);

            Paragraph paragraph21 = new Paragraph();
            paragraph21.Inlines.Add(new Run { Text = ImpactruenoEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph21);

            Paragraph paragraph22 = new Paragraph();
            paragraph22.Inlines.Add(new Run { Text = OndaTruenoEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph22);

            Paragraph paragraph23 = new Paragraph();
            paragraph23.Inlines.Add(new Run { Text = ChispaEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph23);

            Paragraph paragraph24 = new Paragraph();
            paragraph24.Inlines.Add(new Run { Text = TriataqueEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph24);

            Paragraph paragraph25 = new Paragraph();
            paragraph25.Inlines.Add(new Run { Text = RayoEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph25);

            Paragraph paragraph26 = new Paragraph();
            paragraph26.Inlines.Add(new Run { Text = RecuperacionEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph26);

            Paragraph paragraph27 = new Paragraph();
            paragraph27.Inlines.Add(new Run { Text = HiperrayoEN, FontSize = 20 });
            text4Porygon.Blocks.Add(paragraph27);


            ///RichTextBlock5

            text5Porygon.Blocks.Clear();

            Paragraph paragraph28 = new Paragraph();
            paragraph28.Inlines.Add(new Run { Text = TipoEN, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph28);

            Paragraph paragraph29 = new Paragraph();
            paragraph29.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph29);

            Paragraph paragraph30 = new Paragraph();
            paragraph30.Inlines.Add(new Run { Text = ElectricoEN, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph30);

            Paragraph paragraph31 = new Paragraph();
            paragraph31.Inlines.Add(new Run { Text = ElectricoEN, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph31);

            Paragraph paragraph32 = new Paragraph();
            paragraph32.Inlines.Add(new Run { Text = ElectricoEN, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph32);

            Paragraph paragraph33 = new Paragraph();
            paragraph33.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph33);

            Paragraph paragraph34 = new Paragraph();
            paragraph34.Inlines.Add(new Run { Text = ElectricoEN, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph34);

            Paragraph paragraph35 = new Paragraph();
            paragraph35.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph35);

            Paragraph paragraph36 = new Paragraph();
            paragraph36.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Porygon.Blocks.Add(paragraph36);

            text3Porygon.Blocks.Clear();

            Paragraph paragraph37 = new Paragraph();
            paragraph37.Inlines.Add(new Run { Text = BiologiaEN, FontSize = 33 });
            text3Porygon.Blocks.Add(paragraph37);

            Paragraph paragraph38 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = Porygon1EN, FontSize = 16 });
            text3Porygon.Blocks.Add(paragraph38);

            Paragraph paragraph39 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = Porygon2EN, FontSize = 16 });
            text3Porygon.Blocks.Add(paragraph39);

            Paragraph paragraph40 = new Paragraph();
            paragraph40.Inlines.Add(new Run { Text = Porygon3EN, FontSize = 16 });
            text3Porygon.Blocks.Add(paragraph40);
        }

        private void btnPsyduckESP_Click(object sender, RoutedEventArgs e)
        {
            //RichTextBlock1

            text1Psyduck.Blocks.Clear();

            Paragraph paragraph1 = new Paragraph();
            paragraph1.Inlines.Add(new Run { Text = generacionESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Inlines.Add(new Run { Text = CategoriaESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            paragraph3.Inlines.Add(new Run { Text = tipoESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph3);

            Paragraph paragraph4 = new Paragraph();
            paragraph4.Inlines.Add(new Run { Text = pesoESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph4);

            Paragraph paragraph5 = new Paragraph();
            paragraph5.Inlines.Add(new Run { Text = AlturaESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph5);

            Paragraph paragraph6 = new Paragraph();
            paragraph6.Inlines.Add(new Run { Text = GrupoHuevoESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph6);

            Paragraph paragraph7 = new Paragraph();
            paragraph7.Inlines.Add(new Run { Text = SexoESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph7);

            Paragraph paragraph8 = new Paragraph();
            paragraph8.Inlines.Add(new Run { Text = HabitatESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph8);

            Paragraph paragraph9 = new Paragraph();
            paragraph9.Inlines.Add(new Run { Text = ColorESP, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph9);

            ///RichTextBlock2
            text2Psyduck.Blocks.Clear();

            Paragraph paragraph10 = new Paragraph();
            paragraph10.Inlines.Add(new Run { Text = GPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph10);

            Paragraph paragraph11 = new Paragraph();
            paragraph11.Inlines.Add(new Run { Text = CPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph11);

            Paragraph paragraph12 = new Paragraph();
            paragraph12.Inlines.Add(new Run { Text = TPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph12);

            Paragraph paragraph13 = new Paragraph();
            paragraph13.Inlines.Add(new Run { Text = PPsyduck, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph13);

            Paragraph paragraph14 = new Paragraph();
            paragraph14.Inlines.Add(new Run { Text = APsyduck, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph14);

            Paragraph paragraph15 = new Paragraph();
            paragraph15.Inlines.Add(new Run { Text = GHPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph15);

            Paragraph paragraph16 = new Paragraph();
            paragraph16.Inlines.Add(new Run { Text = SPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph16);

            Paragraph paragraph17 = new Paragraph();
            paragraph17.Inlines.Add(new Run { Text = HPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph17);

            Paragraph paragraph18 = new Paragraph();
            paragraph18.Inlines.Add(new Run { Text = CoPsyduckESP, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph18);

            text4Psyduck.Blocks.Clear();

            Paragraph paragraph19 = new Paragraph();
            paragraph19.Inlines.Add(new Run { Text = MPorygonESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph19);

            Paragraph paragraph20 = new Paragraph();
            paragraph20.Inlines.Add(new Run { Text = ArañazoESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph20);

            Paragraph paragraph21 = new Paragraph();
            paragraph21.Inlines.Add(new Run { Text = LatigoESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph21);

            Paragraph paragraph22 = new Paragraph();
            paragraph22.Inlines.Add(new Run { Text = PistolaAguaESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph22);

            Paragraph paragraph23 = new Paragraph();
            paragraph23.Inlines.Add(new Run { Text = Confusion, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph23);

            Paragraph paragraph24 = new Paragraph();
            paragraph24.Inlines.Add(new Run { Text = GolpesFuriaESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph24);

            Paragraph paragraph25 = new Paragraph();
            paragraph25.Inlines.Add(new Run { Text = HidropulsoESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph25);

            Paragraph paragraph26 = new Paragraph();
            paragraph26.Inlines.Add(new Run { Text = AnulacionESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph26);

            Paragraph paragraph27 = new Paragraph();
            paragraph27.Inlines.Add(new Run { Text = CabezazoZenESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph27);

            Paragraph paragraph28 = new Paragraph();
            paragraph28.Inlines.Add(new Run { Text = ChirridoESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph28);

            Paragraph paragraph29 = new Paragraph();
            paragraph29.Inlines.Add(new Run { Text = AcuaColaESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph29);

            Paragraph paragraph30 = new Paragraph();
            paragraph30.Inlines.Add(new Run { Text = EmpaparESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph30);

            Paragraph paragraph31 = new Paragraph();
            paragraph31.Inlines.Add(new Run { Text = AutosugestionESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph31);

            Paragraph paragraph32 = new Paragraph();
            paragraph32.Inlines.Add(new Run { Text = Amnesia, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph32);

            Paragraph paragraph33 = new Paragraph();
            paragraph33.Inlines.Add(new Run { Text = ZonaExtranaESP, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph33);

            text5Psyduck.Blocks.Clear();

            Paragraph paragraph34 = new Paragraph();
            paragraph34.Inlines.Add(new Run { Text = TipoESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph34);

            Paragraph paragraph35 = new Paragraph();
            paragraph35.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph35);

            Paragraph paragraph36 = new Paragraph();
            paragraph36.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph36);

            Paragraph paragraph37 = new Paragraph();
            paragraph37.Inlines.Add(new Run { Text = TPsyduckESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph37);

            Paragraph paragraph38 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = PsiquicoESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph38);

            Paragraph paragraph39 = new Paragraph();
            paragraph39.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph39);

            Paragraph paragraph40 = new Paragraph();
            paragraph40.Inlines.Add(new Run { Text = TPsyduckESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph40);

            Paragraph paragraph41 = new Paragraph();
            paragraph41.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph41);

            Paragraph paragraph42 = new Paragraph();
            paragraph42.Inlines.Add(new Run { Text = PsiquicoESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph42);

            Paragraph paragraph43 = new Paragraph();
            paragraph43.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph43);

            Paragraph paragraph44 = new Paragraph();
            paragraph44.Inlines.Add(new Run { Text = TPsyduckESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph44);

            Paragraph paragraph45 = new Paragraph();
            paragraph45.Inlines.Add(new Run { Text = TPsyduckESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph45);

            Paragraph paragraph46 = new Paragraph();
            paragraph46.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph46);

            Paragraph paragraph47 = new Paragraph();
            paragraph47.Inlines.Add(new Run { Text = PsiquicoESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph47);

            Paragraph paragraph48 = new Paragraph();
            paragraph48.Inlines.Add(new Run { Text = PsiquicoESP, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph48);

            text3Psyduck.Blocks.Clear();

            Paragraph paragraph49 = new Paragraph();
            paragraph49.Inlines.Add(new Run { Text = BiologiaESP, FontSize = 33 });
            text3Psyduck.Blocks.Add(paragraph49);

            Paragraph paragraph50 = new Paragraph();
            paragraph50.Inlines.Add(new Run { Text = Psyduck1ESP, FontSize = 18 });
            text3Psyduck.Blocks.Add(paragraph50);

            Paragraph paragraph51 = new Paragraph();
            paragraph51.Inlines.Add(new Run { Text = Psyduck2ESP, FontSize = 18 });
            text3Porygon.Blocks.Add(paragraph51);

            Paragraph paragraph52 = new Paragraph();
            paragraph52.Inlines.Add(new Run { Text = Psyduck3ESP, FontSize = 18 });
            text3Psyduck.Blocks.Add(paragraph52);
        }

        private void btnPsyduck_Click(object sender, RoutedEventArgs e)
        {
            //RichTextBlock1

            text1Psyduck.Blocks.Clear();

            Paragraph paragraph1 = new Paragraph();
            paragraph1.Inlines.Add(new Run { Text = generacionEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.Inlines.Add(new Run { Text = CategoriaEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            paragraph3.Inlines.Add(new Run { Text = tipoEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph3);

            Paragraph paragraph4 = new Paragraph();
            paragraph4.Inlines.Add(new Run { Text = pesoEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph4);

            Paragraph paragraph5 = new Paragraph();
            paragraph5.Inlines.Add(new Run { Text = AlturaEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph5);

            Paragraph paragraph6 = new Paragraph();
            paragraph6.Inlines.Add(new Run { Text = GrupoHuevoEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph6);

            Paragraph paragraph7 = new Paragraph();
            paragraph7.Inlines.Add(new Run { Text = SexoEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph7);

            Paragraph paragraph8 = new Paragraph();
            paragraph8.Inlines.Add(new Run { Text = HabitatEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph8);

            Paragraph paragraph9 = new Paragraph();
            paragraph9.Inlines.Add(new Run { Text = ColorEN, FontSize = 20 });
            text1Psyduck.Blocks.Add(paragraph9);

            ///RichTextBlock2
            text2Psyduck.Blocks.Clear();

            Paragraph paragraph10 = new Paragraph();
            paragraph10.Inlines.Add(new Run { Text = GPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph10);

            Paragraph paragraph11 = new Paragraph();
            paragraph11.Inlines.Add(new Run { Text = CPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph11);

            Paragraph paragraph12 = new Paragraph();
            paragraph12.Inlines.Add(new Run { Text = TPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph12);

            Paragraph paragraph13 = new Paragraph();
            paragraph13.Inlines.Add(new Run { Text = PPsyduck, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph13);

            Paragraph paragraph14 = new Paragraph();
            paragraph14.Inlines.Add(new Run { Text = APsyduck, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph14);

            Paragraph paragraph15 = new Paragraph();
            paragraph15.Inlines.Add(new Run { Text = GHPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph15);

            Paragraph paragraph16 = new Paragraph();
            paragraph16.Inlines.Add(new Run { Text = SPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph16);

            Paragraph paragraph17 = new Paragraph();
            paragraph17.Inlines.Add(new Run { Text = HPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph17);

            Paragraph paragraph18 = new Paragraph();
            paragraph18.Inlines.Add(new Run { Text = CoPsyduckEN, FontSize = 20 });
            text2Psyduck.Blocks.Add(paragraph18);

            text4Psyduck.Blocks.Clear();

            Paragraph paragraph19 = new Paragraph();
            paragraph19.Inlines.Add(new Run { Text = MPorygonEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph19);

            Paragraph paragraph20 = new Paragraph();
            paragraph20.Inlines.Add(new Run { Text = ArañazoEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph20);

            Paragraph paragraph21 = new Paragraph();
            paragraph21.Inlines.Add(new Run { Text = LatigoEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph21);

            Paragraph paragraph22 = new Paragraph();
            paragraph22.Inlines.Add(new Run { Text = PistolaAguaEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph22);

            Paragraph paragraph23 = new Paragraph();
            paragraph23.Inlines.Add(new Run { Text = Confusion, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph23);

            Paragraph paragraph24 = new Paragraph();
            paragraph24.Inlines.Add(new Run { Text = GolpesFuriaEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph24);

            Paragraph paragraph25 = new Paragraph();
            paragraph25.Inlines.Add(new Run { Text = HidropulsoEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph25);

            Paragraph paragraph26 = new Paragraph();
            paragraph26.Inlines.Add(new Run { Text = AnulacionEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph26);

            Paragraph paragraph27 = new Paragraph();
            paragraph27.Inlines.Add(new Run { Text = CabezazoZenEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph27);

            Paragraph paragraph28 = new Paragraph();
            paragraph28.Inlines.Add(new Run { Text = ChirridoEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph28);

            Paragraph paragraph29 = new Paragraph();
            paragraph29.Inlines.Add(new Run { Text = AcuaColaEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph29);

            Paragraph paragraph30 = new Paragraph();
            paragraph30.Inlines.Add(new Run { Text = EmpaparEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph30);

            Paragraph paragraph31 = new Paragraph();
            paragraph31.Inlines.Add(new Run { Text = AutosugestionEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph31);

            Paragraph paragraph32 = new Paragraph();
            paragraph32.Inlines.Add(new Run { Text = Amnesia, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph32);

            Paragraph paragraph33 = new Paragraph();
            paragraph33.Inlines.Add(new Run { Text = ZonaExtranaEN, FontSize = 20 });
            text4Psyduck.Blocks.Add(paragraph33);

            text5Psyduck.Blocks.Clear();

            Paragraph paragraph34 = new Paragraph();
            paragraph34.Inlines.Add(new Run { Text = TipoEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph34);

            Paragraph paragraph35 = new Paragraph();
            paragraph35.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph35);

            Paragraph paragraph36 = new Paragraph();
            paragraph36.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph36);

            Paragraph paragraph37 = new Paragraph();
            paragraph37.Inlines.Add(new Run { Text = TPsyduckEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph37);

            Paragraph paragraph38 = new Paragraph();
            paragraph38.Inlines.Add(new Run { Text = PsiquicoEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph38);

            Paragraph paragraph39 = new Paragraph();
            paragraph39.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph39);

            Paragraph paragraph40 = new Paragraph();
            paragraph40.Inlines.Add(new Run { Text = TPsyduckEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph40);

            Paragraph paragraph41 = new Paragraph();
            paragraph41.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph41);

            Paragraph paragraph42 = new Paragraph();
            paragraph42.Inlines.Add(new Run { Text = PsiquicoEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph42);

            Paragraph paragraph43 = new Paragraph();
            paragraph43.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph43);

            Paragraph paragraph44 = new Paragraph();
            paragraph44.Inlines.Add(new Run { Text = TPsyduckEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph44);

            Paragraph paragraph45 = new Paragraph();
            paragraph45.Inlines.Add(new Run { Text = TPsyduckEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph45);

            Paragraph paragraph46 = new Paragraph();
            paragraph46.Inlines.Add(new Run { Text = TPorygon, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph46);

            Paragraph paragraph47 = new Paragraph();
            paragraph47.Inlines.Add(new Run { Text = PsiquicoEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph47);

            Paragraph paragraph48 = new Paragraph();
            paragraph48.Inlines.Add(new Run { Text = PsiquicoEN, FontSize = 20 });
            text5Psyduck.Blocks.Add(paragraph48);

            text3Psyduck.Blocks.Clear();

            Paragraph paragraph49 = new Paragraph();
            paragraph49.Inlines.Add(new Run { Text = BiologiaEN, FontSize = 33 });
            text3Psyduck.Blocks.Add(paragraph49);

            Paragraph paragraph50 = new Paragraph();
            paragraph50.Inlines.Add(new Run { Text = Psyduck1EN, FontSize = 18 });
            text3Psyduck.Blocks.Add(paragraph50);

            Paragraph paragraph51 = new Paragraph();
            paragraph51.Inlines.Add(new Run { Text = Psyduck2EN, FontSize = 18 });
            text3Porygon.Blocks.Add(paragraph51);

            Paragraph paragraph52 = new Paragraph();
            paragraph52.Inlines.Add(new Run { Text = Psyduck3EN, FontSize = 18 });
            text3Psyduck.Blocks.Add(paragraph52);
        }
    }
}
