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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracaoAttrMQTT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.painelInfoVel.SuspendLayout();
            this.painelInfoPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.btnMudar);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.novoTopico);
            this.panel1.Controls.Add(this.textoTopicoAtual);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.painelInfoVel);
            this.panel1.Controls.Add(this.cfgInfoVelocidade);
            this.panel1.Controls.Add(this.painelInfoPos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 135);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(309, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 16);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "Novo tópico";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMudar
            // 
            this.btnMudar.BackColor = System.Drawing.Color.Lime;
            this.btnMudar.FlatAppearance.BorderSize = 0;
            this.btnMudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudar.Location = new System.Drawing.Point(177, 109);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(103, 23);
            this.btnMudar.TabIndex = 38;
            this.btnMudar.Text = "Aplicar mudança";
            this.btnMudar.UseVisualStyleBackColor = false;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(46, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 16);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "Tópico atual";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // novoTopico
            // 
            this.novoTopico.BackColor = System.Drawing.Color.LightGray;
            this.novoTopico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.novoTopico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTopico.Location = new System.Drawing.Point(258, 82);
            this.novoTopico.Name = "novoTopico";
            this.novoTopico.Size = new System.Drawing.Size(200, 16);
            this.novoTopico.TabIndex = 36;
            this.novoTopico.TextChanged += new System.EventHandler(this.novoTopico_TextChanged);
            // 
            // textoTopicoAtual
            // 
            this.textoTopicoAtual.BackColor = System.Drawing.Color.LightGray;
            this.textoTopicoAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoTopicoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTopicoAtual.Location = new System.Drawing.Point(3, 82);
            this.textoTopicoAtual.Name = "textoTopicoAtual";
            this.textoTopicoAtual.ReadOnly = true;
            this.textoTopicoAtual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoTopicoAtual.Size = new System.Drawing.Size(200, 16);
            this.textoTopicoAtual.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Configurar Broker",
            "Configurar Porta",
            "Configurar Tópico: Acionamento Trapeira",
            "Configurar Tópico: Movimentação Anti-Horária",
            "Configurar Tópico: Movimentação Horária",
            "Configurar Tópico: Azimute",
            "Configurar Tópico: Sincronização ",
            "Configurar Tópico: Comandos Remoto",
            "Configurar Tópico: Informação Trapeira",
            "Configurar Tópico: Informação Azimute",
            "Configurar Tópico: Informação Home",
            "Configurar Tópico: Informação Park",
            "Configurar Tópico: Informação Resolução",
            "Configurar Tópico: Informação Sincronia",
            "Configurar Tópico: Informação Posição",
            "Configurar Tópico: Informação Velocidade"});
            this.comboBox1.Location = new System.Drawing.Point(111, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // painelInfoVel
            // 
            this.painelInfoVel.Controls.Add(this.aplicarInfoVel);
            this.painelInfoVel.Controls.Add(this.textBox13);
            this.painelInfoVel.Location = new System.Drawing.Point(6, 1017);
            this.painelInfoVel.Name = "painelInfoVel";
            this.painelInfoVel.Size = new System.Drawing.Size(218, 30);
            this.painelInfoVel.TabIndex = 33;
            // 
            // aplicarInfoVel
            // 
            this.aplicarInfoVel.BackColor = System.Drawing.Color.Lime;
            this.aplicarInfoVel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aplicarInfoVel.Location = new System.Drawing.Point(124, 3);
            this.aplicarInfoVel.Name = "aplicarInfoVel";
            this.aplicarInfoVel.Size = new System.Drawing.Size(88, 24);
            this.aplicarInfoVel.TabIndex = 1;
            this.aplicarInfoVel.Text = "Aplicar";
            this.aplicarInfoVel.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.LightGray;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(3, 7);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(115, 16);
            this.textBox13.TabIndex = 0;
            // 
            // cfgInfoVelocidade
            // 
            this.cfgInfoVelocidade.Location = new System.Drawing.Point(6, 994);
            this.cfgInfoVelocidade.Name = "cfgInfoVelocidade";
            this.cfgInfoVelocidade.Size = new System.Drawing.Size(215, 23);
            this.cfgInfoVelocidade.TabIndex = 32;
            this.cfgInfoVelocidade.Text = "Trocar tópico info velocidade";
            this.cfgInfoVelocidade.UseVisualStyleBackColor = true;
            // 
            // painelInfoPos
            // 
            this.painelInfoPos.Controls.Add(this.aplicarInfoPos);
            this.painelInfoPos.Controls.Add(this.textBox16);
            this.painelInfoPos.Location = new System.Drawing.Point(6, 958);
            this.painelInfoPos.Name = "painelInfoPos";
            this.painelInfoPos.Size = new System.Drawing.Size(218, 30);
            this.painelInfoPos.TabIndex = 31;
            // 
            // aplicarInfoPos
            // 
            this.aplicarInfoPos.BackColor = System.Drawing.Color.Lime;
            this.aplicarInfoPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aplicarInfoPos.Location = new System.Drawing.Point(127, 3);
            this.aplicarInfoPos.Name = "aplicarInfoPos";
            this.aplicarInfoPos.Size = new System.Drawing.Size(88, 24);
            this.aplicarInfoPos.TabIndex = 1;
            this.aplicarInfoPos.Text = "Aplicar";
            this.aplicarInfoPos.UseVisualStyleBackColor = false;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.LightGray;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(3, 7);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(115, 16);
            this.textBox16.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::InterfaceCupula.Properties.Resources.Webp3;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 53);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ConfiguracaoAttrMQTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(485, 235);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfiguracaoAttrMQTT";
            this.Text = "ConfiguracaoAttrMQTT";
            this.Load += new System.EventHandler(this.ConfiguracaoAttrMQTT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelInfoVel.ResumeLayout(false);
            this.painelInfoVel.PerformLayout();
            this.painelInfoPos.ResumeLayout(false);
            this.painelInfoPos.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox novoTopico;
        private System.Windows.Forms.TextBox textoTopicoAtual;
    }
}