using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Educacional
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Principal : Page
    {
        private MediaElement media;

        public Principal()
        {
            this.InitializeComponent();
            this.media = new MediaElement();
            Falar(tbConteudo.Text);
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            this.splitView.IsPaneOpen = !this.splitView.IsPaneOpen;
        }

        private void Global_Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            mbt1Definição.BorderBrush = new SolidColorBrush(Colors.Transparent);
            mbt2Sgbd.BorderBrush = new SolidColorBrush(Colors.Transparent);
            mbt3Projeto.BorderBrush = new SolidColorBrush(Colors.Transparent);
            mbt4Quiz.BorderBrush = new SolidColorBrush(Colors.Transparent);
            btn.BorderBrush = new SolidColorBrush(Colors.White);
            btn.BorderThickness = new Thickness(5, 0, 0, 0);

            if(btn.Name.Equals("mbt1Definição"))
            {
                tbConteudo.Text = "Segundo Korth, um banco de dados 'é uma coleção de dados inter-relacionados, representando informações sobre um domínio específico', ou seja, sempre que for possível agrupar informações que se relacionam e tratam de um mesmo assunto, posso dizer que tenho um banco de dados. Podemos exemplificar situações clássicas como uma lista telefônica, um catálogo de CDs ou um sistema de controle de RH de uma empresa.";
            }
            else if(btn.Name.Equals("mbt2Sgbd"))
            {
                tbConteudo.Text = "Um sistema de gerenciamento de banco de dados (SGBD) é um software que possui recursos capazes de manipular as informações do banco de dados e interagir com o usuário. Exemplos de SGBDs são: Oracle, SQL Server, DB2, PostgreSQL, MySQL, o próprio Access ou Paradox, entre outros. Por último, temos que conceituar um sistema de banco de dados como o conjunto de quatro componentes básicos: dados, hardware, software e usuários.Date conceituou que 'sistema de bancos de dados pode ser considerado como uma sala de arquivos eletrônica'.";
            }
            else if (btn.Name.Equals("mbt3Projeto"))
            {
                tbConteudo.Text = "Todo bom sistema de banco de dados deve apresentar um projeto, que visa a organização das informações e utilização de técnicas para que o futuro sistema obtenha boa performance e também facilite infinitamente as manutenções que venham a acontecer. O projeto de banco de dados se dá em duas fases: Modelagem conceitual e Projeto lógico. Estas duas etapas se referem a um sistema de banco de dados ainda não implementado, ou seja, que ainda não exista, um novo projeto.";
            }
            else if (btn.Name.Equals("mbt4Quiz"))
            {
                tbConteudo.Text = "Quiz";
            }

            Falar(tbConteudo.Text);
        }

        private async void Falar(string texto)
        {
            // The media object for controlling and playing audio.
            MediaElement mediaElement = this.media;

            // The object for controlling the speech synthesis engine (voice).
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

            // Generate the audio stream from plain text.
            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(texto);

            // Send the stream to the media object.
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void btFalar_Click(object sender, RoutedEventArgs e)
        {
            this.media.Stop();
            Falar(tbConteudo.Text);
        }

        private void btParar_Click(object sender, RoutedEventArgs e)
        {
            this.media.Stop();
        }
    }
}
