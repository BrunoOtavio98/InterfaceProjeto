using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCupula.Models
{
    class Inversor
    {

        public bool GiraPara { get; set; }

        public bool Habilita { get; set; }

        public bool DirEsq { get; set; }

        public float ControleVelocidade { get; set; }

        public Inversor(bool gira_para, bool habilita, bool dir_esq, float controleVel)
        {

            GiraPara = gira_para;
            Habilita = habilita;
            DirEsq = dir_esq;
            ControleVelocidade = controleVel;
        }

      
        public Inversor()
        {



        }

    }
}
