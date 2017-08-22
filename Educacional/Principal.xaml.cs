using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        public Principal()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            this.splitView.IsPaneOpen = !this.splitView.IsPaneOpen;
        }

        private void Global_Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            mbt1Introducao.BorderBrush = new SolidColorBrush(Colors.Transparent);
            mbt2Pombalinas.BorderBrush = new SolidColorBrush(Colors.Transparent);
            mbt3Quiz.BorderBrush = new SolidColorBrush(Colors.Transparent);
            btn.BorderBrush = new SolidColorBrush(Colors.White);
            btn.BorderThickness = new Thickness(5, 0, 0, 0);

            if(btn.Name.Equals("mbt1Introducao"))
            {
                tbConteudo.Text = "INTRO";
            }
            else if(btn.Name.Equals("mbt2Pombalinas"))
            {
                tbConteudo.Text = "POBALINAS";
            }
            else if (btn.Name.Equals("mbt3Quiz"))
            {
                tbConteudo.Text = "QUIZ";
            }
        }
    }
}
