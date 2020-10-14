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
using System.Security.Cryptography;
using InterfaceCupula.Enums;

namespace InterfaceCupula
{
    public partial class Form1 : Form
    {
        bool controlaClickNome = true;
        bool controlaClickSenha = true;
        bool logginState = false;
        Home telaHome;
        ConfiguracaoAttrMQTT cfgMqtt;

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

                MD5 md5 = MD5.Create();
                byte[] hashSenha;

                hashSenha = md5.ComputeHash(Encoding.ASCII.GetBytes(BoxSenha.Text));

                StringBuilder sBuilder = new StringBuilder();
                foreach ( byte item in hashSenha)
                {
                    sBuilder.Append(item.ToString("x2"));
                }

                foreach (Usuario user in dataUsers)
                {
                    if (user.Nome.Equals(BoxNome.Text) && user.Senha.Equals(sBuilder.ToString()))
                    {

                        //Vai para a outra tela
                        Program.setUserLogged(user);
                        this.Hide();

                        if (user.TipoUsuario == TiposDeUsuarios.Usuario)
                        {
                            telaHome = new Home();

                           
                            telaHome.ShowDialog();
                        }

                        else
                        {
                            cfgMqtt = new ConfiguracaoAttrMQTT();
                            cfgMqtt.ShowDialog();
                            
                        }

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

            BoxNome.Text = "";
            BoxSenha.Text = "";
            controlaClickNome = true;
            controlaClickSenha = true;
            BoxSenha.UseSystemPasswordChar = false;
            BoxSenha.PasswordChar = '\0';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ConfiLinguagem();

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox2.Text = "Português - PT";
                changeLanguage.UpdateConfig("language", "en");
                // Application.Restart();

                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
            {
                comboBox2.Text = "English - EN";
                changeLanguage.UpdateConfig("language", "en-US");
                //   Application.Restart();

                this.Controls.Clear();
                this.InitializeComponent();
            }
        }
    }
}
