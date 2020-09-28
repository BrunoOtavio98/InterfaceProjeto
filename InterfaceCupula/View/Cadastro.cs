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

namespace InterfaceCupula.View
{
    public partial class Cadastro : Form
    {
        Home telaHome;

        public Cadastro()
        {
            InitializeComponent();
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
            telaHome = new Home();

            this.Hide();
            telaHome.ShowDialog();
       
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario(textBox1.Text, textBox3.Text);


            if (textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
            {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
