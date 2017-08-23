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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Educacional
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Cadastro : Page
    {
        public Cadastro()
        {
            this.InitializeComponent();
        }

        private void btCancelarCadastro_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private void btCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tboxEmail.Text) && !string.IsNullOrWhiteSpace(tboxLogin.Text) &&
                !string.IsNullOrWhiteSpace(tboxNome.Text) && !string.IsNullOrWhiteSpace(tboxSenha.Text))
            {
                this.Frame.Navigate(typeof(Login), new Usuario(tboxNome.Text, tboxEmail.Text, tboxLogin.Text, tboxSenha.Text));
            }
        }

        
    }
}
