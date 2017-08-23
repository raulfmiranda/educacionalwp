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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Educacional
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Login : Page
    {
        static private List<Usuario> usuarios = new List<Usuario>();
        static int idCount = 1;
        static private bool iniciou = false;

        public Login()
        {
            this.InitializeComponent();

            if(usuarios.Count < 1)
            {
                usuarios.Add(new Usuario(idCount++, "Raul", "raul@gmail.com", "raul", "123"));
            }
        }

        private void hlinkCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Cadastro));
        }

        private void btAcessar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tboxLogin.Text) && !string.IsNullOrWhiteSpace(tboxSenha.Text))
            {
                foreach(Usuario usu in Login.usuarios)
                {
                    if(usu.Login.Equals(tboxLogin.Text) && usu.Senha.Equals(tboxSenha.Text))
                    {
                        this.Frame.Navigate(typeof(Principal));
                    }
                }
                this.tbInfo.Text = "Login e senha inválidos.";
            }
            else
            {
                this.tbInfo.Text = "Preencha o login e a senha.";
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(Login.iniciou && e.Parameter != null)
            {
                Usuario usu = (Usuario)e.Parameter;
                usuarios.Add(new Usuario(idCount++, usu.Nome, usu.Email, usu.Login, usu.Senha));
            }
            Login.iniciou = true;
        }
    }
}
