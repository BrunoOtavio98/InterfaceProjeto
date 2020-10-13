using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceCupula.View
{
    public partial class ConfiguracaoAttrMQTT : Form
    {
        public ConfiguracaoAttrMQTT()
        {
            InitializeComponent();

            /*
            painelBroker.Visible = false;
            painelPorta.Visible = false;

            painelTrapeira.Visible = false;
            painelHorario.Visible = false;
            painelAHorario.Visible = false;
            painelAzimute.Visible = false;
            painelSinc.Visible = false;
            painelCmdRemoto.Visible = false;
            painelInfoTrap.Visible = false;
            painelInfoAzimute.Visible = false;
            painelInfoHome.Visible = false;
            painelInfoPark.Visible = false;
            painelInfoResol.Visible = false;
            painelInfoSinc.Visible = false;
            painelInfoPos.Visible = false;
            painelInfoVel.Visible = false;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void aplicarBroker_Click(object sender, EventArgs e)
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
    }
}
