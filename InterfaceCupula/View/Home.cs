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

namespace InterfaceCupula.View
{
    public partial class Home : Form
    {
        Cadastro telaCadastro;
        bool shutterState = false;
        MQTTConnection mqttConnecion;
        String receivedMessage;
       

        public Home()
        {
            InitializeComponent();
            mqttConnecion =  new MQTTConnection(ref receivedMessage);

              
            msgShutter.Text = "Fechada";
            textBox3.Text = Program.getUserLogged().Nome;

            textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Horario";

            mqttConnecion.StartConnection("broker.hivemq.com", 1883, "topicBruno");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnHabilita_Click(object sender, EventArgs e)
        {

            Console.WriteLine(receivedMessage);
            Program.inversorObj.Habilita = !Program.inversorObj.Habilita;

            if (!Program.inversorObj.Habilita)
            {
                textoPainel.Text = "Desabilitado";
                mqttConnecion.PublishAsync(textoPainel.Text);
            }
            else
            {
                if (Program.inversorObj.DirEsq)
                {
                    textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Horário";

                    
                }
                else
                {
                    textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Anti-horário";
                   
                }
            }
        }

        private void btnSt_Stop_Click(object sender, EventArgs e)
        {
            Program.inversorObj.GiraPara = !Program.inversorObj.GiraPara;

            if (Program.inversorObj.Habilita)
            {
                if (!Program.inversorObj.GiraPara)
                {
                    textoPainel.Text = "Parado";
                    mqttConnecion.PublishAsync(textoPainel.Text);
                }
                else
                {
                    if (Program.inversorObj.DirEsq)
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Horário";

                    }
                    else
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Anti-horário";
                    }

                }
            }
        }

        private void btnFw_Rv_Click(object sender, EventArgs e)
        {

            if (Program.inversorObj.Habilita)
            {

                if (Program.inversorObj.GiraPara)
                {
                    Program.inversorObj.DirEsq = !Program.inversorObj.DirEsq;

                    if (Program.inversorObj.DirEsq)
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Horário";
                        mqttConnecion.PublishAsync(textoPainel.Text);
                    }
                    else
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Anti-horário";
                        mqttConnecion.PublishAsync(textoPainel.Text);
                    }

                }
            }
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

        private void btn_ControleVelocidade(object sender, MouseEventArgs e)
        {
            float value;

            try
            {
                value = float.Parse(boxControleVel.Text);

                if (value > 66.0)
                    value = 66.0f;
                else if (value < 0)
                    value = 0.0f;
            }
            catch (Exception)
            {

                value = 0.0f;
            }
            Program.inversorObj.ControleVelocidade = value;
        }

        private void btn_ControleVelocidade(object sender, EventArgs e)
        {
            float value;

            try
            {
                value = float.Parse(boxControleVel.Text);

                if (value > 66.0)
                    value = 66.0f;
                else if (value < 0)
                    value = 0.0f;
            }
            catch (Exception)
            {
                value = Program.inversorObj.ControleVelocidade;
                
            }
            Program.inversorObj.ControleVelocidade = value;

            if (Program.inversorObj.Habilita)
            {

                if (Program.inversorObj.GiraPara)
                {
                    
                    if (Program.inversorObj.DirEsq)
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Horário";
                    }
                    else
                    {
                        textoPainel.Text = Program.inversorObj.ControleVelocidade + "Hz - Anti-horário";
                    }

                }
            }


        }

        private void OpClShutter_Click(object sender, EventArgs e)
        {
            shutterState = !shutterState;

            if (shutterState)
            {
                msgShutter.Text = "Aberta";
            }
            else
            {
                msgShutter.Text = "Fechada";
            }

        }
    }
}
