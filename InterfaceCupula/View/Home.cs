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

namespace InterfaceCupula.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            textBox3.Text = Program.getUserLogged().Nome;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnHabilita_Click(object sender, EventArgs e)
        {

        }

        private void btnSt_Stop_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 telaLogin = new Form1();
            telaLogin.ShowDialog();
            this.Close();
        }

        private void btnFw_Rv_Click(object sender, EventArgs e)
        {

        }

        private void ajusteVelocidade_Scroll(object sender, EventArgs e)
        {
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
