using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Quiz : Page
    {
        public Quiz()
        {
            this.InitializeComponent();
        }

        private void btCancelarQuiz_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Principal));
        }

        private void btConcluirQuiz_Click(object sender, RoutedEventArgs e)
        {
            int pontos = 0;
            if (rbQ1resp3.IsChecked ?? false) pontos++;
            if (rbQ2resp2.IsChecked ?? false) pontos++;
            if (rbQ3resp1.IsChecked ?? false) pontos++;
            tbResultadoQuiz.Text = ""+pontos;
            panelQuizBody.Visibility = Visibility.Collapsed;
            panelResultadoQuiz.Visibility = Visibility.Visible;
        }
        
    }
}
