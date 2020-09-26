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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.azimuteChange = new System.Windows.Forms.NumericUpDown();
            this.Go = new System.Windows.Forms.Button();
            this.OpClShutter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.comandosMQTT = new System.Windows.Forms.CheckBox();
            this.sincronizarTel = new System.Windows.Forms.CheckBox();
            this.painelEsquerdo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azimuteChange)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.painelEsquerdo.Location = new System.Drawing.Point(9, 12);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(326, 157);
            this.painelEsquerdo.TabIndex = 0;
            this.painelEsquerdo.Paint += new System.Windows.Forms.PaintEventHandler(this.painelEsquerdo_Paint);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(3, 111);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(172, 18);
            this.textBox10.TabIndex = 14;
            this.textBox10.Text = "Janela de movimento (deg): ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(17, 85);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 18);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "Posicao Park";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(17, 62);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 18);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "Posicao Home";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(3, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(137, 18);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Azimute Cupula (deg):";
            // 
            // msgResol
            // 
            this.msgResol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgResol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgResol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgResol.Location = new System.Drawing.Point(176, 113);
            this.msgResol.Name = "msgResol";
            this.msgResol.ReadOnly = true;
            this.msgResol.Size = new System.Drawing.Size(144, 13);
            this.msgResol.TabIndex = 10;
            this.msgResol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msgPark
            // 
            this.msgPark.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgPark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgPark.Location = new System.Drawing.Point(178, 90);
            this.msgPark.Name = "msgPark";
            this.msgPark.ReadOnly = true;
            this.msgPark.Size = new System.Drawing.Size(143, 13);
            this.msgPark.TabIndex = 9;
            this.msgPark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msgPark.TextChanged += new System.EventHandler(this.msgPark_TextChanged);
            // 
            // msgPosHome
            // 
            this.msgPosHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgPosHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgPosHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgPosHome.Location = new System.Drawing.Point(176, 62);
            this.msgPosHome.Name = "msgPosHome";
            this.msgPosHome.ReadOnly = true;
            this.msgPosHome.Size = new System.Drawing.Size(144, 13);
            this.msgPosHome.TabIndex = 8;
            this.msgPosHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msgPosHome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // msgShutter
            // 
            this.msgShutter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgShutter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgShutter.ForeColor = System.Drawing.Color.Black;
            this.msgShutter.Location = new System.Drawing.Point(176, 11);
            this.msgShutter.Name = "msgShutter";
            this.msgShutter.ReadOnly = true;
            this.msgShutter.Size = new System.Drawing.Size(143, 16);
            this.msgShutter.TabIndex = 2;
            this.msgShutter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTrapeira
            // 
            this.textBoxTrapeira.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTrapeira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTrapeira.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrapeira.Location = new System.Drawing.Point(17, 11);
            this.textBoxTrapeira.Name = "textBoxTrapeira";
            this.textBoxTrapeira.ReadOnly = true;
            this.textBoxTrapeira.Size = new System.Drawing.Size(100, 18);
            this.textBoxTrapeira.TabIndex = 0;
            this.textBoxTrapeira.Text = "Trapeira:";
            this.textBoxTrapeira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTrapeira.TextChanged += new System.EventHandler(this.textBoxTrapeira_TextChanged);
            // 
            // msgAzimute
            // 
            this.msgAzimute.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.msgAzimute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgAzimute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgAzimute.ForeColor = System.Drawing.Color.Black;
            this.msgAzimute.Location = new System.Drawing.Point(176, 37);
            this.msgAzimute.Name = "msgAzimute";
            this.msgAzimute.ReadOnly = true;
            this.msgAzimute.Size = new System.Drawing.Size(144, 16);
            this.msgAzimute.TabIndex = 7;
            this.msgAzimute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(99, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(142, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Azimute destino";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnFw
            // 
            this.btnFw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFw.Location = new System.Drawing.Point(330, 52);
            this.btnFw.Name = "btnFw";
            this.btnFw.Size = new System.Drawing.Size(142, 23);
            this.btnFw.TabIndex = 1;
            this.btnFw.Text = "Girar horário";
            this.btnFw.UseVisualStyleBackColor = false;
            this.btnFw.Click += new System.EventHandler(this.btnFwr_Click);
            // 
            // btnRev
            // 
            this.btnRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRev.ForeColor = System.Drawing.Color.Black;
            this.btnRev.Location = new System.Drawing.Point(58, 52);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(142, 23);
            this.btnRev.TabIndex = 0;
            this.btnRev.Text = "Girar anti-horário";
            this.btnRev.UseVisualStyleBackColor = false;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 16);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 18);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Acesso por:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp4;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Location = new System.Drawing.Point(10, 338);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(64, 53);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp3;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(87, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 395);
            this.splitter1.TabIndex = 7;
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
            this.panel1.Location = new System.Drawing.Point(10, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 140);
            this.panel1.TabIndex = 8;
            // 
            // azimuteChange
            // 
            this.azimuteChange.Location = new System.Drawing.Point(247, 94);
            this.azimuteChange.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.azimuteChange.Name = "azimuteChange";
            this.azimuteChange.Size = new System.Drawing.Size(51, 20);
            this.azimuteChange.TabIndex = 12;
            this.azimuteChange.TabStop = false;
            this.azimuteChange.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.azimuteChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.azimuteChange_KeyDown);
            this.azimuteChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.azimuteChange_KeyPress);
            this.azimuteChange.KeyUp += new System.Windows.Forms.KeyEventHandler(this.azimuteChange_KeyUp);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(321, 94);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(53, 23);
            this.Go.TabIndex = 8;
            this.Go.Text = "Ir";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // OpClShutter
            // 
            this.OpClShutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OpClShutter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpClShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpClShutter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpClShutter.Location = new System.Drawing.Point(200, 23);
            this.OpClShutter.Name = "OpClShutter";
            this.OpClShutter.Size = new System.Drawing.Size(143, 23);
            this.OpClShutter.TabIndex = 1;
            this.OpClShutter.Text = "Acionar trapeira";
            this.OpClShutter.UseVisualStyleBackColor = false;
            this.OpClShutter.Click += new System.EventHandler(this.OpClShutter_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(341, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 63);
            this.panel2.TabIndex = 9;
            // 
            // comandosMQTT
            // 
            this.comandosMQTT.AutoSize = true;
            this.comandosMQTT.Enabled = false;
            this.comandosMQTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comandosMQTT.Location = new System.Drawing.Point(341, 11);
            this.comandosMQTT.Name = "comandosMQTT";
            this.comandosMQTT.Size = new System.Drawing.Size(203, 21);
            this.comandosMQTT.TabIndex = 10;
            this.comandosMQTT.Text = "Habilitar comandos remotos";
            this.comandosMQTT.UseVisualStyleBackColor = true;
            this.comandosMQTT.CheckedChanged += new System.EventHandler(this.comandosMQTT_CheckedChanged);
            // 
            // sincronizarTel
            // 
            this.sincronizarTel.AutoSize = true;
            this.sincronizarTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sincronizarTel.Location = new System.Drawing.Point(341, 50);
            this.sincronizarTel.Name = "sincronizarTel";
            this.sincronizarTel.Size = new System.Drawing.Size(208, 21);
            this.sincronizarTel.TabIndex = 11;
            this.sincronizarTel.Text = "Sincronizar com o telescópio";
            this.sincronizarTel.UseVisualStyleBackColor = true;
            this.sincronizarTel.CheckedChanged += new System.EventHandler(this.sincronizarTel_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(551, 395);
            this.Controls.Add(this.sincronizarTel);
            this.Controls.Add(this.comandosMQTT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.painelEsquerdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 434);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle do inversor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.painelEsquerdo.ResumeLayout(false);
            this.painelEsquerdo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.azimuteChange)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelEsquerdo;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnFw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox comandosMQTT;
        private System.Windows.Forms.CheckBox sincronizarTel;
        private System.Windows.Forms.NumericUpDown azimuteChange;
    }
}