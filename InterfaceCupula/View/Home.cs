using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceCupula;
using InterfaceCupula.Controller;
using InterfaceCupula.Models;

namespace InterfaceCupula.View
{
    public partial class Home : Form
    {
        Cadastro telaCadastro;

        bool shutterState = false;
        int antigo_valor = 0;


        MQTTConnection mqttConnectionShutter;
        MQTTConnection mqttConnectionAH;
        MQTTConnection mqttConnectionH;
        MQTTConnection mqttConnectionAzm;
        MQTTConnection mqttConnectionSinc;

        MQTTConnection mqttConnectionCmdExterno;
        MQTTConnection mqttConnectioninfoTrapeira;
        MQTTConnection mqttConnectioninfoAzmDomo;
        MQTTConnection mqttConnectioninfoPosHome;
        MQTTConnection mqttConnectioninfoPosPark;
        MQTTConnection mqttConnectioninfoResolucao;
        MQTTConnection mqttConnectioninfoSincTelescopio;
        MQTTConnection mqttConnectioninfoPosTelescopio;
        MQTTConnection mqttConnectioninfoVelDomo;

        public string strCfgShutter { get; set; }
        public string strCfgAH { get; set; }
        public string strCfgH { get; set; }
        public string strCfgAzm { get; set; }
        public string strCfgSinc { get; set; }
        public string strCfgCmdExterno { get; set; }
        public string strCfgInfoTpr { get; set; }
        public string strCfgInfoAzm { get; set; }
        public string strCfgInfoHome { get; set; }
        public string strCfgInfoPark { get; set; }
        public string strCfgInfoResol { get; set; }
        public string strCfgInfoSinc { get; set; }
        public string strCfgInfoPos { get; set; }
        public string strCfgInfoVelDomo { get; set; }

        public string brokerConfig { get; set; }

        public int mqttPort { get; set; }

