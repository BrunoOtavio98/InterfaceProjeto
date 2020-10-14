using System.Threading;
using System.Configuration;

namespace InterfaceCupula.View
{
    partial class ConfiguracaoAttrMQTT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracaoAttrMQTT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.textNovoTopico = new System.Windows.Forms.TextBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.textTopico = new System.Windows.Forms.TextBox();
            this.novoTopico = new System.Windows.Forms.TextBox();
            this.textoTopicoAtual = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.painelInfoVel = new System.Windows.Forms.Panel();
            this.aplicarInfoVel = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.cfgInfoVelocidade = new System.Windows.Forms.Button();
            this.painelInfoPos = new System.Windows.Forms.Panel();
            this.aplicarInfoPos = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.painelInfoVel.SuspendLayout();
            this.painelInfoPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.textNovoTopico);
            this.panel1.Controls.Add(this.btnMudar);
            this.panel1.Controls.Add(this.textTopico);
            this.panel1.Controls.Add(this.novoTopico);
            this.panel1.Controls.Add(this.textoTopicoAtual);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.painelInfoVel);
            this.panel1.Controls.Add(this.cfgInfoVelocidade);
            this.panel1.Controls.Add(this.painelInfoPos);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnApagar
            // 
            resources.ApplyResources(this.btnApagar, "btnApagar");
            this.btnApagar.BackColor = System.Drawing.Color.Yellow;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // textNovoTopico
            // 
            resources.ApplyResources(this.textNovoTopico, "textNovoTopico");
            this.textNovoTopico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textNovoTopico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNovoTopico.Name = "textNovoTopico";
            // 
            // btnMudar
            // 
            resources.ApplyResources(this.btnMudar, "btnMudar");
            this.btnMudar.BackColor = System.Drawing.Color.Lime;
            this.btnMudar.FlatAppearance.BorderSize = 0;
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.UseVisualStyleBackColor = false;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // textTopico
            // 
            resources.ApplyResources(this.textTopico, "textTopico");
            this.textTopico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textTopico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTopico.Name = "textTopico";
            this.textTopico.TextChanged += new System.EventHandler(this.textTopico_TextChanged);
            // 
            // novoTopico
            // 
            resources.ApplyResources(this.novoTopico, "novoTopico");
            this.novoTopico.BackColor = System.Drawing.Color.LightGray;
            this.novoTopico.Name = "novoTopico";
            this.novoTopico.TextChanged += new System.EventHandler(this.novoTopico_TextChanged);
            // 
            // textoTopicoAtual
            // 
            resources.ApplyResources(this.textoTopicoAtual, "textoTopicoAtual");
            this.textoTopicoAtual.BackColor = System.Drawing.Color.LightGray;
            this.textoTopicoAtual.Name = "textoTopicoAtual";
            this.textoTopicoAtual.ReadOnly = true;
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12"),
            resources.GetString("comboBox1.Items13"),
            resources.GetString("comboBox1.Items14"),
            resources.GetString("comboBox1.Items15")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // painelInfoVel
            // 
            resources.ApplyResources(this.painelInfoVel, "painelInfoVel");
            this.painelInfoVel.Controls.Add(this.aplicarInfoVel);
            this.painelInfoVel.Controls.Add(this.textBox13);
            this.painelInfoVel.Name = "painelInfoVel";
            // 
            // aplicarInfoVel
            // 
            resources.ApplyResources(this.aplicarInfoVel, "aplicarInfoVel");
            this.aplicarInfoVel.BackColor = System.Drawing.Color.Lime;
            this.aplicarInfoVel.Name = "aplicarInfoVel";
            this.aplicarInfoVel.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.BackColor = System.Drawing.Color.LightGray;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Name = "textBox13";
            // 
            // cfgInfoVelocidade
            // 
            resources.ApplyResources(this.cfgInfoVelocidade, "cfgInfoVelocidade");
            this.cfgInfoVelocidade.Name = "cfgInfoVelocidade";
            this.cfgInfoVelocidade.UseVisualStyleBackColor = true;
            // 
            // painelInfoPos
            // 
            resources.ApplyResources(this.painelInfoPos, "painelInfoPos");
            this.painelInfoPos.Controls.Add(this.aplicarInfoPos);
            this.painelInfoPos.Controls.Add(this.textBox16);
            this.painelInfoPos.Name = "painelInfoPos";
            // 
            // aplicarInfoPos
            // 
            resources.ApplyResources(this.aplicarInfoPos, "aplicarInfoPos");
            this.aplicarInfoPos.BackColor = System.Drawing.Color.Lime;
            this.aplicarInfoPos.Name = "aplicarInfoPos";
            this.aplicarInfoPos.UseVisualStyleBackColor = false;
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.BackColor = System.Drawing.Color.LightGray;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Name = "textBox16";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.BackColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp4;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp3;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ConfiguracaoAttrMQTT
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ConfiguracaoAttrMQTT";
            this.Load += new System.EventHandler(this.ConfiguracaoAttrMQTT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelInfoVel.ResumeLayout(false);
            this.painelInfoVel.PerformLayout();
            this.painelInfoPos.ResumeLayout(false);
            this.painelInfoPos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelInfoVel;
        private System.Windows.Forms.Button aplicarInfoVel;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button cfgInfoVelocidade;
        private System.Windows.Forms.Panel painelInfoPos;
        private System.Windows.Forms.Button aplicarInfoPos;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textNovoTopico;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.TextBox textTopico;
        private System.Windows.Forms.TextBox novoTopico;
        private System.Windows.Forms.TextBox textoTopicoAtual;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}