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
using InterfaceCupula.Models;
using InterfaceCupula.View;


namespace InterfaceCupula
{
    public partial class Form1 : Form
    {
        bool controlaClickNome = true;
        bool controlaClickSenha = true;
        bool logginState = false;
        Home telaHome;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            List<Usuario> dataUsers;

            if (BoxSenha.Text.Equals("Senha") || BoxNome.Text.Length.Equals("Nome do usuário") || BoxNome.Text.Length == 0 || BoxSenha.Text.Length == 0)
            {

                AtualizarEstadoMsgBox();
            }
            else
            {

                dataUsers = DatabaseManipulation.DBUsers();
               

                foreach (Usuario user in dataUsers)
                {
                   

                    if (user.Nome.Equals(BoxNome.Text) && user.Senha.Equals(BoxSenha.Text))
                    {

                      
                        //Vai para a outra tela
                        Program.setUserLogged(user);
                        telaHome = new Home();

                        this.Hide();
                        telaHome.ShowDialog();
                        logginState = true;
                        this.Close();
                    } 

                }
                if (!logginState)
                {
                    //indica ao usuário que não há um cadastro com os dados passados
                    MessageBox.Show("Não há um usuário cadastrado com esses dados", "Erro no acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarEstadoMsgBox();
                }
            }
        }

        private void botaoApagar_Click(object sender, EventArgs e)
        {
            AtualizarEstadoMsgBox();

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

        private void AtualizarEstadoMsgBox()
        {

            BoxNome.Text = "Nome do usuário";
            BoxSenha.Text = "Senha";
            controlaClickNome = true;
            controlaClickSenha = true;
            BoxSenha.UseSystemPasswordChar = false;
            BoxSenha.PasswordChar = '\0';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
