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
        public static Inversor inversorObj = new Inversor(true,true,true,0.0f);

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

     

    }
}
