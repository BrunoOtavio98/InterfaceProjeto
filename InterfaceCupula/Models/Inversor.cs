using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCupula.Models
{
    class Inversor
    {

        public int GiraPara { get; set; }

        public int Habilita { get; set; }

        public int DirEsq { get; set; }

        public float ControleVelocidade { get; set; }

        public Inversor(int gira_para, int habilita, int dir_esq, float controleVel)
        {

            GiraPara = gira_para;
            Habilita = habilita;
            DirEsq = dir_esq;
            ControleVelocidade = controleVel;
        }

    }
}
