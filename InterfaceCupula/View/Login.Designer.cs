namespace InterfaceCupula
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botaoLogin = new System.Windows.Forms.Button();
            this.botaoApagar = new System.Windows.Forms.Button();
            this.BoxNome = new System.Windows.Forms.TextBox();
            this.BoxSenha = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoLogin
            // 
            resources.ApplyResources(this.botaoLogin, "botaoLogin");
            this.botaoLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // botaoApagar
            // 
            resources.ApplyResources(this.botaoApagar, "botaoApagar");
            this.botaoApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoApagar.Name = "botaoApagar";
            this.botaoApagar.UseVisualStyleBackColor = true;
            this.botaoApagar.Click += new System.EventHandler(this.botaoApagar_Click);
            // 
            // BoxNome
            // 
            this.BoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.BoxNome, "BoxNome");
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxNome_MouseClick);
            this.BoxNome.TextChanged += new System.EventHandler(this.BoxNome_TextChanged);
            // 
            // BoxSenha
            // 
            resources.ApplyResources(this.BoxSenha, "BoxSenha");
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.ShortcutsEnabled = false;
            this.BoxSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxSenha_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.botaoLogin);
            this.panel1.Controls.Add(this.botaoApagar);
            this.panel1.Controls.Add(this.BoxSenha);
            this.panel1.Controls.Add(this.BoxNome);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfaceCupula.Properties.Resources.Webp5;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.Button botaoApagar;
        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.TextBox BoxSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

