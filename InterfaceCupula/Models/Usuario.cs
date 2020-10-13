using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceCupula.Enums;
namespace InterfaceCupula.Models
{
    class Usuario
    {

        public Usuario(String nome, String senha, TiposDeUsuarios tipoUsuario)
        {

            Nome = nome;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public Usuario(String id, String Nome, String Senha, TiposDeUsuarios tipoUsuario)
        {
            userId = id;
            this.Nome = Nome;
            this.Senha = Senha;
            TipoUsuario = tipoUsuario;
        }

        public String userId { get; set; }

        public String Nome { get; set; }

        public TiposDeUsuarios TipoUsuario { get; set; }

        public String Senha { get; set; }


    }
}
