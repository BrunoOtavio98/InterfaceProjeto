using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceCupula.Controller;
using InterfaceCupula.View;
using InterfaceCupula.Models;

namespace InterfaceCupula
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
    
        static Usuario userLogged;
        static Inversor inversorObj;

        static void Main()
        {   
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            Form1 telaLogin = new Form1();
        
            Application.Run(telaLogin);
                
        }

        public static Usuario getUserLogged()
        {
            return userLogged;
        }

        public static void setUserLogged(Usuario user)
        {
            userLogged = new Usuario(user.userId, user.Nome, user.Senha);
        }

        public static Inversor getInversor()
        {
            return inversorObj;
        }

        public static void setInversor(Inversor inv)
        {

            inversorObj = new Inversor(inv.GiraPara, inv.Habilita, inv.DirEsq, inv.ControleVelocidade);
        }
    }
}
