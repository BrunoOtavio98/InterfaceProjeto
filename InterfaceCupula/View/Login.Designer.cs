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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoLogin
            // 
            this.botaoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoLogin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoLogin.Location = new System.Drawing.Point(61, 273);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(98, 23);
            this.botaoLogin.TabIndex = 0;
            this.botaoLogin.Text = "Realizar Login";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // botaoApagar
            // 
            this.botaoApagar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoApagar.Location = new System.Drawing.Point(214, 273);
            this.botaoApagar.Name = "botaoApagar";
            this.botaoApagar.Size = new System.Drawing.Size(75, 23);
            this.botaoApagar.TabIndex = 1;
            this.botaoApagar.Text = "Apagar";
            this.botaoApagar.UseVisualStyleBackColor = true;
            this.botaoApagar.Click += new System.EventHandler(this.botaoApagar_Click);
            // 
            // BoxNome
            // 
            this.BoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxNome.Location = new System.Drawing.Point(61, 209);
            this.BoxNome.Name = "BoxNome";
            this.BoxNome.Size = new System.Drawing.Size(228, 20);
            this.BoxNome.TabIndex = 2;
            this.BoxNome.Text = "Nome do usuário";
            this.BoxNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxNome_MouseClick);
            this.BoxNome.TextChanged += new System.EventHandler(this.BoxNome_TextChanged);
            // 
            // BoxSenha
            // 
            this.BoxSenha.Location = new System.Drawing.Point(61, 235);
            this.BoxSenha.MaximumSize = new System.Drawing.Size(366, 450);
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.ShortcutsEnabled = false;
            this.BoxSenha.Size = new System.Drawing.Size(228, 20);
            this.BoxSenha.TabIndex = 3;
            this.BoxSenha.Text = "Senha";
            this.BoxSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxSenha_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfaceCupula.Properties.Resources.OBSERVATÓRIO__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 178);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BoxSenha);
            this.Controls.Add(this.BoxNome);
            this.Controls.Add(this.botaoApagar);
            this.Controls.Add(this.botaoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.Button botaoApagar;
        private System.Windows.Forms.TextBox BoxNome;
        private System.Windows.Forms.TextBox BoxSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

