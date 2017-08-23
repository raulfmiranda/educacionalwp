using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacional
{
    public class Usuario
    {
        public Usuario(string nome, string email, string login, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Login = login;
            this.Senha = senha;
        }

        public Usuario(int id, string nome, string email, string login, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Login = login;
            this.Senha = senha;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
