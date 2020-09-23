using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCupula.Models
{
    class Usuario
    {


        public Usuario(String id, String Nome, String Senha)
        {
            userId = id;
            this.Nome = Nome;
            this.Senha = Senha;
        }

        public String userId { get; set; }

        public String Nome { get; set; }

        public String Senha { get; set; }


    }
}
