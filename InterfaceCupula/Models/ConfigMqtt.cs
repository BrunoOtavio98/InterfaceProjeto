using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCupula.Models
{
    class ConfigMqtt
    {

        public int idconfig { get; set; }

        public string valor { get; set; }

        public ConfigMqtt(int idconfig, string valor)
        {
            this.idconfig = idconfig;
            this.valor = valor;
        }

    }
}