        public Home()
        {
            InitializeComponent();
            List<ConfigMqtt> itens = DatabaseManipulation.DBConfigMqtt();

            mqttConnectionShutter                 = new MQTTConnection();
            mqttConnectionAH                      = new MQTTConnection();
            mqttConnectionH                       = new MQTTConnection();
            mqttConnectionAzm                     = new MQTTConnection();
            mqttConnectionSinc                    = new MQTTConnection();
            mqttConnectionCmdExterno              = new MQTTConnection();
            mqttConnectioninfoTrapeira            = new MQTTConnection();
            mqttConnectioninfoAzmDomo             = new MQTTConnection();
            mqttConnectioninfoPosHome             = new MQTTConnection();
            mqttConnectioninfoPosPark             = new MQTTConnection();
            mqttConnectioninfoResolucao           = new MQTTConnection();
            mqttConnectioninfoSincTelescopio      = new MQTTConnection();
            mqttConnectioninfoPosTelescopio       = new MQTTConnection();
            mqttConnectioninfoVelDomo             = new MQTTConnection();

           

            brokerConfig = itens[0].valor;
            mqttPort = int.Parse(itens[1].valor);
           
            strCfgShutter = itens[2].valor;
            strCfgAH = itens[3].valor;
            strCfgH = itens[4].valor;
            strCfgAzm = itens[5].valor;
            strCfgSinc = itens[6].valor;
            strCfgCmdExterno = itens[7].valor;
            strCfgInfoTpr = itens[8].valor;
            strCfgInfoAzm = itens[9].valor;
            strCfgInfoHome = itens[10].valor;
            strCfgInfoPark = itens[11].valor;
            strCfgInfoResol = itens[12].valor;
            strCfgInfoSinc = itens[13].valor;
            strCfgInfoPos = itens[14].valor;
            strCfgInfoVelDomo = itens[15].valor;


            mqttConnectionShutter.StartConnection(brokerConfig, mqttPort, strCfgShutter);
            mqttConnectionAH.StartConnection(brokerConfig, mqttPort, strCfgAH);
            mqttConnectionH.StartConnection(brokerConfig, mqttPort, strCfgH);
            mqttConnectionAzm.StartConnection(brokerConfig, mqttPort, strCfgAzm);
            mqttConnectionSinc.StartConnection(brokerConfig, mqttPort, strCfgSinc);

            mqttConnectionCmdExterno.StartConnection(brokerConfig, mqttPort, strCfgCmdExterno);
            mqttConnectioninfoTrapeira.StartConnection(brokerConfig, mqttPort, strCfgInfoTpr);
            mqttConnectioninfoAzmDomo.StartConnection(brokerConfig, mqttPort, strCfgInfoAzm);
            mqttConnectioninfoPosHome.StartConnection(brokerConfig, mqttPort, strCfgInfoHome);
            mqttConnectioninfoPosPark.StartConnection(brokerConfig, mqttPort, strCfgInfoPark);
            mqttConnectioninfoResolucao.StartConnection(brokerConfig, mqttPort, strCfgInfoResol);
            mqttConnectioninfoSincTelescopio.StartConnection(brokerConfig, mqttPort, strCfgInfoSinc);
            mqttConnectioninfoPosTelescopio.StartConnection(brokerConfig, mqttPort, strCfgInfoPos);
            mqttConnectioninfoVelDomo.StartConnection(brokerConfig, mqttPort, strCfgInfoVelDomo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
            
         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 telaLogin = new Form1();
            telaLogin.ShowDialog();
            this.Close();
        }
                    
        private void btnRegister_Click(object sender, EventArgs e)
        {
            telaCadastro = new Cadastro();

            this.Hide();
            telaCadastro.ShowDialog();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void painelEsquerdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painelInversor(object sender, EventArgs e)
        {
          

        }

        private void OpClShutter_Click(object sender, EventArgs e)
        {
            shutterState = !shutterState;
            String toSend;

            toSend = "1";

            try
            {
                mqttConnectionShutter.PublishAsync(toSend);
            }
            catch (Exception)
            {

                throw;
            }
        }

    
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mqttConnectionCmdExterno.getMsg().Equals("1"))
                {
                    if (mqttConnectioninfoSincTelescopio.getMsg().Equals("0"))
                    {
                        comandosMQTT.Checked = true;
                        comandosMQTT.Checked = true;
                        OpClShutter.Enabled = true;
                        btnRev.Enabled = true;
                        btnFw.Enabled = true;
                        Go.Enabled = true;
                        azimuteChange.Enabled = true;
                    }
                }
                else
                {
                    comandosMQTT.Checked = false;
                    OpClShutter.Enabled = false;
                    btnRev.Enabled = false;
                    btnFw.Enabled = false;
                    Go.Enabled = false;
                    azimuteChange.Enabled = false;

                    if (mqttConnectioninfoSincTelescopio.getMsg().Equals("1"))
                    {
                        sincronizarTel.Checked = true;
                    }
                    else
                    {
                        sincronizarTel.Checked = false;
                    }
                }

                if (mqttConnectioninfoTrapeira.getMsg().Equals("1"))
                {
                    msgShutter.Text = "Aberta";
                }
                else if (mqttConnectioninfoTrapeira.getMsg().Equals("2"))
                {
                    msgShutter.Text = "Aguardando";
                }
                else
                {
                    msgShutter.Text = "Fechada";
                }
                                
                msgAzimute.Text = mqttConnectioninfoAzmDomo.getMsg() + ".0";
                msgPosHome.Text = convertBooleanToString(mqttConnectioninfoPosHome.getMsg());
                msgPark.Text = convertBooleanToString(mqttConnectioninfoPosPark.getMsg());
                msgResol.Text = mqttConnectioninfoResolucao.getMsg() + ".0";
            }
            catch (Exception)
            {

            }
        }

        private void textBoxTrapeira_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            mqttConnectionAH.PublishAsync("1");
        }

        private void btnFwr_Click(object sender, EventArgs e)
        {
            mqttConnectionH.PublishAsync("1");
        }

        private void msgPark_TextChanged(object sender, EventArgs e)
        {

        }    

        private void comandosMQTT_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void sincronizarTel_CheckedChanged(object sender, EventArgs e)
        {
            
            if(sincronizarTel.Checked)
            {
                mqttConnectionSinc.PublishAsync("1");
                sincronizarTel.Checked = true;
            }
            else
            {
                mqttConnectionSinc.PublishAsync("0");
                sincronizarTel.Checked = false;
            }

        }

        private void Go_Click(object sender, EventArgs e)
        {
            mqttConnectionAzm.PublishAsync(azimuteChange.Value.ToString());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string convertBooleanToString(string toConvert)
        {
            if (toConvert.Equals("1"))
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void azimuteChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void azimuteChange_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void azimuteChange_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.Parse(azimuteChange.Value.ToString()) > 359)
            {
                azimuteChange.Value = Decimal.Parse(antigo_valor.ToString());
            }
            else
            {
                antigo_valor = int.Parse(azimuteChange.Value.ToString());

            }
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
