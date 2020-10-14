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
using InterfaceCupula.Enums;

namespace InterfaceCupula.View
{
    public partial class Cadastro : Form
    {
        Home telaHome;
        ConfiguracaoAttrMQTT telacfgMqtt;

        public Cadastro()
        {
            InitializeComponent();

            if (Program.getUserLogged().TipoUsuario == TiposDeUsuarios.Administrador)
            {
                checkBoxAdm.Visible = true;
                textBoxAdm.Visible = true;

                checkBoxUser.Visible = true;
                textBoxUser.Visible = true;
            }
            else
            {
                checkBoxAdm.Visible = false;
                textBoxAdm.Visible = false;

                checkBoxUser.Visible = false;
                textBoxUser.Visible = false;
            }

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
  
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            returnInversorScreen();
        }

        private void returnInversorScreen()
        {

            if (Program.getUserLogged().TipoUsuario == TiposDeUsuarios.Administrador)
            {
                telacfgMqtt = new ConfiguracaoAttrMQTT();

                this.Hide();
                telacfgMqtt.ShowDialog();

                this.Close();
            }
            else
            {
                telaHome = new Home();

                this.Hide();
                telaHome.ShowDialog();

                this.Close();
            }
           
        }

        private void accept_Click(object sender, EventArgs e)
        {
            TiposDeUsuarios novoCadastro;
            Usuario newUser;

            if (checkBoxUser.Checked || checkBoxAdm.Checked || Program.getUserLogged().TipoUsuario == TiposDeUsuarios.Usuario) {

                if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                    
                    if (checkBoxUser.Checked || (Program.getUserLogged().TipoUsuario == TiposDeUsuarios.Usuario))
                    {
                        newUser = new Usuario(textBox1.Text, textBox3.Text, TiposDeUsuarios.Usuario);
                    }
                    else
                    {
                        newUser = new Usuario(textBox1.Text, textBox3.Text, TiposDeUsuarios.Administrador);
                    }

                    if (DatabaseManipulation.userRegister(newUser))              //se retornar true o usuario ja esta cadastrado
                    {
                        MessageBox.Show("Usuário já consta no sistema", "Mensagem cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "\0";
                        textBox3.Text = "\0";
                    }
                    else
                    {
                        MessageBox.Show("Cadastro efetuado", "Mensagem cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        returnInversorScreen();
                    }
                }
                else
                {
                    MessageBox.Show("Número de caracteres deve ser maior que zero", "Mensagem cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    returnInversorScreen();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxAdm_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ConfiLinguagem();

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox2.Text = "Português - PT";
                changeLanguage.UpdateConfig("language", "en");

                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
            {
                comboBox2.Text = "English - EN";
                changeLanguage.UpdateConfig("language", "en-US");

                this.Controls.Clear();
                this.InitializeComponent();
           
            }
        }
    }
}
