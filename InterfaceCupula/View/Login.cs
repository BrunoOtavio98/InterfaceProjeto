using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceCupula.Controller;

namespace InterfaceCupula
{
    public partial class Form1 : Form
    {
        bool controlaClickNome = true;
        bool controlaClickSenha = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {

            if (BoxSenha.Text.Equals("Senha") || BoxNome.Text.Length.Equals("Nome do usuário"))
            {

                BoxSenha.UseSystemPasswordChar = false;
                BoxSenha.PasswordChar = '\0';

                BoxNome.Text = "Nome do usuário";
                BoxSenha.Text = "Senha";


                controlaClickNome = true;
                controlaClickSenha = true;
            }
            else
            {



            }
        }

        private void botaoApagar_Click(object sender, EventArgs e)
        {
            BoxSenha.UseSystemPasswordChar = false;
            BoxSenha.PasswordChar = '\0';

            BoxNome.Text = "Nome de usuário";
            BoxSenha.Text = "Senha";
            

            controlaClickNome = true;
            controlaClickSenha = true;

        }

    
  
        private void BoxNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BoxNome_MouseClick(object sender, MouseEventArgs e)
        {

            if (controlaClickNome)
            {

                BoxNome.Text = string.Empty;
                controlaClickNome = false;
            }
        }

        private void BoxSenha_MouseClick(object sender, MouseEventArgs e)
        {
            BoxSenha.PasswordChar = '*';
            BoxSenha.UseSystemPasswordChar = true;
            

            if (controlaClickSenha)
            {

                BoxSenha.Text = string.Empty;
                controlaClickSenha = false;
            }
        }

        private void BoxSenha_ButtonAction(object sender, MouseEventArgs e)
        {
            BoxSenha.PasswordChar = '*';
            BoxSenha.UseSystemPasswordChar = true;


            if (controlaClickSenha)
            {

                BoxSenha.Text = string.Empty;
                controlaClickSenha = false;
            }
        }
    }
}
