using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceCupula.Models;
using InterfaceCupula.Controller;
using System.Configuration;

namespace InterfaceCupula.View
{
    public partial class ConfiguracaoAttrMQTT : Form
    {

        private int lastSelect = -1;
        private List<ConfigMqtt> atual_config;
        private Cadastro telaCadastro;
        public ConfiguracaoAttrMQTT()
        {
            InitializeComponent();

            atual_config = DatabaseManipulation.DBConfigMqtt();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfiguracaoAttrMQTT_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 telaLogin = new Form1();
            telaLogin.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textTopico.Text = "Tópico atual";
            textNovoTopico.Text = "Novo tópico";
            var language = ConfigurationManager.AppSettings["language"];

            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    if (language.Equals("en")) {
                        textTopico.Text = "Broker atual";
                        textNovoTopico.Text = "Novo Broker";
                     }
                    else
                    {
                        textTopico.Text = "Current Broker";
                        textNovoTopico.Text = "New Broker";
                    }
                    textoTopicoAtual.Text = atual_config[0].valor;
                    lastSelect = 0;
                    break;
                case 1:

                    if (language.Equals("en")) {
                        textTopico.Text = "Porta atual";
                        textNovoTopico.Text = "Nova Porta";
                    }
                    else
                    {
                        textTopico.Text = "Current Port";
                        textNovoTopico.Text = "New Port";
                    }

                    textoTopicoAtual.Text = atual_config[1].valor;
                    lastSelect = 1;
                    break;
                case 2:
                    textoTopicoAtual.Text = atual_config[2].valor;
                    lastSelect = 2;
                    break;
                case 3:
                    textoTopicoAtual.Text = atual_config[3].valor;
                    lastSelect = 3;
                    break;
                case 4:
                    textoTopicoAtual.Text = atual_config[4].valor;
                    lastSelect = 4;
                    break;
                case 5:
                    textoTopicoAtual.Text = atual_config[5].valor;
                    lastSelect = 5;
                    break;
                case 6:
                    textoTopicoAtual.Text = atual_config[6].valor;
                    lastSelect = 6;
                    break;
                case 7:
                    textoTopicoAtual.Text = atual_config[7].valor;
                    lastSelect = 7;
                    break;
                case 8:
                    textoTopicoAtual.Text = atual_config[8].valor;
                    lastSelect = 8;
                    break;
                case 9:
                    textoTopicoAtual.Text = atual_config[9].valor;
                    lastSelect = 9;
                    break;
                case 10:
                    textoTopicoAtual.Text = atual_config[10].valor;
                    lastSelect = 10;
                    break;
                case 11:
                    textoTopicoAtual.Text = atual_config[11].valor;
                    lastSelect = 11;
                    break;
                case 12:
                    textoTopicoAtual.Text = atual_config[12].valor;
                    lastSelect = 12;
                    break;
                case 13:
                    textoTopicoAtual.Text = atual_config[13].valor;
                    lastSelect = 13;
                    break;

                case 14:
                    textoTopicoAtual.Text = atual_config[14].valor;
                    lastSelect = 14;
                    break;
                case 15:
                    textoTopicoAtual.Text = atual_config[15].valor;
                    lastSelect = 15;
                    break;
            }
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            if (novoTopico.Text.Length > 0){
             
            switch (lastSelect)
             {
               
                case 0:
                    atual_config[0].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[0].idconfig, atual_config[0].valor);
                break;
                case 1:
                        atual_config[1].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[1].idconfig, atual_config[1].valor);
                break;
                case 2:
                    atual_config[2].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[2].idconfig, atual_config[2].valor);
                break;
                case 3:
                    atual_config[3].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[3].idconfig, atual_config[3].valor);
                break;
                case 4:
                    atual_config[4].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[4].idconfig, atual_config[4].valor);
                break;
                case 5:
                    atual_config[5].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[5].idconfig, atual_config[5].valor);
                break;
                case 6:
                    atual_config[6].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[6].idconfig, atual_config[6].valor);
                break;
                case 7:
                    atual_config[7].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[7].idconfig, atual_config[7].valor);
                break;
                case 8:
                    atual_config[8].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[8].idconfig, atual_config[8].valor);
                break;
                case 9:
                    atual_config[9].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[9].idconfig, atual_config[9].valor);
                break;
                case 10:
                    atual_config[10].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[10].idconfig, atual_config[10].valor);
                break;
                case 11:
                    atual_config[11].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[11].idconfig, atual_config[11].valor);
                break;
                case 12:
                    atual_config[12].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[12].idconfig, atual_config[12].valor);
                break;
                case 13:
                    atual_config[13].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[13].idconfig, atual_config[13].valor);
                break;
                case 14:
                    atual_config[14].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[14].idconfig, atual_config[14].valor);
                break;
                case 15:
                    atual_config[15].valor = novoTopico.Text;
                    textoTopicoAtual.Text = novoTopico.Text;
                    DatabaseManipulation.changeConfigMqtt(atual_config[15].idconfig, atual_config[15].valor);
                break;
            }
            lastSelect = -1;
        }
        }

        private void novoTopico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            novoTopico.Text = " ";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            telaCadastro = new Cadastro();

            this.Hide();
            telaCadastro.ShowDialog();
            this.Close();

        }

        private void textTopico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
