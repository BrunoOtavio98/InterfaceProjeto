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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.painelEsquerdo = new System.Windows.Forms.Panel();
            this.btnControleVelocidade = new System.Windows.Forms.Button();
            this.boxControleVel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHabilita = new System.Windows.Forms.Button();
            this.btnFw_Rv = new System.Windows.Forms.Button();
            this.btnStart_Stop = new System.Windows.Forms.Button();
            this.textoPainel = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgShutter = new System.Windows.Forms.TextBox();
            this.OpClShutter = new System.Windows.Forms.Button();
            this.textBoxTrapeira = new System.Windows.Forms.TextBox();
            this.painelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelEsquerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelEsquerdo.Controls.Add(this.btnControleVelocidade);
            this.painelEsquerdo.Controls.Add(this.boxControleVel);
            this.painelEsquerdo.Controls.Add(this.textBox2);
            this.painelEsquerdo.Controls.Add(this.btnHabilita);
            this.painelEsquerdo.Controls.Add(this.btnFw_Rv);
            this.painelEsquerdo.Controls.Add(this.btnStart_Stop);
            this.painelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(144, 188);
            this.painelEsquerdo.TabIndex = 0;
            this.painelEsquerdo.Paint += new System.Windows.Forms.PaintEventHandler(this.painelEsquerdo_Paint);
            // 
            // btnControleVelocidade
            // 
            this.btnControleVelocidade.BackColor = System.Drawing.Color.Teal;
            this.btnControleVelocidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnControleVelocidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleVelocidade.Location = new System.Drawing.Point(0, 46);
            this.btnControleVelocidade.Name = "btnControleVelocidade";
            this.btnControleVelocidade.Size = new System.Drawing.Size(142, 35);
            this.btnControleVelocidade.TabIndex = 8;
            this.btnControleVelocidade.Text = "Controle Velocidade";
            this.btnControleVelocidade.UseVisualStyleBackColor = false;
            this.btnControleVelocidade.Click += new System.EventHandler(this.btn_ControleVelocidade);
            this.btnControleVelocidade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ControleVelocidade);
            // 
            // boxControleVel
            // 
            this.boxControleVel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.boxControleVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxControleVel.ForeColor = System.Drawing.Color.Black;
            this.boxControleVel.Location = new System.Drawing.Point(0, 24);
            this.boxControleVel.Name = "boxControleVel";
            this.boxControleVel.Size = new System.Drawing.Size(144, 23);
            this.boxControleVel.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Teal;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(142, 27);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Acesso ao inversor";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHabilita
            // 
            this.btnHabilita.BackColor = System.Drawing.Color.Teal;
            this.btnHabilita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHabilita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilita.Location = new System.Drawing.Point(0, 81);
            this.btnHabilita.Name = "btnHabilita";
            this.btnHabilita.Size = new System.Drawing.Size(142, 35);
            this.btnHabilita.TabIndex = 2;
            this.btnHabilita.Text = "HabilitaGeral";
            this.btnHabilita.UseVisualStyleBackColor = false;
            this.btnHabilita.Click += new System.EventHandler(this.btnHabilita_Click);
            // 
            // btnFw_Rv
            // 
            this.btnFw_Rv.BackColor = System.Drawing.Color.Teal;
            this.btnFw_Rv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFw_Rv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFw_Rv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFw_Rv.Location = new System.Drawing.Point(0, 116);
            this.btnFw_Rv.Name = "btnFw_Rv";
            this.btnFw_Rv.Size = new System.Drawing.Size(142, 35);
            this.btnFw_Rv.TabIndex = 1;
            this.btnFw_Rv.Text = "Horario/Antihorario";
            this.btnFw_Rv.UseVisualStyleBackColor = false;
            this.btnFw_Rv.Click += new System.EventHandler(this.btnFw_Rv_Click);
            // 
            // btnStart_Stop
            // 
            this.btnStart_Stop.BackColor = System.Drawing.Color.Teal;
            this.btnStart_Stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_Stop.ForeColor = System.Drawing.Color.Black;
            this.btnStart_Stop.Location = new System.Drawing.Point(0, 151);
            this.btnStart_Stop.Name = "btnStart_Stop";
            this.btnStart_Stop.Size = new System.Drawing.Size(142, 35);
            this.btnStart_Stop.TabIndex = 0;
            this.btnStart_Stop.Text = "Gira/Para";
            this.btnStart_Stop.UseVisualStyleBackColor = false;
            this.btnStart_Stop.Click += new System.EventHandler(this.btnSt_Stop_Click);
            // 
            // textoPainel
            // 
            this.textoPainel.BackColor = System.Drawing.Color.DarkRed;
            this.textoPainel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoPainel.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPainel.ForeColor = System.Drawing.Color.Red;
            this.textoPainel.Location = new System.Drawing.Point(297, 176);
            this.textoPainel.Multiline = true;
            this.textoPainel.Name = "textoPainel";
            this.textoPainel.ReadOnly = true;
            this.textoPainel.Size = new System.Drawing.Size(182, 46);
            this.textoPainel.TabIndex = 2;
            this.textoPainel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoPainel.TextChanged += new System.EventHandler(this.painelInversor);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Teal;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(379, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 16);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Teal;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(379, 415);
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
            this.btnRegister.Location = new System.Drawing.Point(4, 401);
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
            this.btnExit.Location = new System.Drawing.Point(80, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfaceCupula.Properties.Resources.Webp2;
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 353);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 464);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.msgShutter);
            this.panel1.Controls.Add(this.OpClShutter);
            this.panel1.Controls.Add(this.textBoxTrapeira);
            this.panel1.Location = new System.Drawing.Point(1, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 70);
            this.panel1.TabIndex = 8;
            // 
            // msgShutter
            // 
            this.msgShutter.BackColor = System.Drawing.Color.DarkRed;
            this.msgShutter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgShutter.ForeColor = System.Drawing.Color.Red;
            this.msgShutter.Location = new System.Drawing.Point(0, 24);
            this.msgShutter.Name = "msgShutter";
            this.msgShutter.ReadOnly = true;
            this.msgShutter.Size = new System.Drawing.Size(143, 23);
            this.msgShutter.TabIndex = 2;
            this.msgShutter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpClShutter
            // 
            this.OpClShutter.BackColor = System.Drawing.Color.Teal;
            this.OpClShutter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpClShutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpClShutter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpClShutter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpClShutter.Location = new System.Drawing.Point(0, 47);
            this.OpClShutter.Name = "OpClShutter";
            this.OpClShutter.Size = new System.Drawing.Size(143, 23);
            this.OpClShutter.TabIndex = 1;
            this.OpClShutter.Text = "Abre/Fecha";
            this.OpClShutter.UseVisualStyleBackColor = false;
            this.OpClShutter.Click += new System.EventHandler(this.OpClShutter_Click);
            // 
            // textBoxTrapeira
            // 
            this.textBoxTrapeira.BackColor = System.Drawing.Color.Teal;
            this.textBoxTrapeira.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTrapeira.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrapeira.Location = new System.Drawing.Point(0, 0);
            this.textBoxTrapeira.Name = "textBoxTrapeira";
            this.textBoxTrapeira.ReadOnly = true;
            this.textBoxTrapeira.Size = new System.Drawing.Size(143, 25);
            this.textBoxTrapeira.TabIndex = 0;
            this.textBoxTrapeira.Text = "Acesso Trapeira";
            this.textBoxTrapeira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(551, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textoPainel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.painelEsquerdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 503);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle do inversor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.painelEsquerdo.ResumeLayout(false);
            this.painelEsquerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelEsquerdo;
        private System.Windows.Forms.Button btnStart_Stop;
        private System.Windows.Forms.Button btnHabilita;
        private System.Windows.Forms.Button btnFw_Rv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textoPainel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox boxControleVel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnControleVelocidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox msgShutter;
        private System.Windows.Forms.Button OpClShutter;
        private System.Windows.Forms.TextBox textBoxTrapeira;
    }
}