using System.Configuration;
using System.Threading;

namespace InterfaceCupula.View
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.painelEsquerdo = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.msgResol = new System.Windows.Forms.TextBox();
            this.msgPark = new System.Windows.Forms.TextBox();
            this.msgPosHome = new System.Windows.Forms.TextBox();
            this.msgShutter = new System.Windows.Forms.TextBox();
            this.textBoxTrapeira = new System.Windows.Forms.TextBox();
            this.msgAzimute = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFw = new System.Windows.Forms.Button();
            this.btnRev = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.azimuteChange = new System.Windows.Forms.NumericUpDown();
            this.Go = new System.Windows.Forms.Button();
            this.OpClShutter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comandosMQTT = new System.Windows.Forms.CheckBox();
            this.sincronizarTel = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.painelEsquerdo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azimuteChange)).BeginInit();
            this.SuspendLayout();
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.painelEsquerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelEsquerdo.Controls.Add(this.textBox10);
            this.painelEsquerdo.Controls.Add(this.textBox9);
            this.painelEsquerdo.Controls.Add(this.textBox8);
            this.painelEsquerdo.Controls.Add(this.textBox7);
            this.painelEsquerdo.Controls.Add(this.msgResol);
            this.painelEsquerdo.Controls.Add(this.msgPark);
            this.painelEsquerdo.Controls.Add(this.msgPosHome);
            this.painelEsquerdo.Controls.Add(this.msgShutter);
            this.painelEsquerdo.Controls.Add(this.textBoxTrapeira);
            this.painelEsquerdo.Controls.Add(this.msgAzimute);
            resources.ApplyResources(this.painelEsquerdo, "painelEsquerdo");
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Paint += new System.Windows.Forms.PaintEventHandler(this.painelEsquerdo_Paint);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            // 
            // msgResol
            // 
            this.msgResol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgResol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgResol, "msgResol");
            this.msgResol.Name = "msgResol";
            this.msgResol.ReadOnly = true;
            // 
            // msgPark
            // 
            this.msgPark.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgPark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgPark, "msgPark");
            this.msgPark.Name = "msgPark";
            this.msgPark.ReadOnly = true;
            this.msgPark.TextChanged += new System.EventHandler(this.msgPark_TextChanged);
            // 
            // msgPosHome
            // 
            this.msgPosHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgPosHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgPosHome, "msgPosHome");
            this.msgPosHome.Name = "msgPosHome";
            this.msgPosHome.ReadOnly = true;
            this.msgPosHome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // msgShutter
            // 
            this.msgShutter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgShutter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgShutter, "msgShutter");
            this.msgShutter.ForeColor = System.Drawing.Color.Black;
            this.msgShutter.Name = "msgShutter";
            this.msgShutter.ReadOnly = true;
            // 
            // textBoxTrapeira
            // 
            this.textBoxTrapeira.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTrapeira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxTrapeira, "textBoxTrapeira");
            this.textBoxTrapeira.Name = "textBoxTrapeira";
            this.textBoxTrapeira.ReadOnly = true;
            this.textBoxTrapeira.TextChanged += new System.EventHandler(this.textBoxTrapeira_TextChanged);
            // 
            // msgAzimute
            // 
            this.msgAzimute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgAzimute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgAzimute, "msgAzimute");
            this.msgAzimute.ForeColor = System.Drawing.Color.Black;
            this.msgAzimute.Name = "msgAzimute";
            this.msgAzimute.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnFw
            // 
            this.btnFw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnFw, "btnFw");
            this.btnFw.Name = "btnFw";
            this.btnFw.UseVisualStyleBackColor = false;
            this.btnFw.Click += new System.EventHandler(this.btnFwr_Click);
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnRev, "btnRev");
            this.btnRev.ForeColor = System.Drawing.Color.Black;
            this.btnRev.Name = "btnRev";
            this.btnRev.UseVisualStyleBackColor = false;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.azimuteChange);
            this.panel1.Controls.Add(this.Go);
            this.panel1.Controls.Add(this.OpClShutter);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnFw);
            this.panel1.Controls.Add(this.btnRev);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // azimuteChange
            // 
            resources.ApplyResources(this.azimuteChange, "azimuteChange");
            this.azimuteChange.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.azimuteChange.Name = "azimuteChange";
            this.azimuteChange.TabStop = false;
            this.azimuteChange.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.azimuteChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.azimuteChange_KeyDown);
            this.azimuteChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.azimuteChange_KeyPress);
            this.azimuteChange.KeyUp += new System.Windows.Forms.KeyEventHandler(this.azimuteChange_KeyUp);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.Go, "Go");
            this.Go.Name = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // OpClShutter
            // 
            this.OpClShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.OpClShutter, "OpClShutter");
            this.OpClShutter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpClShutter.Name = "OpClShutter";
            this.OpClShutter.UseVisualStyleBackColor = false;
            this.OpClShutter.Click += new System.EventHandler(this.OpClShutter_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comandosMQTT
            // 
            resources.ApplyResources(this.comandosMQTT, "comandosMQTT");
            this.comandosMQTT.Name = "comandosMQTT";
            this.comandosMQTT.UseVisualStyleBackColor = true;
            this.comandosMQTT.CheckedChanged += new System.EventHandler(this.comandosMQTT_CheckedChanged);
            // 
            // sincronizarTel
            // 
            resources.ApplyResources(this.sincronizarTel, "sincronizarTel");
            this.sincronizarTel.Name = "sincronizarTel";
            this.sincronizarTel.UseVisualStyleBackColor = true;
            this.sincronizarTel.CheckedChanged += new System.EventHandler(this.sincronizarTel_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1")});
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp4;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp3;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.sincronizarTel);
            this.Controls.Add(this.comandosMQTT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.painelEsquerdo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.painelEsquerdo.ResumeLayout(false);
            this.painelEsquerdo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azimuteChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelEsquerdo;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnFw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox msgAzimute;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox msgShutter;
        private System.Windows.Forms.Button OpClShutter;
        private System.Windows.Forms.TextBox textBoxTrapeira;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox msgResol;
        private System.Windows.Forms.TextBox msgPark;
        private System.Windows.Forms.TextBox msgPosHome;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.CheckBox comandosMQTT;
        private System.Windows.Forms.CheckBox sincronizarTel;
        private System.Windows.Forms.NumericUpDown azimuteChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}